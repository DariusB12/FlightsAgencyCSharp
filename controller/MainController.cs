using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ProjectCS.exception;
using ProjectCS.model;
using ProjectCS.repository.interfaces;
using ProjectCS.service;
using ProjectCS.utils.factory;
using ProjectCS.utils.observer;
using Message = ProjectCS.exception.Message;

namespace WindowsFormsApplication1
{
    public partial class MainController : Form, Observer
    {
        private readonly ContainerUtils _containerUtils;
        private readonly FlightService _flightService;
        private readonly TicketService _ticketService;
        private readonly User _user;
        public MainController(ContainerUtils containerUtils, User user)
        {
            _containerUtils = containerUtils;
            _user = user;
            _flightService = containerUtils.FlightService;
            _ticketService = containerUtils.TicketService;
            
            _ticketService.registerObserver(this);
            
            InitializeComponent();
            initializeListViewAllFlights();
        }

        private void initializeListViewAllFlights()
        {
            listViewAllFlights.Clear();
            
            IEnumerable<Flight> allFlights = _flightService.findAllAvailable();
            foreach (Flight flight in allFlights)
            {
                // Create a ListViewItem with the display text
                ListViewItem listViewItem = new ListViewItem(flight.ToString());

                // Set the Tag property of the ListViewItem to store the ID
                listViewItem.Tag = flight.Id;
                listViewAllFlights.Items.Add(listViewItem);
            }
        }

        public void initializeListViewSearchedFlights()
        {
            listViewSearchedFlights.Clear();
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
                // Create a ListViewItem with the display text
                ListViewItem listViewItem = new ListViewItem(flight.ToString());

                // Set the Tag property of the ListViewItem to store the ID
                listViewItem.Tag = flight.Id;
                listViewSearchedFlights.Items.Add(listViewItem);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            initializeListViewSearchedFlights();
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            //get the information about the ticket
            string clientName = textBoxClientName.Text;
            string clientAddress = textBoxClientAddress.Text;
            int noOfSeats = (int)numericUpDownNoOfSeats.Value;
            List<string> touristNames = new List<string>();
            foreach (string name in listBoxTouristNames.Items)
            {
                touristNames.Add(name);
            }

            if (String.IsNullOrEmpty(clientAddress))
            {
                Message.MessageError("address is required");
                return;
            }
            if (String.IsNullOrEmpty(clientName))
            {
                Message.MessageError("client name is required");
                return;
            }
            //get the selected flight
            Flight flight = getSelectedFlight();
            if (flight == null)
            {
                Message.MessageError("no flight selected");
                return;
            }
            Ticket ticket = new Ticket(clientName, touristNames, clientAddress, noOfSeats, flight);
            try
            {
                _ticketService.buyTicket(ticket);
                Message.MessageInfo("Ticket bought with success");
            }
            catch (ServiceException ex)
            { Message.MessageError(ex.Message); }
            catch (ValidationException ex)
            { Message.MessageError(ex.Message); }
        }

        private Flight getSelectedFlight()
        {
            string flightString = textBoxSelectedFlight.Text;
            if (flightString == null)
            {
                return null;
            }

            string[] flightParsed = flightString.Split(',');
            string destination = flightParsed[0].Substring(13);
            string departureTime = flightParsed[1].Substring(15);
            DateTime dateTime = DateTime.Parse(departureTime);
            string airport = flightParsed[2].Substring(9);
            string seatsNo = flightParsed[3].Substring(9);
            int noOfSeats = int.Parse(seatsNo);
            int id = (int)textBoxSelectedFlight.Tag;
            
            Flight flight = new Flight(destination, dateTime, airport, noOfSeats);
            flight.Id = id;
            
            return flight;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxTouristNames.Items.Remove(listBoxTouristNames.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameTourist = textBoxTouristNames.Text;
            if (String.IsNullOrEmpty(nameTourist))
            {
                Message.MessageError("No tourist name introduced");
                return;
            }
            listBoxTouristNames.Items.Add(nameTourist);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxTouristNames.Items.Clear();
        }

        private void listViewAllFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSelectedFlight.Clear();
            var selectedItems = listViewAllFlights.SelectedItems;
            if (selectedItems.Count > 0)
            { 
                textBoxSelectedFlight.Tag = selectedItems[0].Tag;
                textBoxSelectedFlight.Text = selectedItems[0].Text;
            }
        }

        private void listViewSearchedFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSelectedFlight.Clear();
            var selectedItems = listViewSearchedFlights.SelectedItems;
            if (selectedItems.Count > 0)
            {
                textBoxSelectedFlight.Tag = selectedItems[0].Tag;
                textBoxSelectedFlight.Text = selectedItems[0].Text;
            }
        }

        public void update()
        {
            initializeListViewAllFlights();
            if (listViewSearchedFlights.Items.Count > 0)
                initializeListViewSearchedFlights();
        }

    }
}