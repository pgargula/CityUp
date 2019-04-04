using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityUpDesktop
{
    class User
    {
        private string login;
        private string password;
        private string name;
        private string surname;
        private string city;
        private int rank;
        User(string login, string password, string name, string surname, string city, int rank)
        {
            this.login = login;
            this.password = password;
            this.name = name;
            this.surname = surname;
            this.city = city;
            this.rank = rank;
        }
        public string getLogin()
        {
            return login;
        }
        public string getPassword()
        {
            return password;
        }
        public string getName()
        {
            return name;
        }
        public string getSurname()
        {
            return surname;
        }
        public string getCity()
        {
            return city;
        }
        public int getRank()
        {
            return rank;
        }
    }
}
