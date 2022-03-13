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
    public partial class FormFlight : Form
    {
        private FlightBusiness flightBusiness;
        private int editId;

        private void ClearTextBoxes()
        {
            dateTimePickerDate.Text = default;
            comboBoxDestination.Text = "";
            textBoxNumberOfSeats.Text = "";
        }

        private void UpdateGrid()
        {
            dataGridViewFlights.DataSource = flightBusiness.FlightGetAll();
            dataGridViewFlights.ReadOnly = true;
            dataGridViewFlights.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public FormFlight()
        {
            InitializeComponent();
            flightBusiness = new FlightBusiness();
        }
        private void FormFlight_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearTextBoxes();
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonFlightInsert_Click(object sender, EventArgs e)
        {
            DateTime date = default;
            DateTime.TryParse(dateTimePickerDate.Text, out date);
            string destination = comboBoxDestination.Text;
            int numOfSeats = 0;
            int.TryParse(textBoxNumberOfSeats.Text, out numOfSeats);

            Flight flight = new Flight();
            flight.Date = date;
            flight.Destination = destination;
            flight.SeatCount = numOfSeats;

            int n = flightBusiness.AddFlight(flight);
            if (n == 1)
            {
                MessageBox.Show("This flight has already been introduced", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UpdateGrid();
                ClearTextBoxes();
            }

            flightBusiness.AddFlight(flight);
            UpdateGrid();
            ClearTextBoxes();
        }
        private void UpdateTextBoxes(int id)
        {
            Flight flight = flightBusiness.GetFlight(id);
            dateTimePickerDate.Text = flight.Date.ToString();
            comboBoxDestination.Text = flight.Destination;
            textBoxNumberOfSeats.Text = flight.SeatCount.ToString();
        }

        private void buttonFlightSave_Click(object sender, EventArgs e)
        {
            Flight flight = GetEditedFlight();
            flightBusiness.UpdateFlight(flight);
            UpdateGrid();
            ToggleSaveUpdate();
            ResetSelect();
            ClearTextBoxes();
        }
        private void ResetSelect()
        {
            dataGridViewFlights.Enabled = true;
            dataGridViewFlights.ClearSelection();
        }
        private Flight GetEditedFlight()
        {
            DateTime date = default;
            DateTime.TryParse(dateTimePickerDate.Text, out date);
            string destination = comboBoxDestination.Text;
            int numOfSeats = 0;
            int.TryParse(textBoxNumberOfSeats.Text, out numOfSeats);


            Flight flight = new Flight();
            flight.Id = editId;
            flight.Date = date;
            flight.Destination = destination;
            flight.SeatCount = numOfSeats;

            return flight;
        }
        private void ToggleSaveUpdate()
        {
            if (buttonFlightSave.Visible)
            {
                buttonFlightSave.Visible = false;
                buttonFlightUpdate.Visible = true;
            }
            else
            {
                buttonFlightSave.Visible = true;
                buttonFlightUpdate.Visible = false;
            }
        }
        private void DisabeSelect()
        {
            dataGridViewFlights.Enabled = false;
        }

        private void buttonFlightUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewFlights.SelectedRows.Count > 0)
            {
                var item = dataGridViewFlights.SelectedRows[0].Cells;
                int id = (int)item[0].Value;
                editId = id;
                UpdateTextBoxes(id);
                ToggleSaveUpdate();
                DisabeSelect();
            }
        }

        private void buttonFlightDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewFlights.SelectedRows.Count > 0)
            {
                var item = dataGridViewFlights.SelectedRows[0].Cells;
                int id = (int)item[0].Value;
                flightBusiness.DeleteFlight(id);
                UpdateGrid();
                ResetSelect();

            }
        }
    }
}
