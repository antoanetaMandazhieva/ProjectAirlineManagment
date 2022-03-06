namespace ProjectAirlineManagment
{
    partial class FormProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawer = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.panelTopMenuSmall = new System.Windows.Forms.Panel();
            this.panellogo = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panelMenuSubmenu = new System.Windows.Forms.Panel();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.buttonFlight = new System.Windows.Forms.Button();
            this.buttonPilot = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.drawer.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelTopMenu.SuspendLayout();
            this.panelMenuSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawer
            // 
            this.drawer.Controls.Add(this.panelMenu);
            this.drawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.drawer.Location = new System.Drawing.Point(0, 0);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(178, 430);
            this.drawer.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Silver;
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.panelMenuSubmenu);
            this.panelMenu.Controls.Add(this.buttonMenu);
            this.panelMenu.Controls.Add(this.panellogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(178, 430);
            this.panelMenu.TabIndex = 1;
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(150)))), ((int)(((byte)(165)))));
            this.panelTopMenu.Controls.Add(this.panelChildForm);
            this.panelTopMenu.Controls.Add(this.panelTopMenuSmall);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(178, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(649, 62);
            this.panelTopMenu.TabIndex = 1;
            // 
            // panelTopMenuSmall
            // 
            this.panelTopMenuSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
            this.panelTopMenuSmall.Location = new System.Drawing.Point(1, 2);
            this.panelTopMenuSmall.Name = "panelTopMenuSmall";
            this.panelTopMenuSmall.Size = new System.Drawing.Size(648, 28);
            this.panelTopMenuSmall.TabIndex = 0;
            // 
            // panellogo
            // 
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(178, 97);
            this.panellogo.TabIndex = 2;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.DarkGray;
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Location = new System.Drawing.Point(0, 97);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(178, 40);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // panelMenuSubmenu
            // 
            this.panelMenuSubmenu.BackColor = System.Drawing.Color.LightGray;
            this.panelMenuSubmenu.Controls.Add(this.buttonPilot);
            this.panelMenuSubmenu.Controls.Add(this.buttonFlight);
            this.panelMenuSubmenu.Controls.Add(this.buttonTicket);
            this.panelMenuSubmenu.Controls.Add(this.buttonClient);
            this.panelMenuSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuSubmenu.Location = new System.Drawing.Point(0, 137);
            this.panelMenuSubmenu.Name = "panelMenuSubmenu";
            this.panelMenuSubmenu.Size = new System.Drawing.Size(178, 161);
            this.panelMenuSubmenu.TabIndex = 2;
            // 
            // buttonClient
            // 
            this.buttonClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClient.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Location = new System.Drawing.Point(0, 0);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonClient.Size = new System.Drawing.Size(178, 40);
            this.buttonClient.TabIndex = 0;
            this.buttonClient.Text = "Clients";
            this.buttonClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonTicket
            // 
            this.buttonTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTicket.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicket.Location = new System.Drawing.Point(0, 40);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonTicket.Size = new System.Drawing.Size(178, 40);
            this.buttonTicket.TabIndex = 1;
            this.buttonTicket.Text = "Tickets";
            this.buttonTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTicket.UseVisualStyleBackColor = true;
            // 
            // buttonFlight
            // 
            this.buttonFlight.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFlight.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlight.Location = new System.Drawing.Point(0, 80);
            this.buttonFlight.Name = "buttonFlight";
            this.buttonFlight.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonFlight.Size = new System.Drawing.Size(178, 40);
            this.buttonFlight.TabIndex = 2;
            this.buttonFlight.Text = "Flights";
            this.buttonFlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFlight.UseVisualStyleBackColor = true;
            // 
            // buttonPilot
            // 
            this.buttonPilot.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPilot.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonPilot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPilot.Location = new System.Drawing.Point(0, 120);
            this.buttonPilot.Name = "buttonPilot";
            this.buttonPilot.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonPilot.Size = new System.Drawing.Size(178, 40);
            this.buttonPilot.TabIndex = 3;
            this.buttonPilot.Text = "Pilots";
            this.buttonPilot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPilot.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(649, 62);
            this.panelChildForm.TabIndex = 1;
            // 
            // FormProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(827, 430);
            this.Controls.Add(this.panelTopMenu);
            this.Controls.Add(this.drawer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProgram";
            this.drawer.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelTopMenu.ResumeLayout(false);
            this.panelMenuSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawer;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.Panel panelTopMenuSmall;
        private System.Windows.Forms.Panel panelMenuSubmenu;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonPilot;
        private System.Windows.Forms.Button buttonFlight;
        private System.Windows.Forms.Button buttonTicket;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelChildForm;
    }
}