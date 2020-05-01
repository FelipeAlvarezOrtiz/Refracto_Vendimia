using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Refracto_Vendimia.Modelo
{
    static class ScreenManager
    {
        public static Screen[] Pantallas = Screen.AllScreens;
        private static readonly string PathLog = @"C:/ROMANA/REFRACTO/LOG/log.txt";
        private static readonly string PathScreens = @"C:/ROMANA/REFRACTO/PANTALLAZOS";

        public static bool TieneMasDeUnaPantalla() => Pantallas.Length > 1 ? true : false;

        public static bool CheckFolder_Pantallazos() => Directory.Exists(PathScreens) ? true : false;

        public static void EscribirEnLog(string Texto)
        {
            string[] NuevaLinea = new string[] { DateTime.Now.ToString() + " " + Texto };
            File.AppendAllLines(PathLog, NuevaLinea);
        }

        public static void TomarPantallazo(Session _session)
        {
            if (CheckFolder_Pantallazos())
            {
                if (TieneMasDeUnaPantalla())
                {
                    Rectangle bounds = Pantallas[1].Bounds;
                    var ScreenShot = new Bitmap(bounds.Width, bounds.Height,
                                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    var gfxScreenShot = Graphics.FromImage(ScreenShot);
                    gfxScreenShot.CopyFromScreen(
                                                bounds.X,
                                                bounds.Y,
                                                0,
                                                0,
                                                bounds.Size,
                                                CopyPixelOperation.SourceCopy);
                    ScreenShot.Save(PathScreens + "Guardado.png", ImageFormat.Png);
                    _session.Imagen = ObtenerBytes_Imagen(PathScreens + "Guardado.png");

                }
                else
                {
                    #region Toma Pantallazo a la Ventana Trabajador
                    Rectangle bounds = Pantallas[0].Bounds;
                    var ScreenShot = new Bitmap(bounds.Width, bounds.Height,
                                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    var gfxScreenShot = Graphics.FromImage(ScreenShot);
                    gfxScreenShot.CopyFromScreen(
                                                bounds.X,
                                                bounds.Y,
                                                0,
                                                0,
                                                bounds.Size,
                                                CopyPixelOperation.SourceCopy);
                    ScreenShot.Save(PathScreens + "Guardado.png", ImageFormat.Png);
                    _session.Imagen = ObtenerBytes_Imagen(PathScreens + "Guardado.png");
                    #endregion
                }
            }
            else
            {
                EscribirEnLog("No existe la Carpeta pantallazos en el disco local.");
            }
        }

        public static byte[] ObtenerBytes_Imagen(string Path)
        {
            byte[] _imageByte;
            using (Image newImage = new Bitmap(Path))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    newImage.Save(ms, ImageFormat.Png);
                    _imageByte = ms.ToArray();
                    return _imageByte;
                }
            }
        }

    }
}
