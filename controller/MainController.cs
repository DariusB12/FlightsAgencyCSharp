using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectCS.model;
using ProjectCS.repository.interfaces;
using ProjectCS.service;
using ProjectCS.utils.factory;
using Message = ProjectCS.exception.Message;

namespace WindowsFormsApplication1
{
    public partial class MainController : Form
    {
        private readonly ContainerUtils _containerUtils;
        private readonly FlightService _flightService;
        private readonly User _user;
        public MainController(ContainerUtils containerUtils, User user)
        {
            _containerUtils = containerUtils;
            _user = user;
            _flightService = containerUtils.FlightService;
            InitializeComponent();
            initializeListViewAllFlights();
        }

        private void initializeListViewAllFlights()
        {
            IEnumerable<Flight> allFlights = _flightService.findAllAvailable();
            foreach (Flight flight in allFlights)
            {
                listViewAllFlights.Items.Add(flight.ToString());
            }
        }

        public void initializeListViewSearchedFlights()
        {

            string destination = textBoxDestination.Text;
            DateTime dateTime = dateTimePickerDepartureTime.Value;
            if (String.IsNullOrEmpty(destination))
            {
                Message.MessageError("Invalid destination");
                return;
            }

            if (dateTime.CompareTo(DateTime.Now) < 0)
            {
                Message.MessageError("Date can't be in past");
                return;
            }
            
            List<Flight> allFlights = (List<Flight>)_flightService.findByDestinationAndDate(destination,dateTime);
            if (allFlights.Count == 0)
            {
                Message.MessageInfo("No flights found");
                listViewSearchedFlights.Clear();
                return;
            }
            foreach (Flight flight in allFlights)
            {
                listViewSearchedFlights.Items.Add(flight.ToString());
            }
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            initializeListViewSearchedFlights();
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}