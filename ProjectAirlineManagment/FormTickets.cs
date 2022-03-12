using Business.ModelsBusiness;
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

        private void ClearTextBoxes()
        {
            textBoxPrice.Text = "0";
            checkedListBoxSeat.Text = "";
            radioButtonOneWay.Checked = true;
            radioButtonRoundTrip.Checked = false;
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal price = 0;
            decimal.TryParse(textBoxPrice.Text, out price);
            string seat = checkedListBoxSeat.Text;;

            Ticket ticket = new Ticket();
            ticket.Price = price;
            ticket.Seat = seat;
            ticket.IsOneWayTicket = false;
            if (radioButtonOneWay.Checked)
            {
                ticket.IsOneWayTicket = true;
            }
            else
            {
                ticket.IsOneWayTicket = false;
            }

            ticketBusiness.AddTicket(ticket);
            UpdateGrid();
            ClearTextBoxes();
        }
    }
}
