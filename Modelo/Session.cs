
namespace Refracto_Vendimia.Modelo
{
    public class Session
    {
        public int Id_Recepcion { get; set; }
        public string Nombre_Cooperado { get; set; }
        public int NUM_TICKET { get; set; }
        public string Nombre_Planta { get; set; }
        public int Intento { get; set; }
        public decimal Grado { get; set; }
        public string Hora { get; set; }
        public string Fecha { get; set; }
        public byte[] Imagen { get; set; }
        public int Id_Planta { get; set; }
        public string Operacion { get; set; }
        public string RUT_Cooperado { get; set; }
        public int Tipo_Proceso { get; set; } //3 cuando solo es Refracto

        public int TipoDeConfig { get; set; }
        

        public Session()
        {

        }

        public void RepiteSession(int _newTry)
        {
            Intento = _newTry;
            Fecha = string.Empty;
            Hora = string.Empty;
            Grado = 0;
            Imagen = null;
            Operacion = string.Empty;
        }

        public void Clear_Session()
        {
            NUM_TICKET = 0;
            Id_Recepcion = 0;
            Intento = 0;
            Hora = string.Empty;
            Fecha = string.Empty;
            Imagen = null;
            Grado = 0;
            Operacion = string.Empty;
            //YA NO MODIFICA ID_PLANTA Y NOMBRE PLANTA
        }
    }

}
