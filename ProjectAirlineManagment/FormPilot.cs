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
    public partial class FormPilotAge : Form
    {
        private PilotBusiness pilotBusiness;
        private int editId;

        private void ClearTextBoxes()
        {
            textBoxPilotName.Text = "";
            textBoxPilotAge.Text = "";
            textBoxPilotPhoneNum.Text = "";
            radioButtonChiefPilot.Checked = true;
            radioButtonAssistantPilot.Checked = false;

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
            }
            else
            {
                buttonPilotSave.Visible = true;
                buttonPilotUpdate.Visible = false;
            }
        }

        private Pilot GetEditedPilot()
        {
            string name = textBoxPilotName.Text;
            int age = 0;
            int.TryParse(textBoxPilotAge.Text, out age);
            string phoneNumber = textBoxPilotPhoneNum.Text; ;

            Pilot pilot = new Pilot();
            pilot.Id = editId;
            pilot.Name = name;
            pilot.Age = age;
            pilot.PhoneNumber = phoneNumber;
            if (radioButtonChiefPilot.Checked)
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
            string name = textBoxPilotName.Text; 
            int age = 0;
            int.TryParse(textBoxPilotAge.Text, out age);
            string phoneNumber = textBoxPilotPhoneNum.Text; ;

            Pilot pilot = new Pilot();
            pilot.Name = name;
            pilot.Age = age;
            pilot.PhoneNumber = phoneNumber;
            if (radioButtonChiefPilot.Checked)
            {
                pilot.TypePilot = "Chief Pilot";
            }
            else
            {
                pilot.TypePilot = "Assistant Pilot";
            }

            pilotBusiness.AddPilot(pilot);
            UpdateGrid();
            ClearTextBoxes();
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
        }

        private void DisabeSelect()
        {
            dataGridViewPilot.Enabled = false;
        }

        private void buttonPilotSave_Click(object sender, EventArgs e)
        {
            Pilot pilot = GetEditedPilot();
            pilotBusiness.UpdatePilot(pilot);
            UpdateGrid();
            ToggleSaveUpdate();
            ResetSelect();
            ClearTextBoxes();
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
    }
}
