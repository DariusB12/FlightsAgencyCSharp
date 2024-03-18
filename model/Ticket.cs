using System.Collections.Generic;

namespace ProjectCS.model
{
    public class Ticket : HasID<int>
    {

        public Ticket(string nameClient, List<string> nameTourists, string address, int noSeats, Flight flight)
        {
            this.NameClient = nameClient;
            this.NameTourists = nameTourists;
            this.Address = address;
            this.NoSeats = noSeats;
            this.Flight = flight;
        }

        public Flight Flight { get; set; }

        public int NoSeats { get; set; }

        public string Address { get; set; }

        public List<string> NameTourists { get; set; }

        public string NameClient { get; set; }


        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}