using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityUpDesktop
{
    class Event
    {
        public int id;
        public string ownerId;
        public int status;
        public string name;
        public string description;
        public string city;
        public int rank;
        public string photo;
        public Event()
        { }
        public Event(int id, string ownerId, int status, string name, string description, string city, int rank, string photo)
        {
            this.id = id;
            this.ownerId = ownerId;
            this.status = status;
            this.name = name;
            this.description = description;
            this.city = city;
            this.rank = rank;
            this.photo = photo;
        }
        public void SendData()
        {
            SQLConnect sqlConnect = new SQLConnect();
            //sqlConnect.AddEvent(.....);

        }
    }
}
