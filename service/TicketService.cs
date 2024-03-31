using System.Collections.Generic;
using ProjectCS.exception;
using ProjectCS.model;
using ProjectCS.repository.interfaces;
using ProjectCS.utils.observer;

namespace ProjectCS.service
{
    public class TicketService : Observable
    {
        private List<Observer> allObservers;
        private readonly ITicketDBRepository _ticketDbRepository;

        public TicketService(ITicketDBRepository ticketDbRepository)
        {
            _ticketDbRepository = ticketDbRepository;
            allObservers = new List<Observer>();
        }

        public void buyTicket(Ticket ticket)
        {
            Ticket ticketResult = _ticketDbRepository.save(ticket);
            if (ticketResult == null)
            {
                throw new ServiceException("can't buy more tickets than available in the flight\n");
            }
            notifyAllObserver();
        }

        public void registerObserver(Observer o)
        {
            allObservers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            allObservers.Remove(o);
        }

        public void notifyAllObserver()
        {
            allObservers.ForEach(observer => {observer.update();});
        }
    }
}