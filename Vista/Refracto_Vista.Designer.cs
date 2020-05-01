namespace Refracto_Vendimia
{
    partial class Refracto_Vista
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Refracto_Vista));
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TopLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PlantaInfo = new System.Windows.Forms.Label();
            this.RutCooperado = new System.Windows.Forms.Label();
            this.NombrePlace = new System.Windows.Forms.Label();
            this.MidLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Separador = new Bunifu.Framework.UI.BunifuSeparator();
            this.FullLayout = new System.Windows.Forms.TableLayoutPanel();
            this.GradoCard = new Bunifu.Framework.UI.BunifuCards();
            this.GradoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Gradolbl = new System.Windows.Forms.Label();
            this.GradoText = new System.Windows.Forms.Label();
            this.InfoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TicketLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Ticketlbl = new System.Windows.Forms.Label();
            this.TicketText = new System.Windows.Forms.Label();
            this.LecturaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.IntentoText = new System.Windows.Forms.Label();
            this.Lecturalbl = new System.Windows.Forms.Label();
            this.HoraFechaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.HoraInfo = new System.Windows.Forms.Label();
            this.FechaInfo = new System.Windows.Forms.Label();
            this.BotonesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.GuardarButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.RepetirButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.PuertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.RefractoIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainLayout.SuspendLayout();
            this.TopLayout.SuspendLayout();
            this.MidLayout.SuspendLayout();
            this.FullLayout.SuspendLayout();
            this.GradoCard.SuspendLayout();
            this.GradoLayout.SuspendLayout();
            this.InfoLayout.SuspendLayout();
            this.TicketLayout.SuspendLayout();
            this.LecturaLayout.SuspendLayout();
            this.HoraFechaLayout.SuspendLayout();
            this.BotonesLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.TopLayout, 0, 0);
            this.MainLayout.Controls.Add(this.MidLayout, 0, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 2;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MainLayout.Size = new System.Drawing.Size(1119, 670);
            this.MainLayout.TabIndex = 0;
            // 
            // TopLayout
            // 
            this.TopLayout.ColumnCount = 2;
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.85786F));
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.14214F));
            this.TopLayout.Controls.Add(this.NombrePlace, 1, 0);
            this.TopLayout.Controls.Add(this.PlantaInfo, 0, 0);
            this.TopLayout.Controls.Add(this.RutCooperado, 0, 1);
            this.TopLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopLayout.Location = new System.Drawing.Point(4, 4);
            this.TopLayout.Margin = new System.Windows.Forms.Padding(4);
            this.TopLayout.Name = "TopLayout";
            this.TopLayout.RowCount = 2;
            this.TopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.Size = new System.Drawing.Size(1111, 126);
            this.TopLayout.TabIndex = 0;
            // 
            // PlantaInfo
            // 
            this.PlantaInfo.AutoSize = true;
            this.PlantaInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlantaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlantaInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.PlantaInfo.Location = new System.Drawing.Point(4, 0);
            this.PlantaInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlantaInfo.Name = "PlantaInfo";
            this.PlantaInfo.Size = new System.Drawing.Size(623, 63);
            this.PlantaInfo.TabIndex = 0;
            this.PlantaInfo.Text = "Planta : Sin Información";
            this.PlantaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RutCooperado
            // 
            this.RutCooperado.AutoSize = true;
            this.RutCooperado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RutCooperado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RutCooperado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.RutCooperado.Location = new System.Drawing.Point(4, 63);
            this.RutCooperado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RutCooperado.Name = "RutCooperado";
            this.RutCooperado.Size = new System.Drawing.Size(623, 63);
            this.RutCooperado.TabIndex = 1;
            this.RutCooperado.Text = "RutCooperado";
            this.RutCooperado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NombrePlace
            // 
            this.NombrePlace.AutoSize = true;
            this.NombrePlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NombrePlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrePlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.NombrePlace.Location = new System.Drawing.Point(635, 0);
            this.NombrePlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombrePlace.Name = "NombrePlace";
            this.NombrePlace.Size = new System.Drawing.Size(472, 63);
            this.NombrePlace.TabIndex = 2;
            this.NombrePlace.Text = "NombreCooperado";
            this.NombrePlace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MidLayout
            // 
            this.MidLayout.ColumnCount = 1;
            this.MidLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MidLayout.Controls.Add(this.Separador, 0, 0);
            this.MidLayout.Controls.Add(this.FullLayout, 0, 1);
            this.MidLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MidLayout.Location = new System.Drawing.Point(4, 138);
            this.MidLayout.Margin = new System.Windows.Forms.Padding(4);
            this.MidLayout.Name = "MidLayout";
            this.MidLayout.RowCount = 2;
            this.MidLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.051643F));
            this.MidLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.94836F));
            this.MidLayout.Size = new System.Drawing.Size(1111, 528);
            this.MidLayout.TabIndex = 1;
            // 
            // Separador
            // 
            this.Separador.BackColor = System.Drawing.Color.Transparent;
            this.Separador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Separador.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separador.LineThickness = 2;
            this.Separador.Location = new System.Drawing.Point(5, 5);
            this.Separador.Margin = new System.Windows.Forms.Padding(5);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(1101, 6);
            this.Separador.TabIndex = 0;
            this.Separador.Transparency = 255;
            this.Separador.Vertical = false;
            // 
            // FullLayout
            // 
            this.FullLayout.ColumnCount = 3;
            this.FullLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.19598F));
            this.FullLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.0402F));
            this.FullLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.638191F));
            this.FullLayout.Controls.Add(this.GradoCard, 1, 0);
            this.FullLayout.Controls.Add(this.InfoLayout, 0, 0);
            this.FullLayout.Controls.Add(this.HoraFechaLayout, 1, 1);
            this.FullLayout.Controls.Add(this.BotonesLayout, 0, 1);
            this.FullLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FullLayout.Location = new System.Drawing.Point(4, 20);
            this.FullLayout.Margin = new System.Windows.Forms.Padding(4);
            this.FullLayout.Name = "FullLayout";
            this.FullLayout.RowCount = 3;
            this.FullLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.29412F));
            this.FullLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.FullLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.FullLayout.Size = new System.Drawing.Size(1103, 504);
            this.FullLayout.TabIndex = 1;
            // 
            // GradoCard
            // 
            this.GradoCard.BackColor = System.Drawing.Color.White;
            this.GradoCard.BorderRadius = 5;
            this.GradoCard.BottomSahddow = true;
            this.GradoCard.color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.GradoCard.Controls.Add(this.GradoLayout);
            this.GradoCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GradoCard.LeftSahddow = false;
            this.GradoCard.Location = new System.Drawing.Point(436, 4);
            this.GradoCard.Margin = new System.Windows.Forms.Padding(4);
            this.GradoCard.Name = "GradoCard";
            this.GradoCard.RightSahddow = true;
            this.GradoCard.ShadowDepth = 20;
            this.GradoCard.Size = new System.Drawing.Size(632, 422);
            this.GradoCard.TabIndex = 0;
            // 
            // GradoLayout
            // 
            this.GradoLayout.ColumnCount = 1;
            this.GradoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GradoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.GradoLayout.Controls.Add(this.Gradolbl, 0, 0);
            this.GradoLayout.Controls.Add(this.GradoText, 0, 1);
            this.GradoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GradoLayout.Location = new System.Drawing.Point(0, 0);
            this.GradoLayout.Margin = new System.Windows.Forms.Padding(4);
            this.GradoLayout.Name = "GradoLayout";
            this.GradoLayout.RowCount = 2;
            this.GradoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.26946F));
            this.GradoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.73054F));
            this.GradoLayout.Size = new System.Drawing.Size(632, 422);
            this.GradoLayout.TabIndex = 1;
            // 
            // Gradolbl
            // 
            this.Gradolbl.AutoSize = true;
            this.Gradolbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gradolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gradolbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.Gradolbl.Location = new System.Drawing.Point(4, 0);
            this.Gradolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Gradolbl.Name = "Gradolbl";
            this.Gradolbl.Size = new System.Drawing.Size(624, 64);
            this.Gradolbl.TabIndex = 0;
            this.Gradolbl.Text = "Grado";
            this.Gradolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GradoText
            // 
            this.GradoText.AutoSize = true;
            this.GradoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GradoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.GradoText.Location = new System.Drawing.Point(4, 64);
            this.GradoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GradoText.Name = "GradoText";
            this.GradoText.Size = new System.Drawing.Size(624, 358);
            this.GradoText.TabIndex = 1;
            this.GradoText.Text = "00.0";
            this.GradoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoLayout
            // 
            this.InfoLayout.ColumnCount = 3;
            this.InfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.InfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.InfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.InfoLayout.Controls.Add(this.TicketLayout, 1, 1);
            this.InfoLayout.Controls.Add(this.LecturaLayout, 1, 3);
            this.InfoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoLayout.Location = new System.Drawing.Point(4, 4);
            this.InfoLayout.Margin = new System.Windows.Forms.Padding(4);
            this.InfoLayout.Name = "InfoLayout";
            this.InfoLayout.RowCount = 5;
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.855072F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.4058F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.76023F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.90059F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.74269F));
            this.InfoLayout.Size = new System.Drawing.Size(424, 422);
            this.InfoLayout.TabIndex = 1;
            // 
            // TicketLayout
            // 
            this.TicketLayout.ColumnCount = 1;
            this.TicketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TicketLayout.Controls.Add(this.Ticketlbl, 0, 0);
            this.TicketLayout.Controls.Add(this.TicketText, 0, 1);
            this.TicketLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketLayout.Location = new System.Drawing.Point(46, 45);
            this.TicketLayout.Margin = new System.Windows.Forms.Padding(4);
            this.TicketLayout.Name = "TicketLayout";
            this.TicketLayout.RowCount = 2;
            this.TicketLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.05495F));
            this.TicketLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.94505F));
            this.TicketLayout.Size = new System.Drawing.Size(331, 112);
            this.TicketLayout.TabIndex = 0;
            // 
            // Ticketlbl
            // 
            this.Ticketlbl.AutoSize = true;
            this.Ticketlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.Ticketlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ticketlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Ticketlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(116)))), ((int)(((byte)(145)))));
            this.Ticketlbl.Location = new System.Drawing.Point(4, 0);
            this.Ticketlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ticketlbl.Name = "Ticketlbl";
            this.Ticketlbl.Size = new System.Drawing.Size(323, 50);
            this.Ticketlbl.TabIndex = 0;
            this.Ticketlbl.Text = "Ticket";
            this.Ticketlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TicketText
            // 
            this.TicketText.AutoSize = true;
            this.TicketText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.TicketText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.TicketText.Location = new System.Drawing.Point(4, 50);
            this.TicketText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TicketText.Name = "TicketText";
            this.TicketText.Size = new System.Drawing.Size(323, 62);
            this.TicketText.TabIndex = 1;
            this.TicketText.Text = "0";
            this.TicketText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LecturaLayout
            // 
            this.LecturaLayout.ColumnCount = 1;
            this.LecturaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LecturaLayout.Controls.Add(this.IntentoText, 0, 1);
            this.LecturaLayout.Controls.Add(this.Lecturalbl, 0, 0);
            this.LecturaLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LecturaLayout.Location = new System.Drawing.Point(46, 252);
            this.LecturaLayout.Margin = new System.Windows.Forms.Padding(4);
            this.LecturaLayout.Name = "LecturaLayout";
            this.LecturaLayout.RowCount = 2;
            this.LecturaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LecturaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LecturaLayout.Size = new System.Drawing.Size(331, 105);
            this.LecturaLayout.TabIndex = 1;
            // 
            // IntentoText
            // 
            this.IntentoText.AutoSize = true;
            this.IntentoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntentoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.IntentoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.IntentoText.Location = new System.Drawing.Point(4, 52);
            this.IntentoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IntentoText.Name = "IntentoText";
            this.IntentoText.Size = new System.Drawing.Size(323, 53);
            this.IntentoText.TabIndex = 2;
            this.IntentoText.Text = "0";
            this.IntentoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lecturalbl
            // 
            this.Lecturalbl.AutoSize = true;
            this.Lecturalbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.Lecturalbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lecturalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Lecturalbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(116)))), ((int)(((byte)(145)))));
            this.Lecturalbl.Location = new System.Drawing.Point(4, 0);
            this.Lecturalbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lecturalbl.Name = "Lecturalbl";
            this.Lecturalbl.Size = new System.Drawing.Size(323, 52);
            this.Lecturalbl.TabIndex = 1;
            this.Lecturalbl.Text = "Lectura";
            this.Lecturalbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoraFechaLayout
            // 
            this.HoraFechaLayout.ColumnCount = 2;
            this.HoraFechaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HoraFechaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HoraFechaLayout.Controls.Add(this.HoraInfo, 0, 0);
            this.HoraFechaLayout.Controls.Add(this.FechaInfo, 0, 0);
            this.HoraFechaLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoraFechaLayout.Location = new System.Drawing.Point(436, 434);
            this.HoraFechaLayout.Margin = new System.Windows.Forms.Padding(4);
            this.HoraFechaLayout.Name = "HoraFechaLayout";
            this.HoraFechaLayout.RowCount = 1;
            this.HoraFechaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HoraFechaLayout.Size = new System.Drawing.Size(632, 55);
            this.HoraFechaLayout.TabIndex = 2;
            // 
            // HoraInfo
            // 
            this.HoraInfo.AutoSize = true;
            this.HoraInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoraInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.HoraInfo.Location = new System.Drawing.Point(320, 0);
            this.HoraInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HoraInfo.Name = "HoraInfo";
            this.HoraInfo.Size = new System.Drawing.Size(308, 55);
            this.HoraInfo.TabIndex = 4;
            this.HoraInfo.Text = "Hora";
            this.HoraInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FechaInfo
            // 
            this.FechaInfo.AutoSize = true;
            this.FechaInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FechaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.FechaInfo.Location = new System.Drawing.Point(4, 0);
            this.FechaInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaInfo.Name = "FechaInfo";
            this.FechaInfo.Size = new System.Drawing.Size(308, 55);
            this.FechaInfo.TabIndex = 3;
            this.FechaInfo.Text = "Fecha";
            this.FechaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BotonesLayout
            // 
            this.BotonesLayout.ColumnCount = 2;
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BotonesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BotonesLayout.Controls.Add(this.GuardarButton, 0, 0);
            this.BotonesLayout.Controls.Add(this.RepetirButton, 1, 0);
            this.BotonesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BotonesLayout.Location = new System.Drawing.Point(4, 434);
            this.BotonesLayout.Margin = new System.Windows.Forms.Padding(4);
            this.BotonesLayout.Name = "BotonesLayout";
            this.BotonesLayout.RowCount = 1;
            this.BotonesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BotonesLayout.Size = new System.Drawing.Size(424, 55);
            this.BotonesLayout.TabIndex = 3;
            // 
            // GuardarButton
            // 
            this.GuardarButton.ActiveBorderThickness = 1;
            this.GuardarButton.ActiveCornerRadius = 20;
            this.GuardarButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.GuardarButton.ActiveForecolor = System.Drawing.Color.White;
            this.GuardarButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.GuardarButton.BackColor = System.Drawing.Color.White;
            this.GuardarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GuardarButton.BackgroundImage")));
            this.GuardarButton.ButtonText = "Guardar";
            this.GuardarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GuardarButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.GuardarButton.IdleBorderThickness = 1;
            this.GuardarButton.IdleCornerRadius = 20;
            this.GuardarButton.IdleFillColor = System.Drawing.Color.White;
            this.GuardarButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.GuardarButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.GuardarButton.Location = new System.Drawing.Point(8, 7);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(196, 41);
            this.GuardarButton.TabIndex = 1;
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // RepetirButton
            // 
            this.RepetirButton.ActiveBorderThickness = 1;
            this.RepetirButton.ActiveCornerRadius = 20;
            this.RepetirButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.RepetirButton.ActiveForecolor = System.Drawing.Color.White;
            this.RepetirButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.RepetirButton.BackColor = System.Drawing.Color.White;
            this.RepetirButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RepetirButton.BackgroundImage")));
            this.RepetirButton.ButtonText = "Repetir";
            this.RepetirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RepetirButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RepetirButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepetirButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.RepetirButton.IdleBorderThickness = 1;
            this.RepetirButton.IdleCornerRadius = 20;
            this.RepetirButton.IdleFillColor = System.Drawing.Color.White;
            this.RepetirButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.RepetirButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.RepetirButton.Location = new System.Drawing.Point(220, 7);
            this.RepetirButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RepetirButton.Name = "RepetirButton";
            this.RepetirButton.Size = new System.Drawing.Size(196, 41);
            this.RepetirButton.TabIndex = 0;
            this.RepetirButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RepetirButton.Click += new System.EventHandler(this.RepetirClick);
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.TickEvent);
            // 
            // PuertoSerial
            // 
            this.PuertoSerial.DiscardNull = true;
            this.PuertoSerial.DtrEnable = true;
            this.PuertoSerial.RtsEnable = true;
            this.PuertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataRecibida);
            // 
            // RefractoIcon
            // 
            this.RefractoIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.RefractoIcon.BalloonTipText = "Aplicación que controla y monitorea el refracto.";
            this.RefractoIcon.BalloonTipTitle = "Refracto";
            this.RefractoIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("RefractoIcon.Icon")));
            this.RefractoIcon.Text = "Refracto";
            this.RefractoIcon.Visible = true;
            // 
            // Refracto_Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 670);
            this.Controls.Add(this.MainLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Refracto_Vista";
            this.Text = "Trabajador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closing_Event);
            this.Resize += new System.EventHandler(this.ResizeEvent);
            this.MainLayout.ResumeLayout(false);
            this.TopLayout.ResumeLayout(false);
            this.TopLayout.PerformLayout();
            this.MidLayout.ResumeLayout(false);
            this.FullLayout.ResumeLayout(false);
            this.GradoCard.ResumeLayout(false);
            this.GradoLayout.ResumeLayout(false);
            this.GradoLayout.PerformLayout();
            this.InfoLayout.ResumeLayout(false);
            this.TicketLayout.ResumeLayout(false);
            this.TicketLayout.PerformLayout();
            this.LecturaLayout.ResumeLayout(false);
            this.LecturaLayout.PerformLayout();
            this.HoraFechaLayout.ResumeLayout(false);
            this.HoraFechaLayout.PerformLayout();
            this.BotonesLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel TopLayout;
        private System.Windows.Forms.Label PlantaInfo;
        private System.Windows.Forms.Label RutCooperado;
        private System.Windows.Forms.Label NombrePlace;
        private System.Windows.Forms.TableLayoutPanel MidLayout;
        private Bunifu.Framework.UI.BunifuSeparator Separador;
        private System.Windows.Forms.TableLayoutPanel FullLayout;
        private Bunifu.Framework.UI.BunifuCards GradoCard;
        private System.Windows.Forms.TableLayoutPanel GradoLayout;
        private System.Windows.Forms.Label Gradolbl;
        private System.Windows.Forms.Label GradoText;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.TableLayoutPanel InfoLayout;
        private System.Windows.Forms.TableLayoutPanel HoraFechaLayout;
        private System.Windows.Forms.TableLayoutPanel TicketLayout;
        private System.Windows.Forms.Label Ticketlbl;
        private System.Windows.Forms.Label HoraInfo;
        private System.Windows.Forms.Label FechaInfo;
        private System.Windows.Forms.Label TicketText;
        private System.Windows.Forms.TableLayoutPanel LecturaLayout;
        private System.Windows.Forms.Label IntentoText;
        private System.Windows.Forms.Label Lecturalbl;
        private System.IO.Ports.SerialPort PuertoSerial;
        private System.Windows.Forms.TableLayoutPanel BotonesLayout;
        private Bunifu.Framework.UI.BunifuThinButton2 RepetirButton;
        private Bunifu.Framework.UI.BunifuThinButton2 GuardarButton;
        private System.Windows.Forms.NotifyIcon RefractoIcon;
    }
}

