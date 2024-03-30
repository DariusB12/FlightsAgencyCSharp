using ProjectCS.repository.interfaces;

namespace ProjectCS.service
{
    public class TicketService
    {
        private readonly ITicketDBRepository _ticketDbRepository;

        public TicketService(ITicketDBRepository ticketDbRepository)
        {
            _ticketDbRepository = ticketDbRepository;
        }
    }
}