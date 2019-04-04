using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityUpDesktop
{
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuUser window = new MainMenuUser();
            window.Show();
        }
        public string photoName;
        private void confirmEvent_Click(object sender, EventArgs e)
        {
            string eventName = eventNameText.Text;
            string eventDescription = eventDescriptionText.Text;
            string owner = Session.login;
            int status =0;
            string city = Session.city;
            DateTime myDate = DateTime.Now;

            string longDateString = myDate.ToString("dd-MM-yyyy-hh-mm");
            string photo= Session.id + "_" + longDateString + ".jpg";
            SQLConnect sqlConnect = new SQLConnect();
            sqlConnect.addEvent(eventName,eventDescription,owner,status, city, photo);
            FtpController ftp = new FtpController();
            

            ftp.upload("uploads/"+Session.id+"_"+longDateString+".jpg", photoName);
            MessageBox.Show("Dziękujemy za dodanie zdarzenia :)");
            MainMenuUser window = new MainMenuUser();
            window.Show();
            this.Close();
        }

        private void selectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            //For any other formats
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                previewPhoto.ImageLocation = of.FileName;
                photoName = @of.FileName;

            }

           
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
