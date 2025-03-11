namespace ParkirApp.view
{
    partial class Parkir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parkir));
            this.Panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.Side = new System.Windows.Forms.Panel();
            this.BtnOptions = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnLaporan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnDataParkir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnMasuk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnKeluar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.laporan1 = new ParkirApp.view.Laporan();
            this.options1 = new ParkirApp.view.Options();
            this.dataParkir1 = new ParkirApp.view.DataParkir();
            this.dataKeluar1 = new ParkirApp.view.DataKeluar();
            this.dataMasuk1 = new ParkirApp.view.DataMasuk();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            this.Side.SuspendLayout();
            this.SideMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.Panel3.Controls.Add(this.label1);
            this.Panel3.Controls.Add(this.BtnMinimize);
            this.Panel3.Controls.Add(this.BtnClose);
            this.Panel3.Controls.Add(this.BtnMenu);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(893, 43);
            this.Panel3.TabIndex = 1;
            this.Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            this.Panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseDown);
            this.Panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseMove);
            this.Panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aplikasi Parkir";
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.Image")));
            this.BtnMinimize.ImageActive = null;
            this.BtnMinimize.Location = new System.Drawing.Point(792, 3);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(48, 30);
            this.BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimize.TabIndex = 2;
            this.BtnMinimize.TabStop = false;
            this.BtnMinimize.Zoom = 10;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(846, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(35, 33);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 1;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageActive = null;
            this.BtnMenu.Location = new System.Drawing.Point(32, 11);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(22, 22);
            this.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMenu.TabIndex = 0;
            this.BtnMenu.TabStop = false;
            this.BtnMenu.Zoom = 10;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // PictureLogo
            // 
            this.PictureLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PictureLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureLogo.Image")));
            this.PictureLogo.Location = new System.Drawing.Point(0, 0);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(200, 130);
            this.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLogo.TabIndex = 0;
            this.PictureLogo.TabStop = false;
            // 
            // Side
            // 
            this.Side.Controls.Add(this.BtnOptions);
            this.Side.Controls.Add(this.BtnLaporan);
            this.Side.Controls.Add(this.BtnExit);
            this.Side.Controls.Add(this.BtnDataParkir);
            this.Side.Controls.Add(this.BtnMasuk);
            this.Side.Controls.Add(this.BtnKeluar);
            this.Side.Controls.Add(this.SideMenu);
            this.Side.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side.Location = new System.Drawing.Point(0, 43);
            this.Side.Name = "Side";
            this.Side.Size = new System.Drawing.Size(200, 559);
            this.Side.TabIndex = 2;
            // 
            // BtnOptions
            // 
            this.BtnOptions.Activecolor = System.Drawing.Color.Gainsboro;
            this.BtnOptions.BackColor = System.Drawing.Color.White;
            this.BtnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOptions.BorderRadius = 0;
            this.BtnOptions.ButtonText = "      Options";
            this.BtnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOptions.DisabledColor = System.Drawing.Color.Gray;
            this.BtnOptions.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnOptions.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnOptions.Iconimage")));
            this.BtnOptions.Iconimage_right = null;
            this.BtnOptions.Iconimage_right_Selected = null;
            this.BtnOptions.Iconimage_Selected = null;
            this.BtnOptions.IconMarginLeft = 30;
            this.BtnOptions.IconMarginRight = 0;
            this.BtnOptions.IconRightVisible = true;
            this.BtnOptions.IconRightZoom = 0D;
            this.BtnOptions.IconVisible = true;
            this.BtnOptions.IconZoom = 40D;
            this.BtnOptions.IsTab = true;
            this.BtnOptions.Location = new System.Drawing.Point(-3, 395);
            this.BtnOptions.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOptions.Name = "BtnOptions";
            this.BtnOptions.Normalcolor = System.Drawing.Color.White;
            this.BtnOptions.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnOptions.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnOptions.selected = false;
            this.BtnOptions.Size = new System.Drawing.Size(200, 49);
            this.BtnOptions.TabIndex = 36;
            this.BtnOptions.Text = "      Options";
            this.BtnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOptions.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnOptions.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnOptions.Click += new System.EventHandler(this.BtnOptions_Click_1);
            // 
            // BtnLaporan
            // 
            this.BtnLaporan.Activecolor = System.Drawing.Color.Gainsboro;
            this.BtnLaporan.BackColor = System.Drawing.Color.White;
            this.BtnLaporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLaporan.BorderRadius = 0;
            this.BtnLaporan.ButtonText = "      Laporan";
            this.BtnLaporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLaporan.DisabledColor = System.Drawing.Color.Gray;
            this.BtnLaporan.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnLaporan.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnLaporan.Iconimage")));
            this.BtnLaporan.Iconimage_right = null;
            this.BtnLaporan.Iconimage_right_Selected = null;
            this.BtnLaporan.Iconimage_Selected = null;
            this.BtnLaporan.IconMarginLeft = 30;
            this.BtnLaporan.IconMarginRight = 0;
            this.BtnLaporan.IconRightVisible = true;
            this.BtnLaporan.IconRightZoom = 0D;
            this.BtnLaporan.IconVisible = true;
            this.BtnLaporan.IconZoom = 40D;
            this.BtnLaporan.IsTab = true;
            this.BtnLaporan.Location = new System.Drawing.Point(-1, 340);
            this.BtnLaporan.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLaporan.Name = "BtnLaporan";
            this.BtnLaporan.Normalcolor = System.Drawing.Color.White;
            this.BtnLaporan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnLaporan.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnLaporan.selected = false;
            this.BtnLaporan.Size = new System.Drawing.Size(200, 49);
            this.BtnLaporan.TabIndex = 22;
            this.BtnLaporan.Text = "      Laporan";
            this.BtnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLaporan.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnLaporan.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnLaporan.Click += new System.EventHandler(this.BtnLaporan_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Activecolor = System.Drawing.Color.Gainsboro;
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.BorderRadius = 0;
            this.BtnExit.ButtonText = "      Exit";
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.DisabledColor = System.Drawing.Color.Gray;
            this.BtnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnExit.Iconimage")));
            this.BtnExit.Iconimage_right = null;
            this.BtnExit.Iconimage_right_Selected = null;
            this.BtnExit.Iconimage_Selected = null;
            this.BtnExit.IconMarginLeft = 30;
            this.BtnExit.IconMarginRight = 0;
            this.BtnExit.IconRightVisible = true;
            this.BtnExit.IconRightZoom = 0D;
            this.BtnExit.IconVisible = true;
            this.BtnExit.IconZoom = 40D;
            this.BtnExit.IsTab = true;
            this.BtnExit.Location = new System.Drawing.Point(1, 461);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Normalcolor = System.Drawing.Color.White;
            this.BtnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnExit.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnExit.selected = false;
            this.BtnExit.Size = new System.Drawing.Size(197, 52);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "      Exit";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnExit.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnDataParkir
            // 
            this.BtnDataParkir.Activecolor = System.Drawing.Color.Gainsboro;
            this.BtnDataParkir.BackColor = System.Drawing.Color.White;
            this.BtnDataParkir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDataParkir.BorderRadius = 0;
            this.BtnDataParkir.ButtonText = "      Data Parkir";
            this.BtnDataParkir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDataParkir.DisabledColor = System.Drawing.Color.Gray;
            this.BtnDataParkir.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnDataParkir.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnDataParkir.Iconimage")));
            this.BtnDataParkir.Iconimage_right = null;
            this.BtnDataParkir.Iconimage_right_Selected = null;
            this.BtnDataParkir.Iconimage_Selected = null;
            this.BtnDataParkir.IconMarginLeft = 30;
            this.BtnDataParkir.IconMarginRight = 0;
            this.BtnDataParkir.IconRightVisible = true;
            this.BtnDataParkir.IconRightZoom = 0D;
            this.BtnDataParkir.IconVisible = true;
            this.BtnDataParkir.IconZoom = 40D;
            this.BtnDataParkir.IsTab = true;
            this.BtnDataParkir.Location = new System.Drawing.Point(-1, 282);
            this.BtnDataParkir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDataParkir.Name = "BtnDataParkir";
            this.BtnDataParkir.Normalcolor = System.Drawing.Color.White;
            this.BtnDataParkir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnDataParkir.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnDataParkir.selected = false;
            this.BtnDataParkir.Size = new System.Drawing.Size(200, 52);
            this.BtnDataParkir.TabIndex = 1;
            this.BtnDataParkir.Text = "      Data Parkir";
            this.BtnDataParkir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDataParkir.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnDataParkir.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDataParkir.Click += new System.EventHandler(this.BtnDataParkir_Click);
            // 
            // BtnMasuk
            // 
            this.BtnMasuk.Activecolor = System.Drawing.Color.Gainsboro;
            this.BtnMasuk.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnMasuk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMasuk.BorderRadius = 0;
            this.BtnMasuk.ButtonText = "      Data Masuk";
            this.BtnMasuk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMasuk.DisabledColor = System.Drawing.Color.Gray;
            this.BtnMasuk.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnMasuk.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnMasuk.Iconimage")));
            this.BtnMasuk.Iconimage_right = null;
            this.BtnMasuk.Iconimage_right_Selected = null;
            this.BtnMasuk.Iconimage_Selected = null;
            this.BtnMasuk.IconMarginLeft = 30;
            this.BtnMasuk.IconMarginRight = 0;
            this.BtnMasuk.IconRightVisible = true;
            this.BtnMasuk.IconRightZoom = 0D;
            this.BtnMasuk.IconVisible = true;
            this.BtnMasuk.IconZoom = 40D;
            this.BtnMasuk.IsTab = true;
            this.BtnMasuk.Location = new System.Drawing.Point(1, 166);
            this.BtnMasuk.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMasuk.Name = "BtnMasuk";
            this.BtnMasuk.Normalcolor = System.Drawing.Color.White;
            this.BtnMasuk.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnMasuk.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnMasuk.selected = true;
            this.BtnMasuk.Size = new System.Drawing.Size(200, 52);
            this.BtnMasuk.TabIndex = 1;
            this.BtnMasuk.Text = "      Data Masuk";
            this.BtnMasuk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMasuk.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnMasuk.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnMasuk.Click += new System.EventHandler(this.BtnMasuk_Click);
            // 
            // BtnKeluar
            // 
            this.BtnKeluar.Activecolor = System.Drawing.Color.Gainsboro;
            this.BtnKeluar.BackColor = System.Drawing.Color.White;
            this.BtnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKeluar.BorderRadius = 0;
            this.BtnKeluar.ButtonText = "      Data Keluar";
            this.BtnKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKeluar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnKeluar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnKeluar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnKeluar.Iconimage")));
            this.BtnKeluar.Iconimage_right = null;
            this.BtnKeluar.Iconimage_right_Selected = null;
            this.BtnKeluar.Iconimage_Selected = null;
            this.BtnKeluar.IconMarginLeft = 30;
            this.BtnKeluar.IconMarginRight = 0;
            this.BtnKeluar.IconRightVisible = true;
            this.BtnKeluar.IconRightZoom = 0D;
            this.BtnKeluar.IconVisible = true;
            this.BtnKeluar.IconZoom = 40D;
            this.BtnKeluar.IsTab = true;
            this.BtnKeluar.Location = new System.Drawing.Point(-1, 224);
            this.BtnKeluar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKeluar.Name = "BtnKeluar";
            this.BtnKeluar.Normalcolor = System.Drawing.Color.White;
            this.BtnKeluar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnKeluar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnKeluar.selected = false;
            this.BtnKeluar.Size = new System.Drawing.Size(200, 52);
            this.BtnKeluar.TabIndex = 1;
            this.BtnKeluar.Text = "      Data Keluar";
            this.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKeluar.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnKeluar.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnKeluar.Click += new System.EventHandler(this.BtnKeluar_Click);
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.Black;
            this.SideMenu.Controls.Add(this.PictureLogo);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(200, 130);
            this.SideMenu.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataMasuk1);
            this.panel4.Controls.Add(this.dataKeluar1);
            this.panel4.Controls.Add(this.dataParkir1);
            this.panel4.Controls.Add(this.laporan1);
            this.panel4.Controls.Add(this.options1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(693, 559);
            this.panel4.TabIndex = 3;
            // 
            // laporan1
            // 
            this.laporan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laporan1.Location = new System.Drawing.Point(0, 0);
            this.laporan1.Name = "laporan1";
            this.laporan1.Size = new System.Drawing.Size(693, 559);
            this.laporan1.TabIndex = 1;
            // 
            // options1
            // 
            this.options1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.options1.Location = new System.Drawing.Point(0, 0);
            this.options1.Name = "options1";
            this.options1.Size = new System.Drawing.Size(693, 559);
            this.options1.TabIndex = 0;
            // 
            // dataParkir1
            // 
            this.dataParkir1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataParkir1.Location = new System.Drawing.Point(0, 0);
            this.dataParkir1.Name = "dataParkir1";
            this.dataParkir1.Size = new System.Drawing.Size(693, 559);
            this.dataParkir1.TabIndex = 2;
            // 
            // dataKeluar1
            // 
            this.dataKeluar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataKeluar1.Location = new System.Drawing.Point(0, 0);
            this.dataKeluar1.Name = "dataKeluar1";
            this.dataKeluar1.Size = new System.Drawing.Size(693, 559);
            this.dataKeluar1.TabIndex = 3;
            // 
            // dataMasuk1
            // 
            this.dataMasuk1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMasuk1.Location = new System.Drawing.Point(0, 0);
            this.dataMasuk1.Name = "dataMasuk1";
            this.dataMasuk1.Size = new System.Drawing.Size(693, 559);
            this.dataMasuk1.TabIndex = 4;
            // 
            // Parkir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 602);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Side);
            this.Controls.Add(this.Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Parkir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Parkir";
            this.Load += new System.EventHandler(this.Parkir_Load);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            this.Side.ResumeLayout(false);
            this.SideMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.Panel Side;
        private System.Windows.Forms.Panel SideMenu;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnDataParkir;
        private Bunifu.Framework.UI.BunifuFlatButton BtnMasuk;
        private Bunifu.Framework.UI.BunifuFlatButton BtnKeluar;
        private Bunifu.Framework.UI.BunifuImageButton BtnMenu;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private Bunifu.Framework.UI.BunifuImageButton BtnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton BtnExit;
        private Bunifu.Framework.UI.BunifuFlatButton BtnLaporan;
        private Bunifu.Framework.UI.BunifuFlatButton BtnOptions;
        private Options options1;
        private Laporan laporan1;
        private DataParkir dataParkir1;
        private DataKeluar dataKeluar1;
        private DataMasuk dataMasuk1;
    }
}