using Business.ModelsBusiness;
using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAirlineManagment
{
    public partial class FormTickets : Form
    {
        private TicketBusiness ticketBusiness;
        private int editId;
        private AirlineManagmentContext airlineManagmentContext;
        private FlightBusiness flightBusiness;
        private ClientBusiness clientBusiness;

        private void ClearTextBoxes()
        {
            textBoxPrice.Text = "0";
            comboBoxSeat.Text = "";
            rjRadioButtonOneWay.Checked = true;
            rjRadioButtonRoundTrip.Checked = false;
        }

        private void UpdateGrid()
        {
            dataGridViewTickets.DataSource = ticketBusiness.TicketGetAll();
            dataGridViewTickets.ReadOnly = true;
            dataGridViewTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public FormTickets()
        {
            InitializeComponent();
            ticketBusiness = new TicketBusiness();
            airlineManagmentContext = new AirlineManagmentContext();
            flightBusiness = new FlightBusiness();
            clientBusiness = new ClientBusiness();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxTicketClientId.Text == "" || textBoxTicketFlightId.Text == "" || textBoxPrice.Text == "0" || comboBoxSeat.Text == "")
            {
                MessageBox.Show("Please, fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int clientId = 0;
                int.TryParse(textBoxTicketClientId.Text, out clientId);
                int flightId = 0;
                int.TryParse(textBoxTicketFlightId.Text, out flightId);
                decimal price = 0;
                decimal.TryParse(textBoxPrice.Text, out price);
                string seat = comboBoxSeat.Text; ;

                Ticket ticket = new Ticket(clientId, flightId, price, seat);
                if (rjRadioButtonOneWay.Checked)
                {
                    ticket.TypeTicket = "A one-way ticket";
                }
                else
                {
                    ticket.TypeTicket = "A round-trip ticket";
                }

                int n = ticketBusiness.AddTicket(ticket);
                if (n == 1)
                {
                    MessageBox.Show("There are no seats available for this flight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (n == 2)
                {
                    MessageBox.Show("This ticket has already been introduced.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (n == 3)
                {
                    MessageBox.Show("This flight does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UpdateGrid();
                    ClearTextBoxes();
                }
            }
        }

        private void UpdateTextBoxes(int id)
        {
            Ticket ticket = ticketBusiness.GetTicket(id);
            textBoxTicketClientId.Text = ticket.ClientId.ToString();
            textBoxTicketFlightId.Text = ticket.FlightId.ToString();
            textBoxPrice.Text = ticket.Price.ToString();
            comboBoxSeat.Text = ticket.Seat;
            if (rjRadioButtonOneWay.Checked)
            {
                ticket.TypeTicket = "A one-way ticket";
            }
            else
            {
                ticket.TypeTicket = "A round-trip ticket";
            }
        }

        private void FormTickets_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearTextBoxes();
        }
        
        private void buttonTicketSave_Click(object sender, EventArgs e)
        {
            if (textBoxTicketClientId.Text == "" || textBoxTicketFlightId.Text == "" || textBoxPrice.Text == "0" || comboBoxSeat.Text == "")
            {
                MessageBox.Show("Please, fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Ticket ticket = GetEditedTicket();
                Flight flight;
                Client client = clientBusiness.GetClient(ticket.ClientId);
                if (this.airlineManagmentContext.Flights.Any(x => x.Id == ticket.FlightId))
                {
                    flight = flightBusiness.GetFlight(ticket.FlightId);
                }
                else
                {
                    MessageBox.Show("This flight does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (flight.SeatCount == flight.TakenSeats && flight.Id == ticket.FlightId)
                {
                    MessageBox.Show("There are no seats available for this flight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (this.airlineManagmentContext.Tickets.Any
                    (x => x.ClientId == client.Id
                    && x.FlightId == flight.Id
                    && x.Seat == ticket.Seat
                    && x.Price == ticket.Price
                    && x.TypeTicket == ticket.TypeTicket))
                {
                    MessageBox.Show("This ticket has already been introduced.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ticketBusiness.UpdateTicket(ticket);
                UpdateGrid();
                ToggleSaveUpdate();
                ResetSelect();
                ClearTextBoxes();
            }
            
        }

        private Ticket GetEditedTicket()
        {
            int clientId = 0;
            int.TryParse(textBoxTicketClientId.Text, out clientId);
            int flightId = 0;
            int.TryParse(textBoxTicketFlightId.Text, out flightId);
            decimal price = 0;
            decimal.TryParse(textBoxPrice.Text, out price);
            string seat = comboBoxSeat.Text;

            Ticket ticket = new Ticket(editId, clientId, flightId, price, seat);

            if (rjRadioButtonOneWay.Checked)
            {
                ticket.TypeTicket = "A one-way ticket";
            }
            else
            {
                ticket.TypeTicket = "A round-trip ticket";
            }

            return ticket;
        }

        private void ToggleSaveUpdate()
        {
            if (buttonTicketSave.Visible)
            {
                buttonTicketSave.Visible = false;
                buttonTicketUpdate.Visible = true;
                buttonTicketsInsert.Visible = true;
                buttonTicketDelete.Visible = true;
            }
            else
            {
                buttonTicketSave.Visible = true;
                buttonTicketUpdate.Visible = false;
                buttonTicketsInsert.Visible = false;
                buttonTicketDelete.Visible = false;
            }
        }

        private void ResetSelect()
        {
            dataGridViewTickets.Enabled = true;
            dataGridViewTickets.ClearSelection();
        }

        private void DisabeSelect()
        {
            dataGridViewTickets.Enabled = false;
        }

        private void buttonTicketUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTickets.SelectedRows.Count > 0)
            {
                var item = dataGridViewTickets.SelectedRows[0].Cells;
                int id = (int)item[0].Value;
                editId = id;
                UpdateTextBoxes(id);
                ToggleSaveUpdate();
                DisabeSelect();
            }
        }

        private void buttonTicketDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTickets.SelectedRows.Count > 0)
            {
                var item = dataGridViewTickets.SelectedRows[0].Cells;
                int id = (int)item[0].Value;
                ticketBusiness.DeleteTicket(id);
                UpdateGrid();
                ResetSelect();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
