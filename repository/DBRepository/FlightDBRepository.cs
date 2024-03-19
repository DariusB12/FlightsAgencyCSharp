using System;
using System.Collections.Generic;
using System.Data;
using log4net;
using ProjectCS.model;
using ProjectCS.repository.interfaces;

namespace ProjectCS.repository.DBRepository
{
    public class FlightDBRepository : IFlightDBRepository
    {
        private static readonly ILog log = LogManager.GetLogger("FlightDBRepository");
        private IDictionary<String, String> prop;

        public FlightDBRepository(IDictionary<string, string> prop)
        {
            log.Info("Initializing the FlightDBRepository with properties");
            this.prop = prop;
        }
        
        public IEnumerable<Flight> findByDestinationAndDate(string destination, DateTime dateTime)
        {
            log.InfoFormat("Entering findByDestinationAndDate with destination: {0} date: {1}", destination,dateTime.ToString("yyyy-MM-dd"));
            IDbConnection con = DBUtils.getConnection(prop);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "SELECT id,destination,date,time,airport,no_seats FROM flights" +
                                   " WHERE destination = @destination AND date = @date";
                IDbDataParameter paramDestination = comm.CreateParameter();
                IDbDataParameter paramDate = comm.CreateParameter();
                paramDestination.ParameterName = "@destination";
                paramDate.ParameterName = "@date";
                paramDestination.Value = destination;
                paramDate.Value = dateTime.ToString("yyyy-MM-dd");
                comm.Parameters.Add(paramDestination);
                comm.Parameters.Add(paramDate);

                using (var dataR = comm.ExecuteReader())
                {
                    IList<Flight> filteredFlights = new List<Flight>();
                    while (dataR.Read())
                    {
                        int id = dataR.GetInt32(0);
                        string destination1 = dataR.GetString(1);
                        string date = dataR.GetString(2);
                        string time = dataR.GetString(3);
                        string airport = dataR.GetString(4);
                        int noSeats = dataR.GetInt32(5);

                        string dateTimeString = date + " " + time;
                        DateTime dateTime1 = DateTime.Parse(dateTimeString);
                        Flight flight = new Flight(destination1, dateTime1, airport, noSeats);
                        flight.Id = id;
                        filteredFlights.Add(flight);
                    }

                    log.InfoFormat("Exiting findByDestinationAndDate with flights: {0}", filteredFlights);
                    return filteredFlights;
                }
            }
            log.Info("Exiting findByDestinationAndDate with null");
            return null;
        }

        public IEnumerable<Flight> findAllAvailable()
        {
            log.Info("Entering findAllAvailable");
            IDbConnection con = DBUtils.getConnection(prop);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "SELECT id,destination,date,time,airport,no_seats FROM flights" +
                                   " WHERE no_seats > 0";

                using (var dataR = comm.ExecuteReader())
                {
                    IList<Flight> filteredFlights = new List<Flight>();
                    while (dataR.Read())
                    {
                        int id = dataR.GetInt32(0);
                        string destination1 = dataR.GetString(1);
                        string date = dataR.GetString(2);
                        string time = dataR.GetString(3);
                        string airport = dataR.GetString(4);
                        int noSeats = dataR.GetInt32(5);

                        string dateTimeString = date + " " + time;
                        DateTime dateTime1 = DateTime.Parse(dateTimeString);
                        Flight flight = new Flight(destination1, dateTime1, airport, noSeats);
                        flight.Id = id;
                        filteredFlights.Add(flight);
                    }

                    log.InfoFormat("Exiting findAllAvailable with flights: {0}", filteredFlights);
                    return filteredFlights;
                }
            }
            log.Info("Exiting findAllAvailable with null");
            return null;        
        }

        public Flight findOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Flight> findAll()
        {
            throw new NotImplementedException();
        }

        public void save(Flight entity)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void update(Flight entity)
        {
            throw new NotImplementedException();
        }

        
    }
}
