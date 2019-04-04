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
    public partial class MainMenuUser : Form
    {
        public MainMenuUser()
        {
            InitializeComponent();
        }

        private void MainMenuUser_Load(object sender, EventArgs e)
        {
            nameLabel.Text = Session.name;
            surnameLabel.Text = Session.surname;
            loginLabel.Text = Session.login;
        }

        private void addEvents_Click(object sender, EventArgs e)
        {
            AddEvent window = new AddEvent();
            window.Show();
            this.Hide();
        }

        private void showEvents_Click(object sender, EventArgs e)
        {
            ShowEvents window = new ShowEvents();
            window.Show();
            this.Hide();
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

       
    }
}
