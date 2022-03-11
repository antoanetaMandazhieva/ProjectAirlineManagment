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
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenuSubmenu = new System.Windows.Forms.Panel();
            this.buttonPilot = new System.Windows.Forms.Button();
            this.buttonFlight = new System.Windows.Forms.Button();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelTopMenuSmall = new System.Windows.Forms.Panel();
            this.panelChildForm1 = new System.Windows.Forms.Panel();
            this.drawer.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelMenuSubmenu.SuspendLayout();
            this.panelTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawer
            // 
            this.drawer.Controls.Add(this.panelMenu);
            this.drawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.drawer.Location = new System.Drawing.Point(0, 0);
            this.drawer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(237, 572);
            this.drawer.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.panelMenuSubmenu);
            this.panelMenu.Controls.Add(this.buttonMenu);
            this.panelMenu.Controls.Add(this.panellogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(237, 572);
            this.panelMenu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelMenuSubmenu
            // 
            this.panelMenuSubmenu.BackColor = System.Drawing.Color.LightGray;
            this.panelMenuSubmenu.Controls.Add(this.buttonPilot);
            this.panelMenuSubmenu.Controls.Add(this.buttonFlight);
            this.panelMenuSubmenu.Controls.Add(this.buttonTicket);
            this.panelMenuSubmenu.Controls.Add(this.buttonClient);
            this.panelMenuSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuSubmenu.Location = new System.Drawing.Point(0, 168);
            this.panelMenuSubmenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenuSubmenu.Name = "panelMenuSubmenu";
            this.panelMenuSubmenu.Size = new System.Drawing.Size(237, 198);
            this.panelMenuSubmenu.TabIndex = 2;
            // 
            // buttonPilot
            // 
            this.buttonPilot.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPilot.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonPilot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPilot.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPilot.ForeColor = System.Drawing.Color.White;
            this.buttonPilot.Location = new System.Drawing.Point(0, 147);
            this.buttonPilot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPilot.Name = "buttonPilot";
            this.buttonPilot.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.buttonPilot.Size = new System.Drawing.Size(237, 49);
            this.buttonPilot.TabIndex = 3;
            this.buttonPilot.Text = "Pilots";
            this.buttonPilot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPilot.UseVisualStyleBackColor = true;
            this.buttonPilot.Click += new System.EventHandler(this.buttonPilot_Click);
            // 
            // buttonFlight
            // 
            this.buttonFlight.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFlight.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlight.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlight.ForeColor = System.Drawing.Color.White;
            this.buttonFlight.Location = new System.Drawing.Point(0, 98);
            this.buttonFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFlight.Name = "buttonFlight";
            this.buttonFlight.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.buttonFlight.Size = new System.Drawing.Size(237, 49);
            this.buttonFlight.TabIndex = 2;
            this.buttonFlight.Text = "Flights";
            this.buttonFlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFlight.UseVisualStyleBackColor = true;
            this.buttonFlight.Click += new System.EventHandler(this.buttonFlight_Click);
            // 
            // buttonTicket
            // 
            this.buttonTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTicket.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicket.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicket.ForeColor = System.Drawing.Color.White;
            this.buttonTicket.Location = new System.Drawing.Point(0, 49);
            this.buttonTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.buttonTicket.Size = new System.Drawing.Size(237, 49);
            this.buttonTicket.TabIndex = 1;
            this.buttonTicket.Text = "Tickets";
            this.buttonTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTicket.UseVisualStyleBackColor = true;
            this.buttonTicket.Click += new System.EventHandler(this.buttonTicket_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClient.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.ForeColor = System.Drawing.Color.White;
            this.buttonClient.Location = new System.Drawing.Point(0, 0);
            this.buttonClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.buttonClient.Size = new System.Drawing.Size(237, 49);
            this.buttonClient.TabIndex = 0;
            this.buttonClient.Text = "Clients";
            this.buttonClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.DarkGray;
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMenu.Location = new System.Drawing.Point(0, 119);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(237, 49);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(237, 119);
            this.panellogo.TabIndex = 2;
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(150)))), ((int)(((byte)(165)))));
            this.panelTopMenu.Controls.Add(this.panelChildForm);
            this.panelTopMenu.Controls.Add(this.panelTopMenuSmall);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(237, 0);
            this.panelTopMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(880, 76);
            this.panelTopMenu.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(880, 76);
            this.panelChildForm.TabIndex = 1;
            // 
            // panelTopMenuSmall
            // 
            this.panelTopMenuSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
            this.panelTopMenuSmall.Location = new System.Drawing.Point(1, 2);
            this.panelTopMenuSmall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTopMenuSmall.Name = "panelTopMenuSmall";
            this.panelTopMenuSmall.Size = new System.Drawing.Size(864, 34);
            this.panelTopMenuSmall.TabIndex = 0;
            // 
            // panelChildForm1
            // 
            this.panelChildForm1.Location = new System.Drawing.Point(237, 70);
            this.panelChildForm1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChildForm1.Name = "panelChildForm1";
            this.panelChildForm1.Size = new System.Drawing.Size(880, 502);
            this.panelChildForm1.TabIndex = 2;
            // 
            // FormProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1117, 572);
            this.Controls.Add(this.panelChildForm1);
            this.Controls.Add(this.panelTopMenu);
            this.Controls.Add(this.drawer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProgram";
            this.drawer.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuSubmenu.ResumeLayout(false);
            this.panelTopMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelChildForm1;
    }
}