
using System;
using System.Collections;
using System.Collections.Generic;
using ProjectCS.model;

namespace ProjectCS.repository.interfaces
{
    public interface IFlightDBRepository : ICrudRepository<int,Flight>
    {
        /// <summary>
        /// Search all the available(noSeats>0) flights with given destination and departureDate 
        /// </summary>
        /// <param name="destination">Flight destination</param>
        /// <param name="dateTime">departureDate</param>
        /// <returns>
        ///     A container with all the flights searched
        /// </returns>
        IEnumerable<Flight> findByDestinationAndDate(string destination, DateTime dateTime);

        /// <summary>
        /// Find all the flights with noSeats>0
        /// </summary>
        /// <returns>
        ///  A container with all the flights available
        /// </returns>
        IEnumerable<Flight> findAllAvailable();
    }
}