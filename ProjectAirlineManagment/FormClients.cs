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
    public partial class FormClients : Form
    {
        private ClientBusiness clientBusiness;
        private int editId;
        private AirlineManagmentContext airlineManagmentContext;

        private void ClearTextBoxes()
        {
            textBoxNameClient.Text = "";
            textBoxPhoneNumClient.Text = "";
            comboBoxNationalityClient.Text = "";
            textBoxPassNumClient.Text = "";
        }

        private void UpdateGrid()
        {
            dataGridViewClients.DataSource = clientBusiness.ClientGetAll();
            dataGridViewClients.ReadOnly = true;
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public FormClients()
        {
            InitializeComponent();
            clientBusiness = new ClientBusiness();
            airlineManagmentContext = new AirlineManagmentContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNameClient.Text == "" || textBoxPhoneNumClient.Text == "" || comboBoxNationalityClient.Text == "" || textBoxPassNumClient.Text == "")
            {
                MessageBox.Show("Please, fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = textBoxNameClient.Text;
                string phoneNumber = textBoxPhoneNumClient.Text;
                string nationality = comboBoxNationalityClient.Text;
                string passportNumber = textBoxPassNumClient.Text;

                Client client = new Client(name, phoneNumber, nationality, passportNumber);

                int n = clientBusiness.AddClient(client);
                if (n == 1)
                {
                    MessageBox.Show("This client has already been introduced.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Client client = clientBusiness.GetClient(id);
            textBoxNameClient.Text = client.Name;
            textBoxPhoneNumClient.Text = client.PhoneNumber;
            comboBoxNationalityClient.Text = client.Nationality;
            textBoxPassNumClient.Text = client.PassportNumber;
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearTextBoxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxNameClient.Text == "" || textBoxPhoneNumClient.Text == "" || comboBoxNationalityClient.Text == "" || textBoxPassNumClient.Text == "")
            {
                MessageBox.Show("Please, fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Client client = GetEditedClient();
                if (this.airlineManagmentContext.Clients.Any
                    (x => x.Name == client.Name
                    && x.PassportNumber == client.PassportNumber
                    && x.Nationality == client.Nationality))
                {                    
                    MessageBox.Show("This client has already been introduced.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    clientBusiness.UpdateClient(client);
                    UpdateGrid();
                    ToggleSaveUpdate();
                    ResetSelect();
                    ClearTextBoxes();
                }
            }
        }

        private void ResetSelect()
        {
            dataGridViewClients.Enabled = true;
            dataGridViewClients.ClearSelection();
        }

        private Client GetEditedClient()
        {
            string name = textBoxNameClient.Text;
            string phoneNumber = textBoxPhoneNumClient.Text;
            string nationality = comboBoxNationalityClient.Text;
            string passportNumber = textBoxPassNumClient.Text;

            Client client = new Client(editId, name, phoneNumber, nationality, passportNumber);

            return client;
        }

        private void ToggleSaveUpdate()
        {
            if (buttonSaveClient.Visible)
            {
                buttonSaveClient.Visible = false;
                buttonUpdateClient.Visible = true;
                buttonInsertClient.Visible = true;
            }
            else
            {
                buttonSaveClient.Visible = true;
                buttonUpdateClient.Visible = false;
                buttonInsertClient.Visible = false;
            }
        }

        private void DisabeSelect()
        {
            dataGridViewClients.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count > 0)
            {
                var item = dataGridViewClients.SelectedRows[0].Cells;
                int id = (int)item[0].Value;
                editId = id;
                UpdateTextBoxes(id);
                ToggleSaveUpdate();
                DisabeSelect();
            }
        }

        private void labelNameClient_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNameClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhoneNumClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
