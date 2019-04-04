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
    public partial class ShowEvents : Form
    {
        SQLConnect sqlConnect = new SQLConnect();
        public ShowEvents()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            listBox2.Items.Clear();


        }
        private void UpdateList()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            for (int i = 0; i < EventList.eventList.Count; i++)
            {
                listBox1.Items.Add(String.Format("{0}", EventList.eventList[i].name ));
                listBox2.Items.Add(String.Format("{0}", EventList.eventList[i].rank));
                label2.Text = EventList.eventList[i].city;
                label4.Text = EventList.eventList[i].description;


            }
        }

        private void ShowEvents_Load(object sender, EventArgs e)
        {

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EventList.eventList.Clear();
            sqlConnect.setEvent();
            UpdateList();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuUser window = new MainMenuUser();
            window.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          //  dataGridView1.DataSource = sqlConnect.getEvent("select * from Events order by City");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
          //  dataGridView1.DataSource = sqlConnect.getEvent("select * from Events order by OwnerId");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
          //  dataGridView1.DataSource = sqlConnect.getEvent("select * from Events order by Status");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            previewBox.Load("http://hackatonsii.cba.pl/uploads/"+ EventList.eventList[listBox1.SelectedIndex].photo);
            label2.Text = EventList.eventList[listBox1.SelectedIndex].city;
            label4.Text = EventList.eventList[listBox1.SelectedIndex].description;
            label6.Text = EventList.eventList[listBox1.SelectedIndex].ownerId;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            sqlConnect.plusRank(EventList.eventList[listBox1.SelectedIndex].id);
            EventList.eventList.Clear();
            sqlConnect.setEvent();
            UpdateList();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            sqlConnect.minusRank(EventList.eventList[listBox1.SelectedIndex].id);
            EventList.eventList.Clear();
            sqlConnect.setEvent();
            UpdateList();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
