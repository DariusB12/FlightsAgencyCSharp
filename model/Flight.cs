using System;

namespace ProjectCS.model
{
    public class Flight : HasID<int>
    {

        public Flight(string destination, DateTime departureDateTime, string airport, int seatsNo)
        {
            this.Destination = destination;
            this.DepartureDateTime = departureDateTime;
            this.Airport = airport;
            this.SeatsNo = seatsNo;
        }

        public int SeatsNo { get; set; }

        public string Airport { get; set; }

        public DateTime DepartureDateTime { get; set; }

        public string Destination{ get; set; }

        public override string ToString()
        {
            return "Destination: " + Destination + "  DepartureTime: " + DepartureDateTime +
                   "  Airport: " + Airport + "  SeatsNo: " + SeatsNo;

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