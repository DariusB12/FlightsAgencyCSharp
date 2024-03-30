using System;
using System.Collections.Generic;
using System.Configuration;
using System.Runtime.CompilerServices;
using ProjectCS.repository.DBRepository;
using ProjectCS.repository.interfaces;
using ProjectCS.service;

namespace ProjectCS.utils.factory
{
    public class Factory
    {
        private static ContainerUtils _containerUtils;

        private Factory()
        {
        }

        public static ContainerUtils GetContainer()
        {
            IDictionary<String,String> prop= new Dictionary<string, string>();
            prop.Add("connectionString",GetConnectionStringByName("tasksDB"));
            // Console.WriteLine(prop["connectionString"]);

            IUserDBRepository userDbRepository = new UserDBRepository(prop);
            UserService userService = new UserService(userDbRepository);
            IFlightDBRepository flightDbRepository = new FlightDBRepository(prop);
            FlightService flightService = new FlightService(flightDbRepository);
            ITicketDBRepository ticketDbRepository = new TicketDBRepository(prop);
            TicketService ticketService = new TicketService(ticketDbRepository);
            if (_containerUtils == null)
            {
                _containerUtils = new ContainerUtils(userService,flightService,ticketService);
            }

            return _containerUtils;
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