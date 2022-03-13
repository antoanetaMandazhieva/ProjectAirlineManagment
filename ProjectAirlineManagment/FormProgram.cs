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

        //private Form activeForm = null;
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
            FormClients client = new FormClients();
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            client.MdiParent = this;
            client.Show();
        }
        private void buttonTicket_Click(object sender, EventArgs e)
        {
            FormTickets ticket = new FormTickets();
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            ticket.MdiParent = this;
            ticket.Show();
        }

        private void buttonFlight_Click(object sender, EventArgs e)
        {
            FormFlight flight = new FormFlight();
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            flight.MdiParent = this;
            flight.Show();
        }

        private void buttonPilot_Click(object sender, EventArgs e)
        {
            FormPilotAge pilot = new FormPilotAge();
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
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
            menuStripMenu.ForeColor = Color.White;
        }
        int mm = 0;
        int mov;
        int movX;
        int movY;
        private void menuStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {

        }

        private void panelClose_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Pen pen = new Pen(Color.Purple);
            z.DrawLine(pen, 7, 7, 19, 19);
            z.DrawLine(pen, 7, 19, 19, 7);
            z.DrawLine(pen, 8, 7, 20, 19);
            z.DrawLine(pen, 8, 19, 20, 7);
        }

        private void panelMax_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Color color = Color.Purple;
            SolidBrush myBrush = new SolidBrush(color);
            Pen pen = new Pen(Color.Purple);
            z.DrawRectangle(pen, 7, 7, 12, 12);
            z.FillRectangle(myBrush, 7, 7, 12, 12);
            z.DrawRectangle(pen, 9, 7, 7, 10);
            z.DrawRectangle(pen, 12, 12, 10, 10);
        }

        private void panelMin_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Color color = Color.Purple;
            SolidBrush myBrush = new SolidBrush(color);
            Pen pen = new Pen(Color.Purple);
            z.DrawRectangle(pen, 7, 16, 12, 4);
            z.FillRectangle(myBrush, 7, 16, 12, 4);
        }

        private void panelMin_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelMax_Click_1(object sender, EventArgs e)
        {
            if (mm == 0)
            {
                WindowState = FormWindowState.Maximized;
                mm = 1;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                mm = 0;
            }
        }

        private void panelClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStripMenu_MouseDown_1(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void menuStripMenu_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void menuStripMenu_MouseUp_1(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void drawer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
