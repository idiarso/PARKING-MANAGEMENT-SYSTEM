namespace ParkirApp.view
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtboxNama = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtboxUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtboxPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtboxAlamat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtboxNoHp = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BtnSimpan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnBatal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxprivillage = new System.Windows.Forms.ComboBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.Panel1.Controls.Add(this.BtnClose);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(924, 38);
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
            this.BtnClose.Location = new System.Drawing.Point(873, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(47, 41);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 35;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 361);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "No.Hp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nama";
            // 
            // TxtboxNama
            // 
            this.TxtboxNama.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TxtboxNama.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtboxNama.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TxtboxNama.BorderThickness = 3;
            this.TxtboxNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtboxNama.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtboxNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtboxNama.isPassword = false;
            this.TxtboxNama.Location = new System.Drawing.Point(264, 118);
            this.TxtboxNama.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtboxNama.Name = "TxtboxNama";
            this.TxtboxNama.Size = new System.Drawing.Size(303, 49);
            this.TxtboxNama.TabIndex = 27;
            this.TxtboxNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtboxUsername
            // 
            this.TxtboxUsername.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TxtboxUsername.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtboxUsername.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TxtboxUsername.BorderThickness = 3;
            this.TxtboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtboxUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtboxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtboxUsername.isPassword = false;
            this.TxtboxUsername.Location = new System.Drawing.Point(264, 181);
            this.TxtboxUsername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtboxUsername.Name = "TxtboxUsername";
            this.TxtboxUsername.Size = new System.Drawing.Size(303, 49);
            this.TxtboxUsername.TabIndex = 28;
            this.TxtboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtboxPassword
            // 
            this.TxtboxPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TxtboxPassword.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtboxPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TxtboxPassword.BorderThickness = 3;
            this.TxtboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtboxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtboxPassword.isPassword = false;
            this.TxtboxPassword.Location = new System.Drawing.Point(264, 242);
            this.TxtboxPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtboxPassword.Name = "TxtboxPassword";
            this.TxtboxPassword.Size = new System.Drawing.Size(303, 49);
            this.TxtboxPassword.TabIndex = 29;
            this.TxtboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtboxAlamat
            // 
            this.TxtboxAlamat.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TxtboxAlamat.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtboxAlamat.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TxtboxAlamat.BorderThickness = 3;
            this.TxtboxAlamat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtboxAlamat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtboxAlamat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtboxAlamat.isPassword = false;
            this.TxtboxAlamat.Location = new System.Drawing.Point(264, 302);
            this.TxtboxAlamat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtboxAlamat.Name = "TxtboxAlamat";
            this.TxtboxAlamat.Size = new System.Drawing.Size(303, 49);
            this.TxtboxAlamat.TabIndex = 30;
            this.TxtboxAlamat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtboxNoHp
            // 
            this.TxtboxNoHp.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TxtboxNoHp.BorderColorIdle = System.Drawing.Color.Gray;
            this.TxtboxNoHp.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.TxtboxNoHp.BorderThickness = 3;
            this.TxtboxNoHp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtboxNoHp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtboxNoHp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtboxNoHp.isPassword = false;
            this.TxtboxNoHp.Location = new System.Drawing.Point(264, 361);
            this.TxtboxNoHp.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtboxNoHp.Name = "TxtboxNoHp";
            this.TxtboxNoHp.Size = new System.Drawing.Size(303, 49);
            this.TxtboxNoHp.TabIndex = 31;
            this.TxtboxNoHp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.BtnSimpan.Location = new System.Drawing.Point(394, 504);
            this.BtnSimpan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnSimpan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnSimpan.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnSimpan.selected = false;
            this.BtnSimpan.Size = new System.Drawing.Size(173, 49);
            this.BtnSimpan.TabIndex = 32;
            this.BtnSimpan.Text = "SIMPAN";
            this.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSimpan.Textcolor = System.Drawing.Color.White;
            this.BtnSimpan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
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
            this.BtnBatal.Location = new System.Drawing.Point(602, 504);
            this.BtnBatal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnBatal.Name = "BtnBatal";
            this.BtnBatal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnBatal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnBatal.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnBatal.selected = false;
            this.BtnBatal.Size = new System.Drawing.Size(173, 49);
            this.BtnBatal.TabIndex = 33;
            this.BtnBatal.Text = "Batal";
            this.BtnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnBatal.Textcolor = System.Drawing.Color.White;
            this.BtnBatal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBatal.Click += new System.EventHandler(this.BtnBatal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(35, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 36);
            this.label6.TabIndex = 34;
            this.label6.Text = "Add User";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 420);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Privillage";
            // 
            // comboBoxprivillage
            // 
            this.comboBoxprivillage.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxprivillage.FormattingEnabled = true;
            this.comboBoxprivillage.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBoxprivillage.Location = new System.Drawing.Point(264, 424);
            this.comboBoxprivillage.Name = "comboBoxprivillage";
            this.comboBoxprivillage.Size = new System.Drawing.Size(303, 24);
            this.comboBoxprivillage.TabIndex = 37;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 702);
            this.Controls.Add(this.comboBoxprivillage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnBatal);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.TxtboxNoHp);
            this.Controls.Add(this.TxtboxAlamat);
            this.Controls.Add(this.TxtboxPassword);
            this.Controls.Add(this.TxtboxUsername);
            this.Controls.Add(this.TxtboxNama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtboxNama;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtboxUsername;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtboxPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtboxAlamat;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtboxNoHp;
        private Bunifu.Framework.UI.BunifuFlatButton BtnSimpan;
        private Bunifu.Framework.UI.BunifuFlatButton BtnBatal;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxprivillage;
    }
}