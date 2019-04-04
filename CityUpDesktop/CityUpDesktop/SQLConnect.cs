using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace CityUpDesktop
{
    class SQLConnect
    {
        string myConnection = "SERVER=sql7.freemysqlhosting.net" + ";" + "DATABASE=sql7265875" + ";" + "UID=sql7265875" + ";" + "PASSWORD=KnBhMmGdtA" + ";";
        MySqlConnection myConn;

        public SQLConnect()
        {
            myConn = new MySqlConnection(myConnection);
            myConn.Open();
        }
        ~SQLConnect()
        {
            myConn.Close();
        }
        public void setSession(string login)
        {
            

            MySqlDataReader rdr = null;

            String sql;
            sql = "select  * from Users where Login='" + login + "'";

            MySqlCommand cmd = new MySqlCommand(sql, myConn);

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Session.id = rdr.GetInt32(0);
                Session.login = login;
                Session.name=rdr.GetString(3);
                Session.surname = rdr.GetString(4);
                Session.city= rdr.GetString(5);
            }
            if (rdr != null)
            {
                rdr.Close();
            }

        }

        public bool loginValidate(string login,string passwd)
        {

            bool pv = false;
            
            MySqlDataReader rdr = null;            

            String sql;
            sql = "select  Password from Users where Login='"+login+"'";

            MySqlCommand cmd = new MySqlCommand(sql, myConn);
            
            rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {


                if (passwd == rdr.GetString(0))
                {
                   
                    pv = true;
                }
            }
            if (rdr != null)
            {
                rdr.Close();
            }
            if (pv==true)
            {
                setSession(login);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool loginValidateAdmin(string login)
        {

            bool pv = false;

            MySqlDataReader rdr = null;

            String sql;
            sql = "select Account from Users where Login='" + login + "'";

            MySqlCommand cmd = new MySqlCommand(sql, myConn);

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {


                if ("1" == rdr.GetString(0))
                {

                    pv = true;
                }
            }
            if (rdr != null)
            {
                rdr.Close();
            }
            if (pv == true)
            {
                setSession(login);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void register(string login, string passwd, string name,string surn,string city)
        {
            String sql;
            sql = "INSERT INTO Users(Login, Password, Name, Surname, City) VALUES(@Login, @Password, @Name, @Surname, @City)";
           
           
            



            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = "INSERT INTO Users(Login, Password, Name, Surname, City) VALUES(@Login, @Password, @Name, @Surname, @City)";
            cmd.Parameters.AddWithValue("@Login",login);
            cmd.Parameters.AddWithValue("@Password", passwd);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Surname", surn);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.ExecuteNonQuery();
            




        }

        public void addEvent(string eventName, string eventDescription, string owner, int status, string city, string photo)
        {
           
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = "INSERT INTO Events(OwnerId, Name, Description, City, Photo, Status) VALUES(@OwnerId, @Name, @Description, @City, @Photo, @Status)";
            cmd.Parameters.AddWithValue("@OwnerId", owner);
            cmd.Parameters.AddWithValue("@Name", eventName);
            cmd.Parameters.AddWithValue("@Description",eventDescription);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@Photo", photo);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Pomyslnie dodano zdarzenie!");
        }

        public void plusRank(int id)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = "UPDATE Events SET Rank = Rank + 1 WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Pomyslnie oddano głos!");
        }
        public void minusRank(int id)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = "UPDATE Events SET Rank = Rank - 1 WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Pomyslnie oddano głos!");
        }

        public BindingSource getEvent()
        {
            String sql;
            sql = "select * from Events";
            MySqlCommand cmd = new MySqlCommand(sql, myConn);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dT = new DataTable();
            sda.Fill(dT);

            BindingSource bs = new BindingSource();
            bs.DataSource = dT;
            return bs;
        }
        public BindingSource getEvent(string sql)
        {
            
            MySqlCommand cmd = new MySqlCommand(sql, myConn);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dT = new DataTable();
            sda.Fill(dT);

            BindingSource bs = new BindingSource();
            bs.DataSource = dT;
            return bs;
        }

        public void setEvent(int status)
        {
            MySqlDataReader rdr = null;

            String sql;
            sql = "select * from Events WHERE Status="+status+" AND City='" + Convert.ToString(Session.city)+"';";

            MySqlCommand cmd = new MySqlCommand(sql, myConn);

            rdr = cmd.ExecuteReader();
            //  EventList eList = new EventList();
            while (rdr.Read())
            {
                Event ev = new Event(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(6), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetInt32(7), rdr.GetString(5));
                EventList.eventList.Add(ev);
               
            }
            if (rdr != null)
            {
                rdr.Close();
            }
        }




        public void setEvent()
        {
            MySqlDataReader rdr = null;

            String sql;
            sql = "select  * from Events WHERE City='" + Convert.ToString(Session.city) + "';";

            MySqlCommand cmd = new MySqlCommand(sql, myConn);

            rdr = cmd.ExecuteReader();
            //  EventList eList = new EventList();
            while (rdr.Read())
            {
                Event ev = new Event(rdr.GetInt32(0),rdr.GetString(1), rdr.GetInt32(6), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetInt32(7), rdr.GetString(5));
                EventList.eventList.Add(ev);
                
            }
            if (rdr != null)
            {
                rdr.Close();
            }
        }
        public void changeToRealisation(int id)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = "UPDATE Events SET Status = 0 WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Pomyslnie zmieniono status!");
        }
        public void changeInRealisation(int id)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = "UPDATE Events SET Status = 1 WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Pomyslnie zmieniono status!");

        }
        public void changeDone(int id)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = myConn;
            cmd.CommandText = "UPDATE Events SET Status = 3 WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Pomyslnie zmieniono status!");
        }

    }
}
    

