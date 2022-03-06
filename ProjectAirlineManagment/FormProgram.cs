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
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #region SubMenuButtons
        private void buttonClient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormClients());
        }
        private void buttonTicket_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTickets());
        }

        private void buttonFlight_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormFlight());
        }

        private void buttonPilot_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPilot());
        }
#endregion
    }
}
