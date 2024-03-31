using System;
using System.Data.Entity.Core.Common;
using System.Xml;
using ProjectCS.exception;
using ProjectCS.model;

namespace ProjectCS.validator
{
    public class TicketValidator : IValidator<Ticket>
    {
        public void Validate(Ticket entity)
        {
            String errors = "";
            if (entity.NameClient == "")
            {
                errors += "invalid client name\n";
            }

            if (entity.NoSeats == 0)
            {
                errors += "can't buy 0 tickets\n";
            }

            if (entity.Address == "")
            {
                errors += "invalid address\n";
            }

            if (entity.Flight.SeatsNo < entity.NoSeats)
            {
                errors += "can't buy more tickets than available in the flight\n";
            }

            if (entity.NameTourists.Count + 1 != entity.NoSeats)
            {
                errors += "the number of tickets doesn't correspond with the number of people\n";
            }
            if (errors != "")
            {
                throw new ValidationException(errors);
            }
        }
    }
}