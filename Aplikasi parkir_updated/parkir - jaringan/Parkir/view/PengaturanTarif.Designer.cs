namespace ParkirApp.view
{
    partial class PengaturanTarif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PengaturanTarif));
            this.LblID = new System.Windows.Forms.Label();
            this.BtnUbah = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnHapus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnTutup = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSimpan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtTarif = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtJeniskendaraan = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.biayaParkirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBaru = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biayaParkirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(24, 97);
            this.LblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(19, 17);
            this.LblID.TabIndex = 33;
            this.LblID.Text = "Id";
            // 
            // BtnUbah
            // 
            this.BtnUbah.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUbah.BorderRadius = 0;
            this.BtnUbah.ButtonText = "Ubah";
            this.BtnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUbah.DisabledColor = System.Drawing.Color.Gray;
            this.BtnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUbah.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnUbah.Iconimage = null;
            this.BtnUbah.Iconimage_right = null;
            this.BtnUbah.Iconimage_right_Selected = null;
            this.BtnUbah.Iconimage_Selected = null;
            this.BtnUbah.IconMarginLeft = 0;
            this.BtnUbah.IconMarginRight = 0;
            this.BtnUbah.IconRightVisible = true;
            this.BtnUbah.IconRightZoom = 0D;
            this.BtnUbah.IconVisible = true;
            this.BtnUbah.IconZoom = 90D;
            this.BtnUbah.IsTab = false;
            this.BtnUbah.Location = new System.Drawing.Point(596, 618);
            this.BtnUbah.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnUbah.Name = "BtnUbah";
            this.BtnUbah.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnUbah.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnUbah.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnUbah.selected = false;
            this.BtnUbah.Size = new System.Drawing.Size(145, 53);
            this.BtnUbah.TabIndex = 32;
            this.BtnUbah.Text = "Ubah";
            this.BtnUbah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnUbah.Textcolor = System.Drawing.Color.White;
            this.BtnUbah.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUbah.Click += new System.EventHandler(this.BtnUbah_Click);
            // 
            // BtnHapus
            // 
            this.BtnHapus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHapus.BorderRadius = 0;
            this.BtnHapus.ButtonText = "Hapus";
            this.BtnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHapus.DisabledColor = System.Drawing.Color.Gray;
            this.BtnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHapus.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnHapus.Iconimage = null;
            this.BtnHapus.Iconimage_right = null;
            this.BtnHapus.Iconimage_right_Selected = null;
            this.BtnHapus.Iconimage_Selected = null;
            this.BtnHapus.IconMarginLeft = 0;
            this.BtnHapus.IconMarginRight = 0;
            this.BtnHapus.IconRightVisible = true;
            this.BtnHapus.IconRightZoom = 0D;
            this.BtnHapus.IconVisible = true;
            this.BtnHapus.IconZoom = 90D;
            this.BtnHapus.IsTab = false;
            this.BtnHapus.Location = new System.Drawing.Point(439, 618);
            this.BtnHapus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnHapus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnHapus.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnHapus.selected = false;
            this.BtnHapus.Size = new System.Drawing.Size(147, 53);
            this.BtnHapus.TabIndex = 31;
            this.BtnHapus.Text = "Hapus";
            this.BtnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnHapus.Textcolor = System.Drawing.Color.White;
            this.BtnHapus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnTutup
            // 
            this.BtnTutup.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnTutup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnTutup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTutup.BorderRadius = 0;
            this.BtnTutup.ButtonText = "Tutup";
            this.BtnTutup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTutup.DisabledColor = System.Drawing.Color.Gray;
            this.BtnTutup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTutup.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnTutup.Iconimage = null;
            this.BtnTutup.Iconimage_right = null;
            this.BtnTutup.Iconimage_right_Selected = null;
            this.BtnTutup.Iconimage_Selected = null;
            this.BtnTutup.IconMarginLeft = 0;
            this.BtnTutup.IconMarginRight = 0;
            this.BtnTutup.IconRightVisible = true;
            this.BtnTutup.IconRightZoom = 0D;
            this.BtnTutup.IconVisible = true;
            this.BtnTutup.IconZoom = 90D;
            this.BtnTutup.IsTab = false;
            this.BtnTutup.Location = new System.Drawing.Point(753, 618);
            this.BtnTutup.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnTutup.Name = "BtnTutup";
            this.BtnTutup.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnTutup.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnTutup.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnTutup.selected = false;
            this.BtnTutup.Size = new System.Drawing.Size(147, 49);
            this.BtnTutup.TabIndex = 30;
            this.BtnTutup.Text = "Tutup";
            this.BtnTutup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnTutup.Textcolor = System.Drawing.Color.White;
            this.BtnTutup.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTutup.Click += new System.EventHandler(this.BtnTutup_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.tarifDataGridViewTextBoxColumn});
            this.DataGridView1.Location = new System.Drawing.Point(28, 274);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(887, 336);
            this.DataGridView1.TabIndex = 29;
            this.DataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            this.DataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_kendaraan";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "jenis_kendaraan";
            this.dataGridViewTextBoxColumn2.HeaderText = "Jenis Kendaraan";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tarifDataGridViewTextBoxColumn
            // 
            this.tarifDataGridViewTextBoxColumn.DataPropertyName = "Tarif";
            this.tarifDataGridViewTextBoxColumn.HeaderText = "Tarif";
            this.tarifDataGridViewTextBoxColumn.Name = "tarifDataGridViewTextBoxColumn";
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSimpan.BorderRadius = 0;
            this.BtnSimpan.ButtonText = "SIMPAN";
            this.BtnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSimpan.DisabledColor = System.Drawing.Color.Gray;
            this.BtnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimpan.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnSimpan.Iconimage = null;
            this.BtnSimpan.Iconimage_right = null;
            this.BtnSimpan.Iconimage_right_Selected = null;
            this.BtnSimpan.Iconimage_Selected = null;
            this.BtnSimpan.IconMarginLeft = 0;
            this.BtnSimpan.IconMarginRight = 0;
            this.BtnSimpan.IconRightVisible = true;
            this.BtnSimpan.IconRightZoom = 0D;
            this.BtnSimpan.IconVisible = true;
            this.BtnSimpan.IconZoom = 90D;
            this.BtnSimpan.IsTab = false;
            this.BtnSimpan.Location = new System.Drawing.Point(568, 201);
            this.BtnSimpan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSimpan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnSimpan.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSimpan.selected = false;
            this.BtnSimpan.Size = new System.Drawing.Size(173, 49);
            this.BtnSimpan.TabIndex = 28;
            this.BtnSimpan.Text = "SIMPAN";
            this.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSimpan.Textcolor = System.Drawing.Color.White;
            this.BtnSimpan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // TxtTarif
            // 
            this.TxtTarif.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TxtTarif.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtTarif.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TxtTarif.BorderThickness = 3;
            this.TxtTarif.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTarif.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtTarif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtTarif.isPassword = false;
            this.TxtTarif.Location = new System.Drawing.Point(233, 201);
            this.TxtTarif.Margin = new System.Windows.Forms.Padding(5);
            this.TxtTarif.Name = "TxtTarif";
            this.TxtTarif.Size = new System.Drawing.Size(303, 49);
            this.TxtTarif.TabIndex = 27;
            this.TxtTarif.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtJeniskendaraan
            // 
            this.TxtJeniskendaraan.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TxtJeniskendaraan.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtJeniskendaraan.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TxtJeniskendaraan.BorderThickness = 3;
            this.TxtJeniskendaraan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtJeniskendaraan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtJeniskendaraan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtJeniskendaraan.isPassword = false;
            this.TxtJeniskendaraan.Location = new System.Drawing.Point(233, 127);
            this.TxtJeniskendaraan.Margin = new System.Windows.Forms.Padding(5);
            this.TxtJeniskendaraan.Name = "TxtJeniskendaraan";
            this.TxtJeniskendaraan.Size = new System.Drawing.Size(303, 49);
            this.TxtJeniskendaraan.TabIndex = 26;
            this.TxtJeniskendaraan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tarif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Jenis Kendaraan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pengaturan Tarif Parkir";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.Panel1.Controls.Add(this.BtnClose);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(939, 39);
            this.Panel1.TabIndex = 34;
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(888, 4);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(47, 41);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // biayaParkirBindingSource
            // 
            this.biayaParkirBindingSource.DataSource = typeof(ParkirApp.model.BiayaParkir);
            // 
            // btnBaru
            // 
            this.btnBaru.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBaru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBaru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaru.BorderRadius = 0;
            this.btnBaru.ButtonText = "BARU";
            this.btnBaru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaru.DisabledColor = System.Drawing.Color.Gray;
            this.btnBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaru.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBaru.Iconimage = null;
            this.btnBaru.Iconimage_right = null;
            this.btnBaru.Iconimage_right_Selected = null;
            this.btnBaru.Iconimage_Selected = null;
            this.btnBaru.IconMarginLeft = 0;
            this.btnBaru.IconMarginRight = 0;
            this.btnBaru.IconRightVisible = true;
            this.btnBaru.IconRightZoom = 0D;
            this.btnBaru.IconVisible = true;
            this.btnBaru.IconZoom = 90D;
            this.btnBaru.IsTab = false;
            this.btnBaru.Location = new System.Drawing.Point(568, 127);
            this.btnBaru.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBaru.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBaru.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBaru.selected = false;
            this.btnBaru.Size = new System.Drawing.Size(173, 49);
            this.btnBaru.TabIndex = 35;
            this.btnBaru.Text = "BARU";
            this.btnBaru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBaru.Textcolor = System.Drawing.Color.White;
            this.btnBaru.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
            // 
            // PengaturanTarif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 702);
            this.Controls.Add(this.btnBaru);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.BtnUbah);
            this.Controls.Add(this.BtnHapus);
            this.Controls.Add(this.BtnTutup);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.TxtTarif);
            this.Controls.Add(this.TxtJeniskendaraan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PengaturanTarif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PengaturanTarif";
            this.Load += new System.EventHandler(this.PengaturanTarif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biayaParkirBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblID;
        private Bunifu.Framework.UI.BunifuFlatButton BtnUbah;
        private Bunifu.Framework.UI.BunifuFlatButton BtnHapus;
        private Bunifu.Framework.UI.BunifuFlatButton BtnTutup;
        private System.Windows.Forms.DataGridView DataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSimpan;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtTarif;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtJeniskendaraan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Panel1;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKendaraanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKendaraanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource biayaParkirBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton btnBaru;
    }
}