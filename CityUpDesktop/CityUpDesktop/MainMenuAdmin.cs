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
    public partial class MainMenuAdmin : Form
    {
        public MainMenuAdmin()
        {
            InitializeComponent();
        }
        SQLConnect sqlConnect = new SQLConnect();
        private void UpdateList()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            for (int i = 0; i < EventList.eventList.Count; i++)
            {
                listBox1.Items.Add(String.Format("{0}", EventList.eventList[i].name));
                listBox2.Items.Add(String.Format("{0}", EventList.eventList[i].rank));
                label2.Text = EventList.eventList[i].city;
                label4.Text = EventList.eventList[i].description;


            }
        }

        private void eventInQue_Click(object sender, EventArgs e)
        {
            EventList.eventList.Clear();
            sqlConnect.setEvent(0);
            UpdateList();
        }

        private void eventActive_Click(object sender, EventArgs e)
        {
            EventList.eventList.Clear();
            sqlConnect.setEvent(1);
            UpdateList();
        }

        private void eventFinished_Click(object sender, EventArgs e)
        {
            EventList.eventList.Clear();
            sqlConnect.setEvent(2);
            UpdateList();
        }

        private void MainMenuAdmin_Load(object sender, EventArgs e)
        {
            EventList.eventList.Clear();
            sqlConnect.setEvent();
            UpdateList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            previewBox.Load("http://hackatonsii.cba.pl/uploads/" + EventList.eventList[listBox1.SelectedIndex].photo);
            label2.Text = EventList.eventList[listBox1.SelectedIndex].city;
            label4.Text = EventList.eventList[listBox1.SelectedIndex].description;
            label6.Text = EventList.eventList[listBox1.SelectedIndex].ownerId;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sqlConnect.changeToRealisation(EventList.eventList[listBox1.SelectedIndex].id);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sqlConnect.changeInRealisation(EventList.eventList[listBox1.SelectedIndex].id);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sqlConnect.changeDone(EventList.eventList[listBox1.SelectedIndex].id);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
