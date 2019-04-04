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
    public partial class Login : Form
    {
        SQLConnect sqlConnect = new SQLConnect();
        public Login()
        {
            InitializeComponent();            
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginText.Text;
            string password = passwordText.Text;
            if (sqlConnect.loginValidate(login, password) == true)
            {
                if (sqlConnect.loginValidateAdmin(login) == true)
                {

                    MessageBox.Show("Zalogowano pomyślnie w trybie administratora");

                    MainMenuAdmin window = new MainMenuAdmin();
                    window.Show();
                    this.Hide();
                }
                if (sqlConnect.loginValidateAdmin(login) == false)
                {

                    MessageBox.Show("Zalogowano pomyślnie w trybie użytkownika");

                    MainMenuUser window = new MainMenuUser();
                    window.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("blad");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string login = loginRegisterText.Text;
            string password = passwordRegisterText.Text;
            string name = nameRegisterText.Text;
            string surname = surnameRegisterText.Text;
            string city = cityRegisterCombo.Text;
            sqlConnect.register(login, password, name, surname, city);
            {
                MessageBox.Show("Rejestracja pomyślna! Możesz się zalogować");
            }
        }

        

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
