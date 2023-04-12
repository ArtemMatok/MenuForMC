namespace menu
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbManageLogin = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbManagerPassword = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnLoginManager = new System.Windows.Forms.Button();
            this.lbBack = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(295, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(444, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 91);
            this.label1.TabIndex = 3;
            this.label1.Text = "anager";
            // 
            // tbManageLogin
            // 
            this.tbManageLogin.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbManageLogin.Location = new System.Drawing.Point(160, 268);
            this.tbManageLogin.Multiline = true;
            this.tbManageLogin.Name = "tbManageLogin";
            this.tbManageLogin.Size = new System.Drawing.Size(864, 90);
            this.tbManageLogin.TabIndex = 12;
            this.tbManageLogin.Enter += new System.EventHandler(this.tbManageLogin_Enter);
            this.tbManageLogin.Leave += new System.EventHandler(this.tbManageLogin_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(46, 268);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // tbManagerPassword
            // 
            this.tbManagerPassword.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbManagerPassword.Location = new System.Drawing.Point(160, 472);
            this.tbManagerPassword.Name = "tbManagerPassword";
            this.tbManagerPassword.Size = new System.Drawing.Size(864, 104);
            this.tbManagerPassword.TabIndex = 16;
            this.tbManagerPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(46, 472);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(90, 90);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // btnLoginManager
            // 
            this.btnLoginManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(50)))));
            this.btnLoginManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoginManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginManager.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoginManager.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginManager.Location = new System.Drawing.Point(381, 610);
            this.btnLoginManager.Name = "btnLoginManager";
            this.btnLoginManager.Size = new System.Drawing.Size(281, 102);
            this.btnLoginManager.TabIndex = 17;
            this.btnLoginManager.Text = "Увійти";
            this.btnLoginManager.UseVisualStyleBackColor = false;
            this.btnLoginManager.Click += new System.EventHandler(this.btnLoginManager_Click);
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(50)))));
            this.lbBack.Location = new System.Drawing.Point(466, 715);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(118, 38);
            this.lbBack.TabIndex = 18;
            this.lbBack.Text = "Назад";
            this.lbBack.Click += new System.EventHandler(this.lbBack_Click);
            this.lbBack.MouseEnter += new System.EventHandler(this.lbBack_MouseEnter);
            this.lbBack.MouseLeave += new System.EventHandler(this.lbBack_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(126, 103);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1088, 785);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.btnLoginManager);
            this.Controls.Add(this.tbManagerPassword);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.tbManageLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbManageLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbManagerPassword;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnLoginManager;
        private System.Windows.Forms.Label lbBack;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}