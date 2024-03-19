using System;
using ProjectCS.model;

namespace ProjectCS.validator
{
    public class TicketValidator : IValidator<Ticket>
    {
        public void validate(Ticket entity)
        {
            String errors ="";
            if(entity.NameClient == ""){
                errors+="invalid client name\n";
            }
            if(entity.NoSeats == 0){
                errors += "can't buy 0 tickets\n";
            }
            if(entity.Address == ""){
                errors+="invalid address\n";
            }
            if(entity.Flight.SeatsNo < entity.NoSeats){
                errors += "can't buy more tickets than available in the flight\n";
            }
            if(errors !=""){
                throw new ValidationException(errors);
            }
        }
    }
}