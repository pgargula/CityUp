namespace CityUpDesktop
{
    partial class MainMenuUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuUser));
            this.avatarUser = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.showEvents = new System.Windows.Forms.PictureBox();
            this.addEvents = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatarUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // avatarUser
            // 
            this.avatarUser.BackColor = System.Drawing.Color.Transparent;
            this.avatarUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("avatarUser.BackgroundImage")));
            this.avatarUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatarUser.Location = new System.Drawing.Point(88, 146);
            this.avatarUser.Name = "avatarUser";
            this.avatarUser.Size = new System.Drawing.Size(121, 112);
            this.avatarUser.TabIndex = 0;
            this.avatarUser.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(84, 300);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 19);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Imię";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.surnameLabel.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.surnameLabel.ForeColor = System.Drawing.Color.White;
            this.surnameLabel.Location = new System.Drawing.Point(84, 319);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(73, 19);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Nazwisko";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(113, 261);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(71, 29);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Login";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // showEvents
            // 
            this.showEvents.BackColor = System.Drawing.Color.Transparent;
            this.showEvents.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showEvents.BackgroundImage")));
            this.showEvents.Location = new System.Drawing.Point(272, 219);
            this.showEvents.Name = "showEvents";
            this.showEvents.Size = new System.Drawing.Size(219, 100);
            this.showEvents.TabIndex = 4;
            this.showEvents.TabStop = false;
            this.showEvents.Click += new System.EventHandler(this.showEvents_Click);
            // 
            // addEvents
            // 
            this.addEvents.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addEvents.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addEvents.BackgroundImage")));
            this.addEvents.Location = new System.Drawing.Point(516, 219);
            this.addEvents.Name = "addEvents";
            this.addEvents.Size = new System.Drawing.Size(219, 100);
            this.addEvents.TabIndex = 5;
            this.addEvents.TabStop = false;
            this.addEvents.Click += new System.EventHandler(this.addEvents_Click);
            // 
            // MainMenuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.addEvents);
            this.Controls.Add(this.showEvents);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.avatarUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuUser";
            this.Load += new System.EventHandler(this.MainMenuUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatarUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avatarUser;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.PictureBox showEvents;
        private System.Windows.Forms.PictureBox addEvents;
    }
}