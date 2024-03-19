using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Runtime.Remoting;
using log4net;
using ProjectCS.model;
using ProjectCS.repository.interfaces;
using ProjectCS.validator;

namespace ProjectCS.repository.DBRepository
{
    public class TicketDBRepository : ITicketDBRepository
    {
        private static readonly ILog log = LogManager.GetLogger("UserDBRepository");
        private IDictionary<String, String> prop;
        private readonly TicketValidator ticketValidator = new TicketValidator();

        public TicketDBRepository(IDictionary<string, string> prop)
        {
            log.InfoFormat("Initializing TicketDBRepository with properties: {0}",prop);
            this.prop = prop;
        }

        public Ticket findOne(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Ticket> findAll()
        {
            throw new System.NotImplementedException();
        }

        public void save(Ticket entity)
        {
            log.InfoFormat("Save in TicketDBRepository the ticket: {0}",entity);
            log.Info("validate the ticket");
            ticketValidator.validate(entity);
            
            var con = DBUtils.getConnection(prop);
            
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "SELECT no_seats FROM flights" + 
                                   " WHERE id = @id";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = entity.Flight.Id;
                comm.Parameters.Add(paramId);
                //verify the no of seats to be higher/equal with the no of seats of the ticket
                using (var dataR = comm.ExecuteReader())
                {
                    int noSeatsFlight = -1;
                    if (dataR.Read())
                        noSeatsFlight = dataR.GetInt32(0);
                    //Add the ticket only if the noSeats bought is lower/equal with the maximum no of seats available
                    if (noSeatsFlight >= entity.NoSeats)
                    {
                        var comm2 = con.CreateCommand();
                        comm2.CommandText = "INSERT INTO tickets(name_client,address_client,no_seats,id_flight)" +
                                            " VALUES (@name_client,@address,@no_seats,@id_flight)" +
                                            " returning id";
                        var paramNameClient = comm2.CreateParameter();
                        paramNameClient.ParameterName = "@name_client";
                        paramNameClient.Value = entity.NameClient;
                        comm2.Parameters.Add(paramNameClient);
                        
                        var paramAddress = comm2.CreateParameter();
                        paramAddress.ParameterName = "@address";
                        paramAddress.Value = entity.Address;
                        comm2.Parameters.Add(paramAddress);
                        
                        var paramNoSeats = comm2.CreateParameter();
                        paramNoSeats.ParameterName = "@no_seats";
                        paramNoSeats.Value = entity.NoSeats;
                        comm2.Parameters.Add(paramNoSeats);
                        
                        var paramIdFlight = comm2.CreateParameter();
                        paramIdFlight.ParameterName = "@id_flight";
                        paramIdFlight.Value = entity.Flight.Id;
                        comm2.Parameters.Add(paramIdFlight);
                        int generatedKey = Convert.ToInt32(comm2.ExecuteScalar());
                        //insert the tourists
                        var comm3 = con.CreateCommand();
                        comm3.CommandText = "INSERT INTO tourists(tourists_name,id_ticket)" +
                                            " VALUES (@tourists_name,@id_ticket)";
                        
                        var paramIdTicket = comm3.CreateParameter();
                        paramIdTicket.ParameterName = "@id_ticket";
                        paramIdTicket.Value = generatedKey;
                        // Console.WriteLine("generatedKey : " + generatedKey);
                        comm3.Parameters.Add(paramIdTicket);
                        
                        var paramTouristName = comm3.CreateParameter();
                        paramTouristName.ParameterName = "@tourists_name";
                        if(entity.NameTourists != null)
                        {
                            foreach (var entityNameTourist in entity.NameTourists)
                            {
                                paramTouristName.Value = entityNameTourist;
                                comm3.Parameters.Add(paramTouristName);
                                comm3.ExecuteNonQuery();
                            }
                        }
                        //decrease the no of seats available on the flight
                        var comm4 = con.CreateCommand();
                        comm4.CommandText = "UPDATE flights" +
                                            " SET no_seats = @no_seats" +
                                            " WHERE id = @id";
                        var paramFinalNoSeats = comm4.CreateParameter();
                        paramFinalNoSeats.ParameterName = "@no_seats";
                        paramFinalNoSeats.Value = noSeatsFlight - entity.NoSeats;
                        comm4.Parameters.Add(paramFinalNoSeats);
                        
                        var paramIdFlightUpdate = comm4.CreateParameter();
                        paramIdFlightUpdate.ParameterName = "@id";
                        paramIdFlightUpdate.Value = entity.Flight.Id;
                        comm4.Parameters.Add(paramIdFlightUpdate);

                        comm4.ExecuteNonQuery();
                        log.Info("Ticket added with success");
                    }
                    else
                    {
                        log.Info("Too many seats bought");
                        throw new RepositoryException("Too many seats bought\n");
                    }
                }
            }
        }

        public void delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public void update(Ticket entity)
        {
            throw new System.NotImplementedException();
        }
    }
}