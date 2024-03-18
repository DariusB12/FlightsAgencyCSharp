using System.Collections.Generic;
using ProjectCS.model;
using ProjectCS.repository.interfaces;

namespace ProjectCS.repository.DBRepository
{
    public class TicketDBRepository : ITicketDBRepository
    {
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
            throw new System.NotImplementedException();
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