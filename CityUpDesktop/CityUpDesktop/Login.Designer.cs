namespace CityUpDesktop
{
    partial class Login
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginButton = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameRegisterText = new System.Windows.Forms.TextBox();
            this.nameRegisterLabel = new System.Windows.Forms.Label();
            this.loginRegisterText = new System.Windows.Forms.TextBox();
            this.loginRegisterLabel = new System.Windows.Forms.Label();
            this.surnameRegisterText = new System.Windows.Forms.TextBox();
            this.surnameRegisterLabel = new System.Windows.Forms.Label();
            this.passwordRegisterText = new System.Windows.Forms.TextBox();
            this.passwordRegisterLabel = new System.Windows.Forms.Label();
            this.cityRegisterLabel = new System.Windows.Forms.Label();
            this.cityRegisterCombo = new System.Windows.Forms.ComboBox();
            this.registerButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginButton.BackgroundImage")));
            this.loginButton.Location = new System.Drawing.Point(126, 442);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(160, 40);
            this.loginButton.TabIndex = 1;
            this.loginButton.TabStop = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(156, 169);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(100, 39);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login:";
            // 
            // loginText
            // 
            this.loginText.BackColor = System.Drawing.Color.White;
            this.loginText.Font = new System.Drawing.Font("Corbel", 16F);
            this.loginText.Location = new System.Drawing.Point(117, 222);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(178, 34);
            this.loginText.TabIndex = 3;
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Corbel", 16F);
            this.passwordText.Location = new System.Drawing.Point(117, 333);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '●';
            this.passwordText.Size = new System.Drawing.Size(178, 34);
            this.passwordText.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Corbel", 24F);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(156, 285);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(99, 39);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Hasło:";
            // 
            // nameRegisterText
            // 
            this.nameRegisterText.Font = new System.Drawing.Font("Corbel", 14F);
            this.nameRegisterText.Location = new System.Drawing.Point(542, 235);
            this.nameRegisterText.Name = "nameRegisterText";
            this.nameRegisterText.Size = new System.Drawing.Size(178, 30);
            this.nameRegisterText.TabIndex = 9;
            // 
            // nameRegisterLabel
            // 
            this.nameRegisterLabel.AutoSize = true;
            this.nameRegisterLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameRegisterLabel.Font = new System.Drawing.Font("Corbel", 14F);
            this.nameRegisterLabel.ForeColor = System.Drawing.Color.White;
            this.nameRegisterLabel.Location = new System.Drawing.Point(455, 238);
            this.nameRegisterLabel.Name = "nameRegisterLabel";
            this.nameRegisterLabel.Size = new System.Drawing.Size(49, 23);
            this.nameRegisterLabel.TabIndex = 8;
            this.nameRegisterLabel.Text = "Imię:";
            // 
            // loginRegisterText
            // 
            this.loginRegisterText.Font = new System.Drawing.Font("Corbel", 14F);
            this.loginRegisterText.Location = new System.Drawing.Point(542, 190);
            this.loginRegisterText.Name = "loginRegisterText";
            this.loginRegisterText.Size = new System.Drawing.Size(178, 30);
            this.loginRegisterText.TabIndex = 7;
            // 
            // loginRegisterLabel
            // 
            this.loginRegisterLabel.AutoSize = true;
            this.loginRegisterLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginRegisterLabel.Font = new System.Drawing.Font("Corbel", 14F);
            this.loginRegisterLabel.ForeColor = System.Drawing.Color.White;
            this.loginRegisterLabel.Location = new System.Drawing.Point(455, 193);
            this.loginRegisterLabel.Name = "loginRegisterLabel";
            this.loginRegisterLabel.Size = new System.Drawing.Size(59, 23);
            this.loginRegisterLabel.TabIndex = 6;
            this.loginRegisterLabel.Text = "Login:";
            // 
            // surnameRegisterText
            // 
            this.surnameRegisterText.Font = new System.Drawing.Font("Corbel", 14F);
            this.surnameRegisterText.Location = new System.Drawing.Point(542, 281);
            this.surnameRegisterText.Name = "surnameRegisterText";
            this.surnameRegisterText.Size = new System.Drawing.Size(178, 30);
            this.surnameRegisterText.TabIndex = 11;
            // 
            // surnameRegisterLabel
            // 
            this.surnameRegisterLabel.AutoSize = true;
            this.surnameRegisterLabel.BackColor = System.Drawing.Color.Transparent;
            this.surnameRegisterLabel.Font = new System.Drawing.Font("Corbel", 14F);
            this.surnameRegisterLabel.ForeColor = System.Drawing.Color.White;
            this.surnameRegisterLabel.Location = new System.Drawing.Point(447, 284);
            this.surnameRegisterLabel.Name = "surnameRegisterLabel";
            this.surnameRegisterLabel.Size = new System.Drawing.Size(90, 23);
            this.surnameRegisterLabel.TabIndex = 10;
            this.surnameRegisterLabel.Text = "Nazwisko:";
            // 
            // passwordRegisterText
            // 
            this.passwordRegisterText.Font = new System.Drawing.Font("Corbel", 14F);
            this.passwordRegisterText.Location = new System.Drawing.Point(542, 326);
            this.passwordRegisterText.Name = "passwordRegisterText";
            this.passwordRegisterText.PasswordChar = '●';
            this.passwordRegisterText.Size = new System.Drawing.Size(178, 30);
            this.passwordRegisterText.TabIndex = 13;
            // 
            // passwordRegisterLabel
            // 
            this.passwordRegisterLabel.AutoSize = true;
            this.passwordRegisterLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordRegisterLabel.Font = new System.Drawing.Font("Corbel", 14F);
            this.passwordRegisterLabel.ForeColor = System.Drawing.Color.White;
            this.passwordRegisterLabel.Location = new System.Drawing.Point(452, 329);
            this.passwordRegisterLabel.Name = "passwordRegisterLabel";
            this.passwordRegisterLabel.Size = new System.Drawing.Size(59, 23);
            this.passwordRegisterLabel.TabIndex = 12;
            this.passwordRegisterLabel.Text = "Hasło:";
            // 
            // cityRegisterLabel
            // 
            this.cityRegisterLabel.AutoSize = true;
            this.cityRegisterLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityRegisterLabel.Font = new System.Drawing.Font("Corbel", 14F);
            this.cityRegisterLabel.ForeColor = System.Drawing.Color.White;
            this.cityRegisterLabel.Location = new System.Drawing.Point(452, 368);
            this.cityRegisterLabel.Name = "cityRegisterLabel";
            this.cityRegisterLabel.Size = new System.Drawing.Size(69, 23);
            this.cityRegisterLabel.TabIndex = 14;
            this.cityRegisterLabel.Text = "Miasto:";
            // 
            // cityRegisterCombo
            // 
            this.cityRegisterCombo.Font = new System.Drawing.Font("Corbel", 14F);
            this.cityRegisterCombo.FormattingEnabled = true;
            this.cityRegisterCombo.Items.AddRange(new object[] {
            "Kraków",
            "Warszawa",
            "Gdańsk",
            "Poznań",
            "Wrocław",
            "Łódź"});
            this.cityRegisterCombo.Location = new System.Drawing.Point(542, 365);
            this.cityRegisterCombo.Name = "cityRegisterCombo";
            this.cityRegisterCombo.Size = new System.Drawing.Size(178, 31);
            this.cityRegisterCombo.TabIndex = 15;
            this.cityRegisterCombo.Text = "Kraków";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.registerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registerButton.BackgroundImage")));
            this.registerButton.Location = new System.Drawing.Point(527, 442);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(160, 40);
            this.registerButton.TabIndex = 16;
            this.registerButton.TabStop = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(462, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 138);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.cityRegisterCombo);
            this.Controls.Add(this.cityRegisterLabel);
            this.Controls.Add(this.passwordRegisterText);
            this.Controls.Add(this.passwordRegisterLabel);
            this.Controls.Add(this.surnameRegisterText);
            this.Controls.Add(this.surnameRegisterLabel);
            this.Controls.Add(this.nameRegisterText);
            this.Controls.Add(this.nameRegisterLabel);
            this.Controls.Add(this.loginRegisterText);
            this.Controls.Add(this.loginRegisterLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loginButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox nameRegisterText;
        private System.Windows.Forms.Label nameRegisterLabel;
        private System.Windows.Forms.TextBox loginRegisterText;
        private System.Windows.Forms.Label loginRegisterLabel;
        private System.Windows.Forms.TextBox surnameRegisterText;
        private System.Windows.Forms.Label surnameRegisterLabel;
        private System.Windows.Forms.TextBox passwordRegisterText;
        private System.Windows.Forms.Label passwordRegisterLabel;
        private System.Windows.Forms.Label cityRegisterLabel;
        private System.Windows.Forms.ComboBox cityRegisterCombo;
        private System.Windows.Forms.PictureBox registerButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

