using System;
using System.Windows.Forms;

namespace Refracto_Vendimia.Vista
{
    public partial class Cooperado_Vista : Form
    {
        public Cooperado_Vista()
        {
            InitializeComponent();
            HoraInfo.Text = DateTime.Now.ToString("HH:mm:ss");
            FechaInfo.Text = DateTime.Now.ToString("dd-MM-yyyy");
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void TickerEvent(object sender, EventArgs e)
        {
            HoraInfo.Text = DateTime.Now.ToString("HH:mm:ss");
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) {
                MessageBox.Show("Esta Aplicación No puede Cerrarse. PROHIBIDO.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                e.Cancel = true;
            }
        }
    }
}
