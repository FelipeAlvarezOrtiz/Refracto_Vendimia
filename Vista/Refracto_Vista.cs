using Refracto_Vendimia.Modelo;
using Refracto_Vendimia.Vista;
using System;
using Microsoft.Win32;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Reflection;
using System.IO.Ports;
using System.Threading;

namespace Refracto_Vendimia
{
    public partial class Refracto_Vista : Form
    {
        #region Variables
        private readonly Cooperado_Vista _cooperado;
        private readonly Screen[] _screen = Screen.AllScreens;
        private static readonly string PathLog = @"C:/ROMANA/REFRACTO/LOG/log.txt";
        private static readonly string ConfigPath = @"C:/ROMANA/config.txt";
        private static readonly string lockPath = @"C:/ROMANA/debug.lock";
        private static string Nombre_Planta = string.Empty;
        private static int ID_Planta = 0;
        private Session _userSession = new Session();

        private string strBufferIn = string.Empty;
        private delegate void DelegadoAcceso(string Accion);
        #endregion

        public Refracto_Vista()
        {
            if (File.Exists(ConfigPath)) {
                InitializeComponent();
                FechaInfo.Text = DateTime.Now.ToString("dd-MM-yyyy");
                HoraInfo.Text = DateTime.Now.ToString("HH:mm:ss");
                SQLiteManager.CheckDataBase();
                ID_Planta = ConfirmarPlanta();
                if (!XML_Valido(PuertoSerial))
                    OracleManager.SetConfiguracionDePuerto(PuertoSerial, ID_Planta, 1);
                _cooperado = new Cooperado_Vista();
                SetearSegundaPantalla();
                _cooperado.TopMost = true;
                try
                {
                    PuertoSerial.Open();
                }
                catch (Exception _error)
                {
                    MessageBox.Show("PuertoSerial mal configurado.Esto se debe a ERROR. " +
                        "Verifique la conexión y vuelva a iniciar la App. Error: " + _error.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error,MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    Application.Exit();
                }
                TopMost = true;
                _cooperado.PlantaInfo.Text = OracleManager.ObtenerNombrePlanta(ConfirmarPlanta());
                //SetStartUp();
                WindowState = FormWindowState.Minimized;
                EscribirEnLog(GetExecutingDirectoryName());
            }
            else
            {
                MessageBox.Show("NO EXISTE ARCHIVO DE CONFIGURACIONES.","ERROR",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public static string GetExecutingDirectoryName()
        {
            var location = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
            return new FileInfo(location.AbsolutePath).Directory.FullName;
        }

        #region Funciones Segunda Pantalla, ConfirmarPlanta, XML Valido
        private void SetearSegundaPantalla()
        {
            Rectangle bounds;
            if (_screen.Length > 1)
            {
                bounds = _screen[1].Bounds;
                _cooperado.SetBounds(bounds.X, bounds.Y, 900, 900);
                _cooperado.StartPosition = FormStartPosition.Manual;
                _cooperado.Show();
                _cooperado.WindowState = FormWindowState.Maximized;
            }
            else
            {
                _cooperado.WindowState = FormWindowState.Minimized;
                _cooperado.Hide();
                //_cooperado.Show();
                EscribirEnLog("No existe una segunda pantalla, no se puede abrir la segunda vista.");
            }
        }
        private int ConfirmarPlanta()
        {
            return Convert.ToInt32(File.ReadAllText(ConfigPath).Split(';')[0]);
        }

        private bool XML_Valido(SerialPort puertoSerial)
        {
            if (Properties.Settings.Default.ID_Planta == ConfirmarPlanta())
            {
                puertoSerial.PortName = Properties.Settings.Default.NombrePuerto;
                puertoSerial.BaudRate = Properties.Settings.Default.BaudRate;
                puertoSerial.Parity = OracleManager.ObtenerParidad(Properties.Settings.Default.Paridad);
                puertoSerial.DataBits = Properties.Settings.Default.Databits;
                Properties.Settings.Default.Save();
                return true;
            }
            else
            {
                EscribirEnLog("La configuración no es la Misma.");
                return false;
            }
        }
        #endregion

        private void TickEvent(object sender, EventArgs e)
        {
            HoraInfo.Text = DateTime.Now.ToString("HH:mm:ss");
            if (SQLiteManager.DebeEjecutarse())
            {
                BringToFront();
                Show();
                TopMost = true;
                RefractoIcon.Visible = false;
                WindowState = FormWindowState.Maximized;
                SetearUI_Session(_userSession);
                SQLiteManager.EliminarRegistro(_userSession.Id_Recepcion);
                OracleManager.VerificarIntegridadBaseDeDatos(_userSession.Id_Planta);
                SQLiteManager.CambiarEstado_App(2);
            }
            if (SQLiteManager.DebeMinimizarse())
            {
                Limpiar_UI();
                //SQLiteManager.CambiarEstado_App(0);
                WindowState = FormWindowState.Minimized;
                _userSession.Clear_Session();
                Hide();
                RefractoIcon.Visible = true;
                RefractoIcon.ShowBalloonTip(1000);
            }
            else
            {
                _cooperado.BringToFront();
            }
        }

        private void Limpiar_UI()
        {
            #region Limpiar Interfaz Trabajador
            //PlantaInfo.Text = "Planta: Sin INFO";
            NombrePlace.Text = "Nombre: Sin INFO";
            RutCooperado.Text = "RUT: Sin INFO";
            TicketText.Text = "0";
            IntentoText.Text = "0";
            #endregion
            #region Limpiar UI Cooperado
            //_cooperado.PlantaInfo.Text = "Planta: Sin INFO ";
            _cooperado.TicketText.Text = "0";
            _cooperado.IntentoText.Text = "0";
            _cooperado.NombreCooperado.Text = "Nombre: Sin INFO";
            _cooperado.RutInfo.Text = "R.U.T.: Sin INFO";
            #endregion
            #region Limpiar Session
            _userSession.Clear_Session();
            #endregion
        }

        #region DELEGADOS Y RECEPCION DE DATA
        private void DataRecibida(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                _userSession.TipoDeConfig = ConfirmarPlanta();
                var Resultado = PuertoSerial.ReadExisting();
                switch (_userSession.TipoDeConfig)
                {
                    #region Vicuña
                    case 1:
                        if (Resultado.Length == 3)
                        {
                            PuertoSerial.DiscardInBuffer();
                            break;
                        }
                        var Vicuna = new string(Resultado.Take(5).ToArray()).Replace("F", "").Replace("M", "");
                        PuertoSerial.DiscardInBuffer();
                        AccesoInterrupcion(Vicuna);
                        break;
                    #endregion

                    #region Salamanca
                    case 2:
                        Resultado = Resultado.Substring(0, 5);
                        PuertoSerial.DiscardInBuffer();
                        AccesoInterrupcion(Resultado);
                        break;
                    #endregion

                    #region Sotaqui
                    case 3:
                        if (Resultado.Contains("F") && Resultado.Contains("M")) {
                            Resultado = new string(Resultado.Take(5).ToArray()).Replace("F", "").Replace("M", "");
                            PuertoSerial.DiscardInBuffer();
                            AccesoInterrupcion(Resultado);
                            break;
                        }
                        else
                        {
                            AccesoInterrupcion("00.0");
                            break;
                        }
                    #endregion

                    #region Alto del Carmen
                    case 4:
                        if (_userSession.Id_Recepcion > 0)
                        {
                            if (Resultado.Contains("F") && Resultado.Contains("M"))
                            {
                                var AltoDelCarmen = new string(Resultado.Take(5).ToArray()).Replace("F", "").Replace("M", "");
                                PuertoSerial.DiscardInBuffer();
                                AccesoInterrupcion(AltoDelCarmen);
                                break;
                            }
                            else
                            {
                                AccesoInterrupcion("00.00");
                                break;
                            }
                        }
                        else
                        {
                            AccesoInterrupcion("00.0");
                            break;
                        }
                    #endregion

                    #region Hurtado
                    case 6:
                        if (_userSession.Id_Recepcion > 0)
                        {
                            if (Resultado.Contains("F") && Resultado.Contains("M"))
                            {
                                var Hurtado = new string(Resultado.Take(5).ToArray()).Replace("F", "").Replace("M", "").Replace(".",",");
                                PuertoSerial.DiscardInBuffer();
                                AccesoInterrupcion(Hurtado);
                                break;
                            }
                            else
                            {
                                AccesoInterrupcion("00.00");
                                break;
                            }
                        }
                        else
                        {
                            AccesoInterrupcion("00.0");
                            break;
                        }
                    #endregion

                    #region Montegrande
                    case 7:
                        if (_userSession.Id_Recepcion > 0)
                        {
                            if (Resultado.Contains("F") && Resultado.Contains("M"))
                            {
                                var Montegrande = new string(Resultado.Take(5).ToArray()).Replace("F", "").Replace("M", "");
                                PuertoSerial.DiscardInBuffer();
                                AccesoInterrupcion(Montegrande);
                                break;
                            }
                            else
                            {
                                AccesoInterrupcion("00.00");
                                break;
                            }
                        }
                        else
                        {
                            AccesoInterrupcion("00.0");
                            break;
                        }
                    #endregion

                    #region Chimba
                    case 8:
                        if (_userSession.Id_Recepcion > 0) {
                            if (Resultado.Contains("F") && Resultado.Contains("M"))
                            {
                                var Ovalle = new string(Resultado.Take(5).ToArray()).Replace("F", "").Replace("M", "");
                                PuertoSerial.DiscardInBuffer();
                                AccesoInterrupcion(Ovalle);
                                break;
                            }
                            else
                            {
                                AccesoInterrupcion("00.00");
                                break;
                            }
                        }
                        else
                        {
                            AccesoInterrupcion("00.0");
                            break;
                        }
                    #endregion

                    #region Atacama
                    case 9:
                        EscribirEnLog("Leyendo Atacama");
                        EscribirEnLog("Info de Ticket: ID_Recepcion: "+_userSession.Id_Recepcion+" " +
                            "ID_PLANTA:"+_userSession.Id_Planta+"");
                        EscribirEnLog("Con resultado:"+Resultado);
                        if (_userSession.Id_Recepcion > 0) {
                            if (Resultado.Length == 3)
                            {
                                PuertoSerial.DiscardInBuffer();
                                break;
                            }
                            var Atacama = new string(Resultado.Take(5).ToArray()).Replace("F", "").Replace("M", "");
                            PuertoSerial.DiscardInBuffer();
                            AccesoInterrupcion(Atacama);
                            break;
                        }
                        else
                        {
                            AccesoInterrupcion("00,0");
                            break;
                        }
                        #endregion
                
                }
            }
            catch (ArgumentException)
            {
                //EscribirEnLog("Error en el recibimiento de Data. Error : "+ error.Message);
                //Error al parsear
                _cooperado.GradoText.Text = "00.00";
            }
            catch (TimeoutException ex)
            {
                EscribirEnLog("Error en los instrumentos de medición.Error: "+ex.Message);
            }
        }

        private void LiberarRecursos()
        {
            if (PuertoSerial.IsOpen)
                PuertoSerial.DiscardInBuffer();
                PuertoSerial.Close();

        }

        private void AccesoForm(string Data)
        {
            try
            {
                strBufferIn = Data;
                strBufferIn = strBufferIn.Replace(".", ",");
                //Aqui tratar la Data
                _cooperado.GradoText.Text = strBufferIn;
                GradoText.Text = strBufferIn;
                _userSession.Grado = Convert.ToDecimal(strBufferIn);
            }
            catch (Exception)
            {
                _cooperado.GradoText.Text = "00.00";
                GradoText.Text = "00.00";
                _userSession.Grado = 0;
            }
        }

        private void AccesoInterrupcion(string Data)
        {
            try
            {
                DelegadoAcceso var_Delegado = new DelegadoAcceso(AccesoForm);
                object[] arg = { Data };
                Invoke(var_Delegado, arg);
            }
            catch (Exception)
            {
                EscribirEnLog("MAQUINA PRENDIDA ANTES DE LANZAR EL SOFTWARE. APLICANDO REMEDIAL ...");
            }
        }
        private void EscribirEnLog(string Texto)
        {
            string[] NuevaLinea = new string[] { DateTime.Now.ToString() + " " + Texto };
            File.AppendAllLines(PathLog, NuevaLinea);
        }
        #endregion

        private void SetStartUp()
        {
            try
            {
                var key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run",
                    RegistryKeyPermissionCheck.ReadWriteSubTree);
                //RegistryKey rk = Registry.CurrentUser.OpenSubKey
                //    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", false);
                key.SetValue("Administrador Refracto", Application.ExecutablePath);
            }
            catch (UnauthorizedAccessException)
            {
                EscribirEnLog("No se puede obtener acceso al Registro de Windows.");
            }
        }

        private void InsertarEnBaseDeDatos(Session _userSession)
        { 
            ScreenManager.TomarPantallazo(_userSession);
            SQLiteManager.InsertarDatos(_userSession);
            OracleManager.InsertarDatosEnPasarela(_userSession);
            OracleManager.InsertarFotoRecepcion(_userSession);
        }

        private void InsertarEnBackUp(Session _userSession)
        {
            ScreenManager.TomarPantallazo(_userSession);
            SQLiteManager.InsertarDatos(_userSession);
            OracleManager.InsertarFotoRecepcion(_userSession);
        }

        private void Closing_Event(object sender,FormClosingEventArgs e)
        {
            if (_userSession.Grado == 0 && _userSession.Intento == 1) {
                DialogResult result = MessageBox.Show("Esta aplicación es necesaria para los procesos de Toma de " +
                    "Grado. ¿Está seguro que realmente desea cerrarla?", "Confirmación",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) {
                    WindowState = FormWindowState.Minimized;
                    _userSession.Clear_Session();
                    Limpiar_UI();
                    SQLiteManager.CambiarEstado_App(4);
                    
                    //if (PuertoSerial.IsOpen)
                    //    PuertoSerial.Close();
                    //SQLiteManager.CambiarEstado_App(4);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("NO PUEDES CANCELAR LUEGO DE HABER LEIDO EL GRADO.","ALERTA",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
        }

        private void RefrescarInterfaz(Session _userSession)
        {
            _cooperado.IntentoText.Text = _userSession.Intento.ToString();
            _cooperado.GradoText.Text = _userSession.Grado.ToString();
            IntentoText.Text = _userSession.Intento.ToString();
        }

        private void RepetirClick(object sender, EventArgs e)
        {
            var NextVal = Convert.ToInt32(IntentoText.Text) + 1;
            if (NextVal <= 3) {
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea repetir la toma de grado?. " +
                    "Esto anulará todos los datos obtenidos y deberá repetir el proceso.", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (resultado == DialogResult.Yes)
                {
                    InsertarEnBackUp(_userSession);
                    _userSession.RepiteSession(NextVal);
                    RefrescarInterfaz(_userSession);
                }
            }
            else
            {
                if (_userSession.Grado == 0) {
                    MessageBox.Show("NO PUEDES REALIZAR MÁS REPETICIONES PARA ESTE TICKET.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    MessageBox.Show("NO PUEDES REALIZAR MÁS REPETICIONES PARA ESTE TICKET. LA ULTIMA MEDICIÓN " +
                        "SERÁ SUBIDA DE MANERA AUTOMATICA.", "INFORMACIÓN",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    InsertarEnBaseDeDatos(_userSession);
                    SQLiteManager.CambiarEstado_App(3);
                    Limpiar_UI();
                    Hide();
                    Thread.Sleep(2000);
                    SQLiteManager.CambiarEstado_App(0);
                }

            }
        }

        private void SetearUI_Session(Session _userSession)
        {
            SQLiteManager.Configurar_Session(_userSession);
            #region Actualizar UI Trabajador
            PlantaInfo.Text = "Planta: "+_userSession.Nombre_Planta;
            NombrePlace.Text = _userSession.Nombre_Cooperado;
            RutCooperado.Text = _userSession.RUT_Cooperado;
            TicketText.Text = _userSession.NUM_TICKET.ToString();
            IntentoText.Text = _userSession.Intento.ToString();
            #endregion
            #region Actualizar UI Cooperado
            _cooperado.PlantaInfo.Text = "Planta: " + _userSession.Nombre_Planta;
            _cooperado.TicketText.Text = _userSession.NUM_TICKET.ToString();
            _cooperado.IntentoText.Text = _userSession.Intento.ToString();
            _cooperado.NombreCooperado.Text = _userSession.Nombre_Cooperado;
            _cooperado.RutInfo.Text = _userSession.RUT_Cooperado;
            #endregion
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Confirma guardar Grado?, Esta acción no puede deshacerse.",
                "Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (resultado == DialogResult.Yes) {
                OracleManager.VerificarIntegridadBaseDeDatos(_userSession.Id_Planta);
                InsertarEnBaseDeDatos(_userSession);
                SQLiteManager.CambiarEstado_App(3);
                Limpiar_UI();
                Hide();
                Thread.Sleep(2000);
                SQLiteManager.CambiarEstado_App(0);
                //SQLiteManager.CambiarEstado_Data(2, _userSession);
            }
        }

        private void ResizeEvent(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                RefractoIcon.Visible = true;
                RefractoIcon.ShowBalloonTip(2500);
            }
        }
    
    }
}
