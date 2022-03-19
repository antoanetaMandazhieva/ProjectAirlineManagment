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
    public partial class FormFirstPage : Form
    {
        public FormFirstPage()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        int mm = 0;
        int mov;
        int movX;
        int movY;
        private void FormFirstPage_Load(object sender, EventArgs e)
        {

        }

        private void menuStripMenu_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void menuStripMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void menuStripMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelMin_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Color color = Color.White;
            SolidBrush myBrush = new SolidBrush(color);
            Pen pen = new Pen(Color.White);
            z.DrawRectangle(pen, 7, 16, 12, 4);
            z.FillRectangle(myBrush, 7, 16, 12, 4);
        }

        private void panelMax_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Color color = Color.White;
            SolidBrush myBrush = new SolidBrush(color);
            Pen pen = new Pen(Color.White);
            z.DrawRectangle(pen, 7, 7, 12, 12);
            z.FillRectangle(myBrush, 7, 7, 12, 12);
            z.DrawRectangle(pen, 9, 7, 7, 10);
            z.DrawRectangle(pen, 12, 12, 10, 10);
        }

        private void panelClose_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Pen pen = new Pen(Color.White);
            z.DrawLine(pen, 7, 7, 19, 19);
            z.DrawLine(pen, 7, 19, 19, 7);
            z.DrawLine(pen, 8, 7, 20, 19);
            z.DrawLine(pen, 8, 19, 20, 7);
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelMax_Click(object sender, EventArgs e)
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

        private void panelMin_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormClients client = new FormClients();
            //foreach (var item in this.MdiChildren)
            //{
            //    item.Close();
            //}
            //client.MdiParent = this;
            //client.BringToFront();
            //client.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FormFlight flight = new FormFlight();
            //foreach (var item in this.MdiChildren)
            //{
            //    item.Close();
            //}
            //flight.MdiParent = this;
            //flight.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //FormTickets ticket = new FormTickets();
            //foreach (var item in this.MdiChildren)
            //{
            //    item.Close();
            //}
            //ticket.MdiParent = this;
            //ticket.Show();
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
        private void buttonHome_Click(object sender, EventArgs e)
        {
            FormAboutUs aboutUs = new FormAboutUs();
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            aboutUs.MdiParent = this;
            aboutUs.BringToFront();
            aboutUs.Show();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMenuSubmenu);
        }

        private void buttonPilots_Click(object sender, EventArgs e)
        {
        //    FormPilotAge pilot = new FormPilotAge();
        //    foreach (var item in this.MdiChildren)
        //    {
        //        item.Close();
        //    }
        //    pilot.MdiParent = this;
        //    pilot.Show();
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonClients_Click(object sender, EventArgs e)
        {
            FormClients client = new FormClients();
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            client.MdiParent = this;
            client.BringToFront();
            client.Show();
        }

        private void iconButtonFlights_Click(object sender, EventArgs e)
        {
            FormFlight flight = new FormFlight();
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            flight.MdiParent = this;
            flight.Show();
        }

        private void iconButtonTickets_Click(object sender, EventArgs e)
        {
            FormTickets ticket = new FormTickets();
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            ticket.MdiParent = this;
            ticket.Show();
        }

        private void iconButtonPilots_Click(object sender, EventArgs e)
        {
            FormPilotAge pilot = new FormPilotAge();
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            pilot.MdiParent = this;
            pilot.Show();
        }
    }
}
