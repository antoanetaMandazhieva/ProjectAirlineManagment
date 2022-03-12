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
    public partial class FormProgram : Form
    {
        public FormProgram()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            panelMenuSubmenu.Visible = false;           
        }
        private void HideSubMenu()
        {
            if (panelMenuSubmenu.Visible)
            {
                panelMenuSubmenu.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMenuSubmenu);
        }

        private Form activeForm = null;
        //private void OpenChildForm(Form childForm)
        //{
        //    if (activeForm != null)
        //    {
        //        activeForm.Close();
        //    }
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    panelChildForm.Controls.Add(childForm);
        //    panelChildForm.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}
        #region SubMenuButtons
        private void buttonClient_Click(object sender, EventArgs e)
        {
            FormClients clients = new FormClients();
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            clients.MdiParent = this;
            clients.Show();
        }
        private void buttonTicket_Click(object sender, EventArgs e)
        {
            FormTickets tickets = new FormTickets();
            tickets.MdiParent = this;
            tickets.Show();
        }

        private void buttonFlight_Click(object sender, EventArgs e)
        {
            FormFlight flight = new FormFlight();
            flight.MdiParent = this;
            flight.Show();
        }

        private void buttonPilot_Click(object sender, EventArgs e)
        {
            FormPilot pilot = new FormPilot();
            pilot.MdiParent = this;
            pilot.Show();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panelChildForm1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormProgram_Load(object sender, EventArgs e)
        {

        }
    }
}
