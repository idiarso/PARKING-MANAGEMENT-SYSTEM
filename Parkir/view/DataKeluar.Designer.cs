namespace ParkirApp.view
{
    partial class DataKeluar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxNoMasuk = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextboxNoKendaraan = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BtnCari = new Bunifu.Framework.UI.BunifuFlatButton();
            this.barcode = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(30, 332);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(641, 225);
            this.DataGridView1.TabIndex = 2;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Panel1.Controls.Add(this.LblTime);
            this.Panel1.Controls.Add(this.LblDate);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(693, 130);
            this.Panel1.TabIndex = 17;
            // 
            // LblTime
            // 
            this.LblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTime.AutoSize = true;
            this.LblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LblTime.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.LblTime.Location = new System.Drawing.Point(442, 12);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(147, 79);
            this.LblTime.TabIndex = 10;
            this.LblTime.Text = "Time";
            // 
            // LblDate
            // 
            this.LblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.LblDate.Location = new System.Drawing.Point(503, 91);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(59, 28);
            this.LblDate.TabIndex = 9;
            this.LblDate.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(23, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data Keluar Kendaraan";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cari No Masuk";
            // 
            // TextboxNoMasuk
            // 
            this.TextboxNoMasuk.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TextboxNoMasuk.BorderColorIdle = System.Drawing.Color.Gray;
            this.TextboxNoMasuk.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TextboxNoMasuk.BorderThickness = 3;
            this.TextboxNoMasuk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxNoMasuk.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxNoMasuk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxNoMasuk.isPassword = false;
            this.TextboxNoMasuk.Location = new System.Drawing.Point(29, 166);
            this.TextboxNoMasuk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextboxNoMasuk.Name = "TextboxNoMasuk";
            this.TextboxNoMasuk.Size = new System.Drawing.Size(227, 40);
            this.TextboxNoMasuk.TabIndex = 21;
            this.TextboxNoMasuk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxNoMasuk.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nosuk);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ketikan No.kendaraan";
            // 
            // TextboxNoKendaraan
            // 
            this.TextboxNoKendaraan.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TextboxNoKendaraan.BorderColorIdle = System.Drawing.Color.Gray;
            this.TextboxNoKendaraan.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TextboxNoKendaraan.BorderThickness = 3;
            this.TextboxNoKendaraan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxNoKendaraan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxNoKendaraan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxNoKendaraan.isPassword = false;
            this.TextboxNoKendaraan.Location = new System.Drawing.Point(29, 257);
            this.TextboxNoKendaraan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextboxNoKendaraan.Name = "TextboxNoKendaraan";
            this.TextboxNoKendaraan.Size = new System.Drawing.Size(227, 40);
            this.TextboxNoKendaraan.TabIndex = 23;
            this.TextboxNoKendaraan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxNoKendaraan.OnValueChanged += new System.EventHandler(this.noken2);
            // 
            // BtnCari
            // 
            this.BtnCari.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCari.BorderRadius = 0;
            this.BtnCari.ButtonText = "Cari";
            this.BtnCari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCari.DisabledColor = System.Drawing.Color.Gray;
            this.BtnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCari.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCari.Iconimage = null;
            this.BtnCari.Iconimage_right = null;
            this.BtnCari.Iconimage_right_Selected = null;
            this.BtnCari.Iconimage_Selected = null;
            this.BtnCari.IconMarginLeft = 0;
            this.BtnCari.IconMarginRight = 0;
            this.BtnCari.IconRightVisible = true;
            this.BtnCari.IconRightZoom = 0D;
            this.BtnCari.IconVisible = true;
            this.BtnCari.IconZoom = 90D;
            this.BtnCari.IsTab = false;
            this.BtnCari.Location = new System.Drawing.Point(294, 246);
            this.BtnCari.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnCari.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnCari.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnCari.selected = false;
            this.BtnCari.Size = new System.Drawing.Size(283, 50);
            this.BtnCari.TabIndex = 24;
            this.BtnCari.Text = "Cari";
            this.BtnCari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCari.Textcolor = System.Drawing.Color.White;
            this.BtnCari.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // barcode
            // 
            this.barcode.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.barcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.barcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.barcode.BorderRadius = 0;
            this.barcode.ButtonText = "Barcode";
            this.barcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barcode.DisabledColor = System.Drawing.Color.Gray;
            this.barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode.Iconcolor = System.Drawing.Color.Transparent;
            this.barcode.Iconimage = null;
            this.barcode.Iconimage_right = null;
            this.barcode.Iconimage_right_Selected = null;
            this.barcode.Iconimage_Selected = null;
            this.barcode.IconMarginLeft = 0;
            this.barcode.IconMarginRight = 0;
            this.barcode.IconRightVisible = true;
            this.barcode.IconRightZoom = 0D;
            this.barcode.IconVisible = true;
            this.barcode.IconZoom = 90D;
            this.barcode.IsTab = false;
            this.barcode.Location = new System.Drawing.Point(296, 155);
            this.barcode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barcode.Name = "barcode";
            this.barcode.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.barcode.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.barcode.OnHoverTextColor = System.Drawing.Color.White;
            this.barcode.selected = false;
            this.barcode.Size = new System.Drawing.Size(283, 50);
            this.barcode.TabIndex = 25;
            this.barcode.Text = "Barcode";
            this.barcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.barcode.Textcolor = System.Drawing.Color.White;
            this.barcode.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode.Click += new System.EventHandler(this.barcode_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 307);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 26;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.BtnCari);
            this.Controls.Add(this.TextboxNoKendaraan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextboxNoMasuk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.DataGridView1);
            this.Name = "DataKeluar";
            this.Size = new System.Drawing.Size(693, 559);
            this.Load += new System.EventHandler(this.DataKeluar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxNoMasuk;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxNoKendaraan;
        private Bunifu.Framework.UI.BunifuFlatButton BtnCari;
        private Bunifu.Framework.UI.BunifuFlatButton barcode;
        private System.Windows.Forms.Button button1;
    }
}
