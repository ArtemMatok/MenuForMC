namespace menu
{
    partial class FormsForManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsForManager));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbMenuManager = new System.Windows.Forms.ListBox();
            this.btnAddToMenu = new System.Windows.Forms.Button();
            this.btnDeleteFromMenu = new System.Windows.Forms.Button();
            this.btnViewMenu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(203)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(619, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "enu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(470, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbMenuManager
            // 
            this.lbMenuManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMenuManager.FormattingEnabled = true;
            this.lbMenuManager.ItemHeight = 42;
            this.lbMenuManager.Location = new System.Drawing.Point(12, 207);
            this.lbMenuManager.Name = "lbMenuManager";
            this.lbMenuManager.Size = new System.Drawing.Size(894, 676);
            this.lbMenuManager.TabIndex = 7;
            // 
            // btnAddToMenu
            // 
            this.btnAddToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddToMenu.Location = new System.Drawing.Point(912, 207);
            this.btnAddToMenu.Name = "btnAddToMenu";
            this.btnAddToMenu.Size = new System.Drawing.Size(321, 123);
            this.btnAddToMenu.TabIndex = 8;
            this.btnAddToMenu.Text = "Додати у меню";
            this.btnAddToMenu.UseVisualStyleBackColor = true;
            this.btnAddToMenu.Click += new System.EventHandler(this.btnAddToMenu_Click);
            this.btnAddToMenu.MouseEnter += new System.EventHandler(this.btnAddToMenu_MouseEnter);
            this.btnAddToMenu.MouseLeave += new System.EventHandler(this.btnAddToMenu_MouseLeave);
            // 
            // btnDeleteFromMenu
            // 
            this.btnDeleteFromMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteFromMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteFromMenu.Location = new System.Drawing.Point(912, 382);
            this.btnDeleteFromMenu.Name = "btnDeleteFromMenu";
            this.btnDeleteFromMenu.Size = new System.Drawing.Size(321, 132);
            this.btnDeleteFromMenu.TabIndex = 9;
            this.btnDeleteFromMenu.Text = "Видалити у меню";
            this.btnDeleteFromMenu.UseVisualStyleBackColor = true;
            this.btnDeleteFromMenu.Click += new System.EventHandler(this.btnDeleteFromMenu_Click);
            this.btnDeleteFromMenu.MouseEnter += new System.EventHandler(this.btnDeleteFromMenu_MouseEnter);
            this.btnDeleteFromMenu.MouseLeave += new System.EventHandler(this.btnDeleteFromMenu_MouseLeave);
            // 
            // btnViewMenu
            // 
            this.btnViewMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewMenu.Location = new System.Drawing.Point(912, 572);
            this.btnViewMenu.Name = "btnViewMenu";
            this.btnViewMenu.Size = new System.Drawing.Size(321, 132);
            this.btnViewMenu.TabIndex = 10;
            this.btnViewMenu.Text = "Подивитися замовлення";
            this.btnViewMenu.UseVisualStyleBackColor = true;
            this.btnViewMenu.Click += new System.EventHandler(this.btnViewMenu_Click);
            this.btnViewMenu.MouseEnter += new System.EventHandler(this.btnViewMenu_MouseEnter);
            this.btnViewMenu.MouseLeave += new System.EventHandler(this.btnViewMenu_MouseLeave);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(912, 747);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(321, 123);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormsForManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1301, 904);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewMenu);
            this.Controls.Add(this.btnDeleteFromMenu);
            this.Controls.Add(this.btnAddToMenu);
            this.Controls.Add(this.lbMenuManager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormsForManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormsForManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbMenuManager;
        private System.Windows.Forms.Button btnAddToMenu;
        private System.Windows.Forms.Button btnDeleteFromMenu;
        private System.Windows.Forms.Button btnViewMenu;
        private System.Windows.Forms.Button btnBack;
    }
}