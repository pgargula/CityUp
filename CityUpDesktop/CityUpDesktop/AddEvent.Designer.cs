namespace CityUpDesktop
{
    partial class AddEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEvent));
            this.previewPhoto = new System.Windows.Forms.PictureBox();
            this.eventName = new System.Windows.Forms.Label();
            this.eventNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eventDescriptionText = new System.Windows.Forms.RichTextBox();
            this.confirmEvent = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.selectPhoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // previewPhoto
            // 
            this.previewPhoto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.previewPhoto.Location = new System.Drawing.Point(55, 81);
            this.previewPhoto.Name = "previewPhoto";
            this.previewPhoto.Size = new System.Drawing.Size(211, 185);
            this.previewPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewPhoto.TabIndex = 0;
            this.previewPhoto.TabStop = false;
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.BackColor = System.Drawing.Color.Transparent;
            this.eventName.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.eventName.ForeColor = System.Drawing.Color.White;
            this.eventName.Location = new System.Drawing.Point(281, 85);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(125, 19);
            this.eventName.TabIndex = 1;
            this.eventName.Text = "Nazwa zdarzenia:";
            // 
            // eventNameText
            // 
            this.eventNameText.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.eventNameText.Location = new System.Drawing.Point(425, 84);
            this.eventNameText.Name = "eventNameText";
            this.eventNameText.Size = new System.Drawing.Size(294, 27);
            this.eventNameText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(295, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Opis zdarzenia:";
            // 
            // eventDescriptionText
            // 
            this.eventDescriptionText.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.eventDescriptionText.Location = new System.Drawing.Point(423, 125);
            this.eventDescriptionText.Name = "eventDescriptionText";
            this.eventDescriptionText.Size = new System.Drawing.Size(296, 284);
            this.eventDescriptionText.TabIndex = 4;
            this.eventDescriptionText.Text = "";
            // 
            // confirmEvent
            // 
            this.confirmEvent.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.confirmEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmEvent.BackgroundImage")));
            this.confirmEvent.Location = new System.Drawing.Point(491, 484);
            this.confirmEvent.Name = "confirmEvent";
            this.confirmEvent.Size = new System.Drawing.Size(160, 40);
            this.confirmEvent.TabIndex = 5;
            this.confirmEvent.TabStop = false;
            this.confirmEvent.Click += new System.EventHandler(this.confirmEvent_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.Location = new System.Drawing.Point(24, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(80, 64);
            this.closeButton.TabIndex = 6;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // selectPhoto
            // 
            this.selectPhoto.Location = new System.Drawing.Point(664, 423);
            this.selectPhoto.Name = "selectPhoto";
            this.selectPhoto.Size = new System.Drawing.Size(31, 29);
            this.selectPhoto.TabIndex = 7;
            this.selectPhoto.Text = "...";
            this.selectPhoto.UseVisualStyleBackColor = true;
            this.selectPhoto.Click += new System.EventHandler(this.selectPhoto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(472, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wybierz zdjęcie z dysku:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(101, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Podgląd zdjęcia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(692, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectPhoto);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.confirmEvent);
            this.Controls.Add(this.eventDescriptionText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventNameText);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.previewPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEvent";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEvent";
            ((System.ComponentModel.ISupportInitialize)(this.previewPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewPhoto;
        private System.Windows.Forms.Label eventName;
        private System.Windows.Forms.TextBox eventNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox eventDescriptionText;
        private System.Windows.Forms.PictureBox confirmEvent;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Button selectPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}