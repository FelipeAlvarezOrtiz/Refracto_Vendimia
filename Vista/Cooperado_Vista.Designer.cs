namespace Refracto_Vendimia.Vista
{
    partial class Cooperado_Vista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cooperado_Vista));
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TopLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PlantaInfo = new System.Windows.Forms.Label();
            this.NombreCooperado = new System.Windows.Forms.Label();
            this.RutInfo = new System.Windows.Forms.Label();
            this.MidLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Separador = new Bunifu.Framework.UI.BunifuSeparator();
            this.UserLayout = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.GradoText = new System.Windows.Forms.Label();
            this.InfoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TicketLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TicketText = new System.Windows.Forms.Label();
            this.Ticketlbl = new System.Windows.Forms.Label();
            this.LecturaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.IntentoText = new System.Windows.Forms.Label();
            this.Lecturalbl = new System.Windows.Forms.Label();
            this.HoraTimeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FechaInfo = new System.Windows.Forms.Label();
            this.HoraInfo = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.MainLayout.SuspendLayout();
            this.TopLayout.SuspendLayout();
            this.MidLayout.SuspendLayout();
            this.UserLayout.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.InfoLayout.SuspendLayout();
            this.TicketLayout.SuspendLayout();
            this.LecturaLayout.SuspendLayout();
            this.HoraTimeLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.Controls.Add(this.TopLayout, 0, 0);
            this.MainLayout.Controls.Add(this.MidLayout, 0, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Margin = new System.Windows.Forms.Padding(4);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.MainLayout.Size = new System.Drawing.Size(1011, 748);
            this.MainLayout.TabIndex = 0;
            // 
            // TopLayout
            // 
            this.TopLayout.ColumnCount = 2;
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.Controls.Add(this.PlantaInfo, 0, 0);
            this.TopLayout.Controls.Add(this.NombreCooperado, 0, 1);
            this.TopLayout.Controls.Add(this.RutInfo, 1, 0);
            this.TopLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopLayout.Location = new System.Drawing.Point(4, 4);
            this.TopLayout.Margin = new System.Windows.Forms.Padding(4);
            this.TopLayout.Name = "TopLayout";
            this.TopLayout.RowCount = 2;
            this.TopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.Size = new System.Drawing.Size(1003, 141);
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
            this.PlantaInfo.Size = new System.Drawing.Size(493, 70);
            this.PlantaInfo.TabIndex = 0;
            this.PlantaInfo.Text = "Planta PlaceHolder";
            this.PlantaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NombreCooperado
            // 
            this.NombreCooperado.AutoSize = true;
            this.NombreCooperado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NombreCooperado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCooperado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.NombreCooperado.Location = new System.Drawing.Point(4, 70);
            this.NombreCooperado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombreCooperado.Name = "NombreCooperado";
            this.NombreCooperado.Size = new System.Drawing.Size(493, 71);
            this.NombreCooperado.TabIndex = 1;
            this.NombreCooperado.Text = "Nombre Cooperado";
            this.NombreCooperado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RutInfo
            // 
            this.RutInfo.AutoSize = true;
            this.RutInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RutInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RutInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.RutInfo.Location = new System.Drawing.Point(505, 0);
            this.RutInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RutInfo.Name = "RutInfo";
            this.RutInfo.Size = new System.Drawing.Size(494, 70);
            this.RutInfo.TabIndex = 2;
            this.RutInfo.Text = "Rut Cooperado";
            this.RutInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MidLayout
            // 
            this.MidLayout.ColumnCount = 1;
            this.MidLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MidLayout.Controls.Add(this.Separador, 0, 0);
            this.MidLayout.Controls.Add(this.UserLayout, 0, 1);
            this.MidLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MidLayout.Location = new System.Drawing.Point(4, 153);
            this.MidLayout.Margin = new System.Windows.Forms.Padding(4);
            this.MidLayout.Name = "MidLayout";
            this.MidLayout.RowCount = 2;
            this.MidLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.MidLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97F));
            this.MidLayout.Size = new System.Drawing.Size(1003, 567);
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
            this.Separador.Size = new System.Drawing.Size(993, 7);
            this.Separador.TabIndex = 0;
            this.Separador.Transparency = 255;
            this.Separador.Vertical = false;
            // 
            // UserLayout
            // 
            this.UserLayout.ColumnCount = 3;
            this.UserLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.37802F));
            this.UserLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.47721F));
            this.UserLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.144772F));
            this.UserLayout.Controls.Add(this.bunifuCards1, 1, 0);
            this.UserLayout.Controls.Add(this.InfoLayout, 0, 0);
            this.UserLayout.Controls.Add(this.HoraTimeLayout, 1, 1);
            this.UserLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserLayout.Location = new System.Drawing.Point(4, 21);
            this.UserLayout.Margin = new System.Windows.Forms.Padding(4);
            this.UserLayout.Name = "UserLayout";
            this.UserLayout.RowCount = 2;
            this.UserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.26185F));
            this.UserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.73815F));
            this.UserLayout.Size = new System.Drawing.Size(995, 542);
            this.UserLayout.TabIndex = 1;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.bunifuCards1.Controls.Add(this.tableLayoutPanel1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(336, 4);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(633, 470);
            this.bunifuCards1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GradoText, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(633, 470);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GradoText
            // 
            this.GradoText.AutoSize = true;
            this.GradoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GradoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 199.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.GradoText.Location = new System.Drawing.Point(4, 70);
            this.GradoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GradoText.Name = "GradoText";
            this.GradoText.Size = new System.Drawing.Size(625, 400);
            this.GradoText.TabIndex = 1;
            this.GradoText.Text = "00.0";
            this.GradoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoLayout
            // 
            this.InfoLayout.ColumnCount = 1;
            this.InfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InfoLayout.Controls.Add(this.TicketLayout, 0, 1);
            this.InfoLayout.Controls.Add(this.LecturaLayout, 0, 3);
            this.InfoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoLayout.Location = new System.Drawing.Point(4, 4);
            this.InfoLayout.Margin = new System.Windows.Forms.Padding(4);
            this.InfoLayout.Name = "InfoLayout";
            this.InfoLayout.RowCount = 5;
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.InfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.InfoLayout.Size = new System.Drawing.Size(324, 470);
            this.InfoLayout.TabIndex = 1;
            // 
            // TicketLayout
            // 
            this.TicketLayout.ColumnCount = 1;
            this.TicketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TicketLayout.Controls.Add(this.TicketText, 0, 1);
            this.TicketLayout.Controls.Add(this.Ticketlbl, 0, 0);
            this.TicketLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketLayout.Location = new System.Drawing.Point(4, 51);
            this.TicketLayout.Margin = new System.Windows.Forms.Padding(4);
            this.TicketLayout.Name = "TicketLayout";
            this.TicketLayout.RowCount = 2;
            this.TicketLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.21875F));
            this.TicketLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.78125F));
            this.TicketLayout.Size = new System.Drawing.Size(316, 156);
            this.TicketLayout.TabIndex = 0;
            // 
            // TicketText
            // 
            this.TicketText.AutoSize = true;
            this.TicketText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.TicketText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.TicketText.Location = new System.Drawing.Point(4, 76);
            this.TicketText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TicketText.Name = "TicketText";
            this.TicketText.Size = new System.Drawing.Size(308, 80);
            this.TicketText.TabIndex = 2;
            this.TicketText.Text = "0";
            this.TicketText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Ticketlbl.Size = new System.Drawing.Size(308, 76);
            this.Ticketlbl.TabIndex = 1;
            this.Ticketlbl.Text = "Ticket";
            this.Ticketlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LecturaLayout
            // 
            this.LecturaLayout.ColumnCount = 1;
            this.LecturaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LecturaLayout.Controls.Add(this.IntentoText, 0, 1);
            this.LecturaLayout.Controls.Add(this.Lecturalbl, 0, 0);
            this.LecturaLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LecturaLayout.Location = new System.Drawing.Point(4, 262);
            this.LecturaLayout.Margin = new System.Windows.Forms.Padding(4);
            this.LecturaLayout.Name = "LecturaLayout";
            this.LecturaLayout.RowCount = 2;
            this.LecturaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LecturaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LecturaLayout.Size = new System.Drawing.Size(316, 156);
            this.LecturaLayout.TabIndex = 1;
            // 
            // IntentoText
            // 
            this.IntentoText.AutoSize = true;
            this.IntentoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntentoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.IntentoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(14)))), ((int)(((byte)(18)))));
            this.IntentoText.Location = new System.Drawing.Point(4, 78);
            this.IntentoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IntentoText.Name = "IntentoText";
            this.IntentoText.Size = new System.Drawing.Size(308, 78);
            this.IntentoText.TabIndex = 3;
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
            this.Lecturalbl.Size = new System.Drawing.Size(308, 78);
            this.Lecturalbl.TabIndex = 2;
            this.Lecturalbl.Text = "Lectura";
            this.Lecturalbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoraTimeLayout
            // 
            this.HoraTimeLayout.ColumnCount = 2;
            this.HoraTimeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HoraTimeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HoraTimeLayout.Controls.Add(this.FechaInfo, 1, 0);
            this.HoraTimeLayout.Controls.Add(this.HoraInfo, 0, 0);
            this.HoraTimeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoraTimeLayout.Location = new System.Drawing.Point(336, 482);
            this.HoraTimeLayout.Margin = new System.Windows.Forms.Padding(4);
            this.HoraTimeLayout.Name = "HoraTimeLayout";
            this.HoraTimeLayout.RowCount = 1;
            this.HoraTimeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HoraTimeLayout.Size = new System.Drawing.Size(633, 56);
            this.HoraTimeLayout.TabIndex = 2;
            // 
            // FechaInfo
            // 
            this.FechaInfo.AutoSize = true;
            this.FechaInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FechaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.FechaInfo.Location = new System.Drawing.Point(320, 0);
            this.FechaInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaInfo.Name = "FechaInfo";
            this.FechaInfo.Size = new System.Drawing.Size(309, 56);
            this.FechaInfo.TabIndex = 1;
            this.FechaInfo.Text = "Fecha";
            this.FechaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoraInfo
            // 
            this.HoraInfo.AutoSize = true;
            this.HoraInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoraInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(33)))), ((int)(((byte)(7)))));
            this.HoraInfo.Location = new System.Drawing.Point(4, 0);
            this.HoraInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HoraInfo.Name = "HoraInfo";
            this.HoraInfo.Size = new System.Drawing.Size(308, 56);
            this.HoraInfo.TabIndex = 0;
            this.HoraInfo.Text = "Hora";
            this.HoraInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.TickerEvent);
            // 
            // Cooperado_Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 748);
            this.Controls.Add(this.MainLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cooperado_Vista";
            this.Text = "Cooperado_Vista";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.MainLayout.ResumeLayout(false);
            this.TopLayout.ResumeLayout(false);
            this.TopLayout.PerformLayout();
            this.MidLayout.ResumeLayout(false);
            this.UserLayout.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.InfoLayout.ResumeLayout(false);
            this.TicketLayout.ResumeLayout(false);
            this.TicketLayout.PerformLayout();
            this.LecturaLayout.ResumeLayout(false);
            this.LecturaLayout.PerformLayout();
            this.HoraTimeLayout.ResumeLayout(false);
            this.HoraTimeLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel TopLayout;
        private System.Windows.Forms.TableLayoutPanel MidLayout;
        private Bunifu.Framework.UI.BunifuSeparator Separador;
        private System.Windows.Forms.TableLayoutPanel UserLayout;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.TableLayoutPanel InfoLayout;
        private System.Windows.Forms.TableLayoutPanel TicketLayout;
        private System.Windows.Forms.Label Ticketlbl;
        private System.Windows.Forms.TableLayoutPanel LecturaLayout;
        private System.Windows.Forms.Label Lecturalbl;
        private System.Windows.Forms.TableLayoutPanel HoraTimeLayout;
        private System.Windows.Forms.Label FechaInfo;
        private System.Windows.Forms.Label HoraInfo;
        public System.Windows.Forms.Label GradoText;
        public System.Windows.Forms.Label PlantaInfo;
        public System.Windows.Forms.Label TicketText;
        public System.Windows.Forms.Label IntentoText;
        public System.Windows.Forms.Label NombreCooperado;
        public System.Windows.Forms.Label RutInfo;
    }
}