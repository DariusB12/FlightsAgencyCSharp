using ProjectCS.service;

namespace ProjectCS.utils.factory
{
    public class ContainerUtils
    {
        private readonly UserService _userService;
        private readonly FlightService _flightService;
        private readonly TicketService _ticketService;

        public ContainerUtils(UserService userService,FlightService flightService,TicketService ticketService)
        {
            _userService = userService;
            _flightService = flightService;
            _ticketService = ticketService;
        }

        public UserService UserService => _userService;
        public FlightService FlightService => _flightService;

        public TicketService TicketService => _ticketService;
    }
}