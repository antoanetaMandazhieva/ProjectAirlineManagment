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
            comboBoxSeat.Text = "";
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
            string seat = comboBoxSeat.Text;;

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

        private void UpdateTextBoxes(int id)
        {
            Ticket ticket = ticketBusiness.GetTicket(id);
            textBoxPrice.Text = ticket.Price.ToString();
            comboBoxSeat.Text = ticket.Seat;
            if (radioButtonOneWay.Checked)
            {
                ticket.IsOneWayTicket = true;
            }
            else
            {
                ticket.IsOneWayTicket = false;
            }
        }

        private void FormTickets_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearTextBoxes();
        }

        private void buttonTicketSave_Click(object sender, EventArgs e)
        {
            Ticket ticket = GetEditedTicket();
            ticketBusiness.UpdateTicket(ticket);
            UpdateGrid();
            ToggleSaveUpdate();
            ResetSelect();
            ClearTextBoxes();
        }

        private Ticket GetEditedTicket()
        {
            decimal price = 0;
            decimal.TryParse(textBoxPrice.Text, out price);
            string seat = comboBoxSeat.Text;

            Ticket ticket = new Ticket();
            ticket.Id = editId;
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

            return ticket;
        }

        private void ToggleSaveUpdate()
        {
            if (buttonTicketSave.Visible)
            {
                buttonTicketSave.Visible = false;
                buttonTicketUpdate.Visible = true;
            }
            else
            {
                buttonTicketSave.Visible = true;
                buttonTicketUpdate.Visible = false;
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
    }
}
