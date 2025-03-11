namespace ParkirApp.view
{
    partial class DataMasuk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataMasuk));
            this.LblTime = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ComboxJenisKendaraan = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TextboxNo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnSimpan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTime
            // 
            this.LblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTime.AutoSize = true;
            this.LblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LblTime.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.LblTime.Location = new System.Drawing.Point(589, 15);
            this.LblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(182, 97);
            this.LblTime.TabIndex = 10;
            this.LblTime.Text = "Time";
            // 
            // LblDate
            // 
            this.LblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.LblDate.Location = new System.Drawing.Point(671, 112);
            this.LblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(75, 37);
            this.LblDate.TabIndex = 9;
            this.LblDate.Text = "Date";
            this.LblDate.Click += new System.EventHandler(this.LblDate_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data Masuk Kendaraan";
            // 
            // ComboxJenisKendaraan
            // 
            this.ComboxJenisKendaraan.FormattingEnabled = true;
            this.ComboxJenisKendaraan.Location = new System.Drawing.Point(320, 274);
            this.ComboxJenisKendaraan.Margin = new System.Windows.Forms.Padding(4);
            this.ComboxJenisKendaraan.Name = "ComboxJenisKendaraan";
            this.ComboxJenisKendaraan.Size = new System.Drawing.Size(295, 24);
            this.ComboxJenisKendaraan.TabIndex = 12;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(333, 228);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(249, 29);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "JENIS KENDARAAN";
            // 
            // TextboxNo
            // 
            this.TextboxNo.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TextboxNo.BorderColorIdle = System.Drawing.Color.Gray;
            this.TextboxNo.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TextboxNo.BorderThickness = 3;
            this.TextboxNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxNo.isPassword = false;
            this.TextboxNo.Location = new System.Drawing.Point(320, 401);
            this.TextboxNo.Margin = new System.Windows.Forms.Padding(5);
            this.TextboxNo.Name = "TextboxNo";
            this.TextboxNo.Size = new System.Drawing.Size(303, 49);
            this.TextboxNo.TabIndex = 14;
            this.TextboxNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.noken);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(356, 353);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(215, 29);
            this.bunifuCustomLabel2.TabIndex = 13;
            this.bunifuCustomLabel2.Text = "NO.KENDARAAN";
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
            this.BtnSimpan.Location = new System.Drawing.Point(288, 523);
            this.BtnSimpan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSimpan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnSimpan.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSimpan.selected = false;
            this.BtnSimpan.Size = new System.Drawing.Size(377, 62);
            this.BtnSimpan.TabIndex = 15;
            this.BtnSimpan.Text = "SIMPAN";
            this.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSimpan.Textcolor = System.Drawing.Color.White;
            this.BtnSimpan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Panel1.Controls.Add(this.LblTime);
            this.Panel1.Controls.Add(this.LblDate);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(924, 160);
            this.Panel1.TabIndex = 16;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // DataMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.TextboxNo);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.ComboxJenisKendaraan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataMasuk";
            this.Size = new System.Drawing.Size(924, 688);
            this.Load += new System.EventHandler(this.DataMasuk_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboxJenisKendaraan;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextboxNo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSimpan;
        private System.Windows.Forms.Panel Panel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintDialog printDialog2;
        public System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
