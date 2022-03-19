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
    public partial class FormPilotAge : Form
    {
        private PilotBusiness pilotBusiness;
        private int editId;
        private AirlineManagmentContext airlineManagmentContext;

        private void ClearTextBoxes()
        {
            textBoxPilotName.Text = "";
            textBoxPilotAge.Text = "";
            textBoxPilotPhoneNum.Text = "";
            textBoxPilotFlightId.Text = "";
            rjRadioButtonChiefPilot.Checked = true;
            rjRadioButtonAssistantPilot.Checked = false;

        }

        private void UpdateGrid()
        {
            dataGridViewPilot.DataSource = pilotBusiness.PilotGetAll();
            dataGridViewPilot.ReadOnly = true;
            dataGridViewPilot.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public FormPilotAge()
        {
            InitializeComponent();
            pilotBusiness = new PilotBusiness();
            airlineManagmentContext = new AirlineManagmentContext();
        }

        private void buttonPilotUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewPilot.SelectedRows.Count > 0)
            {
                var item = dataGridViewPilot.SelectedRows[0].Cells;
                int id = (int)item[0].Value;
                editId = id;
                UpdateTextBoxes(id);
                ToggleSaveUpdate();
                DisabeSelect();
            }
        }

        private void ResetSelect()
        {
            dataGridViewPilot.Enabled = true;
            dataGridViewPilot.ClearSelection();
        }

        private void ToggleSaveUpdate()
        {
            if (buttonPilotSave.Visible)
            {
                buttonPilotSave.Visible = false;
                buttonPilotUpdate.Visible = true;
                buttonPilotInsert.Visible = true;
                buttonPiloDelete.Visible = true;
            }
            else
            {
                buttonPilotSave.Visible = true;
                buttonPilotUpdate.Visible = false;
                buttonPilotInsert.Visible = false;
                buttonPiloDelete.Visible = false;
            }
        }

        private Pilot GetEditedPilot()
        {
            string name = textBoxPilotName.Text;
            int age = 0;
            int.TryParse(textBoxPilotAge.Text, out age);
            string phoneNumber = textBoxPilotPhoneNum.Text;
            int flightId = 0;
            int.TryParse(textBoxPilotFlightId.Text, out flightId);

            Pilot pilot = new Pilot(editId, name, phoneNumber, age, flightId);
            if (rjRadioButtonChiefPilot.Checked)
            {
                pilot.TypePilot = "Chief Pilot";
            }
            else
            {
                pilot.TypePilot = "Assistant Pilot";
            }

            return pilot;
        }

        private void buttonPilotInsert_Click(object sender, EventArgs e)
        {
            if (textBoxPilotName.Text == "" || textBoxPilotAge.Text == "" || textBoxPilotPhoneNum.Text == "" || textBoxPilotFlightId.Text == "")
            {
                MessageBox.Show("Please, fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = textBoxPilotName.Text;
                int age = 0;
                int.TryParse(textBoxPilotAge.Text, out age);
                string phoneNumber = textBoxPilotPhoneNum.Text; ;
                int flightId = 0;
                int.TryParse(textBoxPilotFlightId.Text, out flightId);

                Pilot pilot = new Pilot(name, phoneNumber, age, flightId);
                if (rjRadioButtonChiefPilot.Checked)
                {
                    pilot.TypePilot = "Chief Pilot";
                }
                else
                {
                    pilot.TypePilot = "Assistant Pilot";
                }

                int n = pilotBusiness.AddPilot(pilot);
                if (n == 1)
                {
                    MessageBox.Show("This pilot has already been introduced.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (n == 2)
                {
                    MessageBox.Show("This flight does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (n == 3)
                {
                    MessageBox.Show("This seat is taken for this flight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UpdateGrid();
                    ClearTextBoxes();
                }
            }

            
        }

        private void FormPilotAge_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearTextBoxes();
        }

        private void UpdateTextBoxes(int id)
        {
            Pilot pilot = pilotBusiness.GetPilot(id);
            textBoxPilotName.Text = pilot.Name;
            textBoxPilotAge.Text = pilot.Age.ToString();
            textBoxPilotPhoneNum.Text = pilot.PhoneNumber;
            textBoxPilotFlightId.Text = pilot.FlightId.ToString();
        }

        private void DisabeSelect()
        {
            dataGridViewPilot.Enabled = false;
        }

        private void buttonPilotSave_Click(object sender, EventArgs e)
        {
            if (textBoxPilotName.Text == "" || textBoxPilotAge.Text == "" || textBoxPilotPhoneNum.Text == "" || textBoxPilotFlightId.Text == "")
            {
                MessageBox.Show("Please, fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Pilot pilot = GetEditedPilot();
                if (!(this.airlineManagmentContext.Flights.Any(x => x.Id == pilot.FlightId)))
                {
                    MessageBox.Show("This flight does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (this.airlineManagmentContext.Pilots.Any
                    (x => x.Name == pilot.Name
                    && x.FlightId == pilot.FlightId
                    && x.PhoneNumber == pilot.PhoneNumber
                    && x.TypePilot == pilot.TypePilot))
                {
                    MessageBox.Show("This pilot has already been introduced.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (this.airlineManagmentContext.Pilots.Any(x => x.TypePilot == pilot.TypePilot && x.FlightId == pilot.FlightId))
                {
                    MessageBox.Show("In this flight has already been introduced that type of pilot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (this.airlineManagmentContext.Pilots.Any(x=>x.TypePilot == pilot.TypePilot && x.FlightId == pilot.FlightId))
                {
                    MessageBox.Show("In this flight there has already been introduced that type of pilot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pilotBusiness.UpdatePilot(pilot);
                    UpdateGrid();
                    ToggleSaveUpdate();
                    ResetSelect();
                    ClearTextBoxes();
                }
            }
            
        }

        private void buttonPiloDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPilot.SelectedRows.Count > 0)
            {
                var item = dataGridViewPilot.SelectedRows[0].Cells;
                int id = (int)item[0].Value;
                pilotBusiness.DeletePilot(id);
                UpdateGrid();
                ResetSelect();
            }
        }

        private void textBoxPilotName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPilotPhoneNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPilotInsert_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void radioButtonChiefPilot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rjRadioButtonChiefPilot_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
