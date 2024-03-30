using System;
using System.Collections.Generic;
using ProjectCS.model;
using ProjectCS.repository.DBRepository;
using ProjectCS.repository.interfaces;

namespace ProjectCS.service
{
    public class FlightService
    {
        private readonly IFlightDBRepository _flightDbRepository;

        public FlightService(IFlightDBRepository flightDbRepository)
        {
            _flightDbRepository = flightDbRepository;
        }

        public IEnumerable<Flight> findAllAvailable()
        {
            return _flightDbRepository.findAllAvailable();
        }

        public IEnumerable<Flight> findByDestinationAndDate(string destination, DateTime dateTime)
        {
            return _flightDbRepository.findByDestinationAndDate(destination, dateTime);
        }
    }
}