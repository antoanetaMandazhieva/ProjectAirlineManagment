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
    public partial class FormClients : Form
    {
        private ClientBusiness clientBusiness;
        private int editId;

        private void ClearTextBoxes()
        {
            textBoxName.Text = "";
            textBoxPhoneNum.Text = "";
            comboBoxNationality.Text = "";
            textBoxPassNum.Text = "";
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
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string phoneNumber = textBoxPhoneNum.Text;
            string nationality = comboBoxNationality.Text;
            string passportNumber = textBoxPassNum.Text;

            Client client = new Client();
            client.Name = name;
            client.PhoneNumber = phoneNumber;
            client.Nationality = nationality;
            client.PassportNumber = passportNumber;

            clientBusiness.AddClient(client);
            UpdateGrid();
            ClearTextBoxes();
        }

        private void UpdateTextBoxes(int id)
        {
            Client client = clientBusiness.GetClient(id);
            textBoxName.Text = client.Name;
            textBoxPhoneNum.Text = client.PhoneNumber;
            comboBoxNationality.Text = client.Nationality;
            textBoxPassNum.Text = client.PassportNumber;
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearTextBoxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ToggleSaveUpdate()
        {
            if (buttonSaveClient.Visible)
            {
                buttonSaveClient.Visible = false;
                buttonUpdateClient.Visible = true;
            }
            else
            {
                buttonSaveClient.Visible = true;
                buttonUpdateClient.Visible = false;
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
    }
}
