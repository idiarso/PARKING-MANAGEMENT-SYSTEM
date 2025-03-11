namespace ParkirApp.view
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTarif = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnAddUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnUser = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnTarif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUser)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Panel1.Controls.Add(this.LblTime);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(693, 130);
            this.Panel1.TabIndex = 18;
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
            this.LblTime.Size = new System.Drawing.Size(0, 79);
            this.LblTime.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Options";
            // 
            // BtnTarif
            // 
            this.BtnTarif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTarif.BackColor = System.Drawing.SystemColors.Control;
            this.BtnTarif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTarif.Image = ((System.Drawing.Image)(resources.GetObject("BtnTarif.Image")));
            this.BtnTarif.ImageActive = null;
            this.BtnTarif.Location = new System.Drawing.Point(158, 172);
            this.BtnTarif.Name = "BtnTarif";
            this.BtnTarif.Size = new System.Drawing.Size(95, 89);
            this.BtnTarif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnTarif.TabIndex = 19;
            this.BtnTarif.TabStop = false;
            this.BtnTarif.Zoom = 10;
            this.BtnTarif.Click += new System.EventHandler(this.BtnTarif_Click);
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddUser.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddUser.Image")));
            this.BtnAddUser.ImageActive = null;
            this.BtnAddUser.Location = new System.Drawing.Point(437, 172);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(99, 89);
            this.BtnAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnAddUser.TabIndex = 20;
            this.BtnAddUser.TabStop = false;
            this.BtnAddUser.Zoom = 10;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // BtnUser
            // 
            this.BtnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUser.BackColor = System.Drawing.SystemColors.Control;
            this.BtnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUser.Image = ((System.Drawing.Image)(resources.GetObject("BtnUser.Image")));
            this.BtnUser.ImageActive = null;
            this.BtnUser.Location = new System.Drawing.Point(299, 363);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(99, 86);
            this.BtnUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnUser.TabIndex = 21;
            this.BtnUser.TabStop = false;
            this.BtnUser.Zoom = 10;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pengaturan Tarif";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Add User";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Data Petugas";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.BtnTarif);
            this.Controls.Add(this.Panel1);
            this.Name = "Options";
            this.Size = new System.Drawing.Size(693, 559);
            this.Load += new System.EventHandler(this.Options_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnTarif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton BtnTarif;
        private Bunifu.Framework.UI.BunifuImageButton BtnAddUser;
        private Bunifu.Framework.UI.BunifuImageButton BtnUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
