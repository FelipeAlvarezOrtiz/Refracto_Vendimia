using Oracle.ManagedDataAccess.Client;
using System;
using System.IO;
using System.IO.Ports;

namespace Refracto_Vendimia.Modelo
{
    public static class OracleManager
    {
        private readonly static string ConexionString = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 172.16.16.236)(PORT = 1521))) " +
                                "(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = orcl.capel.cl))); User Id = PROD_ADM; " +
                                "Password = PROD1530;";
        //private readonly static string ConexionString = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 172.16.16.240)(PORT = 1521))) " +
        //                        "(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = desa.capel.cl))); User Id = usr_prod; " +
        //                        "Password = usrprod;";
        private readonly static string PathLog = @"C:/ROMANA/REFRACTO/LOG/log.txt";
        public static void SetConfiguracionDePuerto(SerialPort puertoSerial, int ID_Planta, int TipoProceso)
        {
            try
            {
                using (var conexion = new OracleConnection(ConexionString))
                {
                    conexion.Open();
                    EscribirEnLog("Conexión a Oracle Exitosa.");
                    using (var command = conexion.CreateCommand())
                    {
                        command.CommandText = "Select Nombre_Puerto,byte, paridad,databits,observacion " +
                            "from cooper_adm.parametro where ID_Planta = " + ID_Planta + " and ID_Tipo =" + TipoProceso;
                        command.CommandType = System.Data.CommandType.Text;
                        var dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            Properties.Settings.Default.ID_Planta = ID_Planta;
                            Properties.Settings.Default.NombrePuerto = dr.GetString(0);
                            puertoSerial.PortName = Properties.Settings.Default.NombrePuerto;
                            Properties.Settings.Default.BaudRate = dr.GetInt32(1);
                            puertoSerial.BaudRate = Properties.Settings.Default.BaudRate;
                            Properties.Settings.Default.Paridad = dr.GetString(2);
                            puertoSerial.Parity = ObtenerParidad(Properties.Settings.Default.Paridad);
                            Properties.Settings.Default.Databits = dr.GetInt32(3);
                            puertoSerial.DataBits = Properties.Settings.Default.Databits;
                            Properties.Settings.Default.Valor_Anexado = dr.GetString(4);
                        }
                        Properties.Settings.Default.Save();
                        conexion.Close();
                    }
                }


            }
            catch (Exception e)
            {
                EscribirEnLog(e.Message);
            }
        }
        private static void EscribirEnLog(string Texto)
        {
            string[] NuevaLinea = new string[] { DateTime.Now.ToString() + " " + Texto };
            File.AppendAllLines(PathLog, NuevaLinea);
        }

        public static void InsertarDatosEnPasarela(Session _userSession)
        {
            try {
                using (var conexion = new OracleConnection(ConexionString))
                {
                    conexion.Open();
                    var comando = "insert into cooper_adm.peso_romana" +
                                    "(id_peso_romana,Grado,Estado,Fecha,ID_Planta,Tipo_Proceso,Temperatura,Volumen) " +
                                    "VALUES(cooper_adm.seq_peso_romana.nextval,:grado,0,sysdate,:planta,1,0,0)";
                    using (var cmd = new OracleCommand(comando, conexion))
                    {
                        OracleParameter[] parametros = new OracleParameter[]
                        {
                            new OracleParameter("grado",_userSession.Grado),
                            //new OracleParameter("fecha",_userSession.Fecha),
                            new OracleParameter("planta",_userSession.Id_Planta),
                            //new OracleParameter("proceso",_userSession.Tipo_Proceso)
                        };
                        cmd.Parameters.AddRange(parametros);
                        cmd.ExecuteNonQuery();
                    }
                    conexion.Close();
                    EscribirEnLog("Datos insertados en pasarela correctamente.");

                }
            }
            catch (OracleException error)
            {
                EscribirEnLog("Error al insertar datos en pasarela. Error: "+error.Message);
            }
        }

        public static void InsertarFotoRecepcion(Session _userSession)
        {
            try
            {
                using (var conexion = new OracleConnection(ConexionString))
                {
                    conexion.Open();
                    var comando = "insert into cooper_adm.recepcion_uva_foto " +
                                    "(ID_RECEPCION_UVA,OBSERVACION,IMAGEN,LECTURA,FECHA,COSECHA,ID_PLANTA,NUM_TICKET_ATENCION,TIPO_CONTROL) " +
                                    "VALUES(:id_recepcion,:observacion,:imagen,:lectura,sysdate,:cosecha,:planta,:ticket,:control)";
                    using (var cmd = new OracleCommand(comando, conexion))
                    {
                        OracleParameter[] parametros = new OracleParameter[]
                        {
                        new OracleParameter("id_recepcion",_userSession.Id_Recepcion),
                        new OracleParameter("observacion","No hay problemas."),
                        new OracleParameter("imagen",_userSession.Imagen),
                        new OracleParameter("lectura",_userSession.Intento),
                        new OracleParameter("cosecha",DateTime.Now.Year),
                        new OracleParameter("planta",_userSession.Id_Planta),
                        new OracleParameter("ticket",_userSession.NUM_TICKET),
                        new OracleParameter("control",2),
                        };
                        cmd.Parameters.AddRange(parametros);
                        cmd.ExecuteNonQuery();
                    }
                    conexion.Clone();
                    EscribirEnLog("Imagen Insertada correctamente en BD.");
                }
            }
            catch (OracleException error)
            {
                EscribirEnLog("Error al Insertar Imagen. Error: "+error.Message);
            }
        }

        public static string ObtenerNombrePlanta(int _idPlanta)
        {
            try
            {
                using (var conexion = new OracleConnection(ConexionString))
                {
                    conexion.Open();
                    var Planta = string.Empty;
                    using (var command = conexion.CreateCommand())
                    {
                        command.CommandText = "SELECT NOMBRE_PLANTA FROM COOPER_ADM.PLANTA WHERE ID_PLANTA = "+_idPlanta;
                        command.CommandType = System.Data.CommandType.Text;
                        var dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            Planta = dr.GetString(0);
                        }
                    }
                    conexion.Close();
                    return Planta;
                }
            }
            catch (OracleException error)
            {
                EscribirEnLog("Error al obtener el nombre de la planta. Error: "+error.Message);
                return "ERROR";
            }
        }

        public static Parity ObtenerParidad(string _paridadEnArchivo)
        {
            switch (_paridadEnArchivo)
            {
                case "e":
                    return Parity.Even;
                case "None":
                    return Parity.None;
            }
            return Parity.None;
        }
    
        public static void InsertarEstadoApp(int _estado, int _idPlanta, int _proceso)
        {
            try
            {
                using (var conexion = new OracleConnection(ConexionString))
                {
                    conexion.Open();
                    var comando = "insert into cooper_adm.peso_romana" +
                                    "(id_peso_romana,Estado,ID_Planta,Tipo_Proceso) " +
                                    "VALUES(cooper_adm.seq_peso_romana.nextval,:estado,:planta,:proceso)";
                    using (var cmd = new OracleCommand(comando, conexion))
                    {
                        OracleParameter[] parametros = new OracleParameter[]
                        {
                            new OracleParameter("estado",_estado),
                            new OracleParameter("planta",_idPlanta),
                            new OracleParameter("proceso",_proceso)
                        };
                        cmd.Parameters.AddRange(parametros);
                        cmd.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (OracleException error)
            {
                EscribirEnLog("Error al Insertar el Estado APP en Pasarela. Error: "+error.Message);
            }
        }


        public static void VerificarIntegridadBaseDeDatos(int _idPlanta)
        {
            try
            {
                using (var Conexion = new OracleConnection(ConexionString))
                {
                    Conexion.Open();
                    using (var Command = Conexion.CreateCommand())
                    {
                        Command.CommandText = "Select ID_PESO_ROMANA from cooper_adm.peso_romana where Estado = 0 and " +
                            "ID_PLANTA = " + _idPlanta + " and TIPO_PROCESO = 1";
                        Command.CommandType = System.Data.CommandType.Text;
                        var dr = Command.ExecuteReader();
                        while (dr.Read())
                        {
                            EscribirEnLog("Errores encontrados en BD con estado 0 sin capturar.");
                            using (var Comando = Conexion.CreateCommand())
                            {
                                Comando.CommandText = "UPDATE cooper_adm.peso_romana SET ESTADO = 1, CADENA = 'ERROR ERP en REFRACTO' " +
                                    "WHERE ID_PESO_ROMANA = " + dr.GetInt32(0);
                                Comando.ExecuteNonQuery();
                            }
                        }
                    }
                    Conexion.Close();
                }
            }
            catch (OracleException e)
            {
                EscribirEnLog("Error en la Consulta Oracle. Error : " + e.Message);
            }
        }

    }

}
