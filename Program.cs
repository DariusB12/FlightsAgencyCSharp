using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using log4net.Util;
using ProjectCS.model;
using ProjectCS.repository;
using ProjectCS.repository.DBRepository;
using ProjectCS.repository.interfaces;

namespace ProjectCS
{
    /// <summary>
    ///
    /// REPO TICKET
    /// CONFIGURARE LOG4NET
    /// PUSH PE GITHUB
    /// FAC BRANCHMERGE LA JAVA
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Helllloooo");
            IDictionary<String,String> prop= new Dictionary<string, string>();
            prop.Add("connectionString",GetConnectionStringByName("tasksDB"));
            Console.WriteLine(prop["connectionString"]);
            IUserDBRepository userRepo = new UserDBRepository(prop);
            // User user = userRepo.findByusernameAndPassword("mm", "1234");
            // Console.WriteLine(user);
            
            IFlightDBRepository flightRepo = new FlightDBRepository(prop);
            // IEnumerable<Flight> all = flightRepo.findByDestinationAndDate("Bucurestii", DateTime.Parse("2025-05-17"));
            IEnumerable<Flight> all = flightRepo.findAllAvailable();
            
            foreach (var flight in all)
            {
                Console.WriteLine(flight.Destination + " " + flight.SeatsNo + flight.DepartureDateTime);
            }
        }

        static string GetConnectionStringByName(string name)
        {
            // Assume failure.
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings =ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }
    }
}