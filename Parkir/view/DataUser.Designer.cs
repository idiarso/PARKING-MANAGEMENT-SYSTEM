namespace ParkirApp.view
{
    partial class DataUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataUser));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnBatal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnPrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.Panel1.Controls.Add(this.BtnClose);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(693, 35);
            this.Panel1.TabIndex = 0;
            this.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(655, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(35, 33);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 3;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.BtnBatal);
            this.Panel2.Controls.Add(this.BtnPrint);
            this.Panel2.Controls.Add(this.DataGridView1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(0, 35);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(693, 535);
            this.Panel2.TabIndex = 1;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(227, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(244, 29);
            this.Label1.TabIndex = 30;
            this.Label1.Text = "Data Petugas Parkir";
            // 
            // BtnBatal
            // 
            this.BtnBatal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnBatal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBatal.BorderRadius = 0;
            this.BtnBatal.ButtonText = "Batal";
            this.BtnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBatal.DisabledColor = System.Drawing.Color.Gray;
            this.BtnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBatal.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnBatal.Iconimage = null;
            this.BtnBatal.Iconimage_right = null;
            this.BtnBatal.Iconimage_right_Selected = null;
            this.BtnBatal.Iconimage_Selected = null;
            this.BtnBatal.IconMarginLeft = 0;
            this.BtnBatal.IconMarginRight = 0;
            this.BtnBatal.IconRightVisible = true;
            this.BtnBatal.IconRightZoom = 0D;
            this.BtnBatal.IconVisible = true;
            this.BtnBatal.IconZoom = 90D;
            this.BtnBatal.IsTab = false;
            this.BtnBatal.Location = new System.Drawing.Point(555, 367);
            this.BtnBatal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnBatal.Name = "BtnBatal";
            this.BtnBatal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnBatal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnBatal.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnBatal.selected = false;
            this.BtnBatal.Size = new System.Drawing.Size(116, 36);
            this.BtnBatal.TabIndex = 29;
            this.BtnBatal.Text = "Batal";
            this.BtnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnBatal.Textcolor = System.Drawing.Color.White;
            this.BtnBatal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBatal.Click += new System.EventHandler(this.BtnBatal_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Activecolor = System.Drawing.Color.Gainsboro;
            this.BtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrint.BackColor = System.Drawing.Color.White;
            this.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrint.BorderRadius = 0;
            this.BtnPrint.ButtonText = "      Print";
            this.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrint.DisabledColor = System.Drawing.Color.Gray;
            this.BtnPrint.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnPrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Iconimage")));
            this.BtnPrint.Iconimage_right = null;
            this.BtnPrint.Iconimage_right_Selected = null;
            this.BtnPrint.Iconimage_Selected = null;
            this.BtnPrint.IconMarginLeft = 30;
            this.BtnPrint.IconMarginRight = 0;
            this.BtnPrint.IconRightVisible = true;
            this.BtnPrint.IconRightZoom = 0D;
            this.BtnPrint.IconVisible = true;
            this.BtnPrint.IconZoom = 40D;
            this.BtnPrint.IsTab = true;
            this.BtnPrint.Location = new System.Drawing.Point(420, 367);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Normalcolor = System.Drawing.Color.White;
            this.BtnPrint.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnPrint.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnPrint.selected = false;
            this.BtnPrint.Size = new System.Drawing.Size(128, 36);
            this.BtnPrint.TabIndex = 22;
            this.BtnPrint.Text = "      Print";
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrint.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnPrint.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(52, 71);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(594, 290);
            this.DataGridView1.TabIndex = 0;
            // 
            // PrintDocument1
            // 
            this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // PrintPreviewDialog1
            // 
            this.PrintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog1.Enabled = true;
            this.PrintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog1.Icon")));
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            this.PrintPreviewDialog1.Visible = false;
            // 
            // DataUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 570);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataUser";
            this.Load += new System.EventHandler(this.DataUser_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.DataGridView DataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnPrint;
        private Bunifu.Framework.UI.BunifuFlatButton BtnBatal;
        private System.Windows.Forms.Label Label1;
        private System.Drawing.Printing.PrintDocument PrintDocument1;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog1;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
    }
}