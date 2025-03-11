namespace ParkirApp.view
{
    partial class Form2
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
            this.LblClose = new System.Windows.Forms.Label();
            this.btn_scanner = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_webcam = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblBatal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblClose
            // 
            this.LblClose.AutoSize = true;
            this.LblClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblClose.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClose.ForeColor = System.Drawing.Color.White;
            this.LblClose.Location = new System.Drawing.Point(585, 9);
            this.LblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblClose.Name = "LblClose";
            this.LblClose.Size = new System.Drawing.Size(23, 20);
            this.LblClose.TabIndex = 1;
            this.LblClose.Text = "X";
            this.LblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // btn_scanner
            // 
            this.btn_scanner.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_scanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_scanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_scanner.BorderRadius = 0;
            this.btn_scanner.ButtonText = "Scanner";
            this.btn_scanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_scanner.DisabledColor = System.Drawing.Color.Gray;
            this.btn_scanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scanner.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_scanner.Iconimage = null;
            this.btn_scanner.Iconimage_right = null;
            this.btn_scanner.Iconimage_right_Selected = null;
            this.btn_scanner.Iconimage_Selected = null;
            this.btn_scanner.IconMarginLeft = 0;
            this.btn_scanner.IconMarginRight = 0;
            this.btn_scanner.IconRightVisible = true;
            this.btn_scanner.IconRightZoom = 0D;
            this.btn_scanner.IconVisible = true;
            this.btn_scanner.IconZoom = 90D;
            this.btn_scanner.IsTab = false;
            this.btn_scanner.Location = new System.Drawing.Point(473, 594);
            this.btn_scanner.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_scanner.Name = "btn_scanner";
            this.btn_scanner.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_scanner.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_scanner.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_scanner.selected = false;
            this.btn_scanner.Size = new System.Drawing.Size(106, 39);
            this.btn_scanner.TabIndex = 14;
            this.btn_scanner.Text = "Scanner";
            this.btn_scanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_scanner.Textcolor = System.Drawing.Color.White;
            this.btn_scanner.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scanner.Click += new System.EventHandler(this.btn_scanner_Click);
            // 
            // btn_webcam
            // 
            this.btn_webcam.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_webcam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_webcam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_webcam.BorderRadius = 0;
            this.btn_webcam.ButtonText = "Webcam";
            this.btn_webcam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_webcam.DisabledColor = System.Drawing.Color.Gray;
            this.btn_webcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_webcam.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_webcam.Iconimage = null;
            this.btn_webcam.Iconimage_right = null;
            this.btn_webcam.Iconimage_right_Selected = null;
            this.btn_webcam.Iconimage_Selected = null;
            this.btn_webcam.IconMarginLeft = 0;
            this.btn_webcam.IconMarginRight = 0;
            this.btn_webcam.IconRightVisible = true;
            this.btn_webcam.IconRightZoom = 0D;
            this.btn_webcam.IconVisible = true;
            this.btn_webcam.IconZoom = 90D;
            this.btn_webcam.IsTab = false;
            this.btn_webcam.Location = new System.Drawing.Point(350, 594);
            this.btn_webcam.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_webcam.Name = "btn_webcam";
            this.btn_webcam.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_webcam.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_webcam.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_webcam.selected = false;
            this.btn_webcam.Size = new System.Drawing.Size(106, 39);
            this.btn_webcam.TabIndex = 13;
            this.btn_webcam.Text = "Webcam";
            this.btn_webcam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_webcam.Textcolor = System.Drawing.Color.White;
            this.btn_webcam.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_webcam.Click += new System.EventHandler(this.btn_webcam_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox2.Location = new System.Drawing.Point(27, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(552, 380);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "No Masuk :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Camera :";
            // 
            // LblBatal
            // 
            this.LblBatal.AutoSize = true;
            this.LblBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBatal.ForeColor = System.Drawing.Color.Black;
            this.LblBatal.Location = new System.Drawing.Point(23, 600);
            this.LblBatal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBatal.Name = "LblBatal";
            this.LblBatal.Size = new System.Drawing.Size(69, 25);
            this.LblBatal.TabIndex = 19;
            this.LblBatal.Text = "Keluar";
            this.LblBatal.Click += new System.EventHandler(this.LblBatal_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 22);
            this.textBox1.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(621, 669);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblBatal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_scanner);
            this.Controls.Add(this.btn_webcam);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LblClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblClose;
        private Bunifu.Framework.UI.BunifuFlatButton btn_scanner;
        private Bunifu.Framework.UI.BunifuFlatButton btn_webcam;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblBatal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}