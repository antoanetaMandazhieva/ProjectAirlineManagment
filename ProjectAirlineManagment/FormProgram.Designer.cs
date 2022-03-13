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
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panellogo = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panelMenuSubmenu = new System.Windows.Forms.Panel();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.buttonFlight = new System.Windows.Forms.Button();
            this.buttonPilot = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.drawer = new System.Windows.Forms.Panel();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panelMin = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelMenuSubmenu.SuspendLayout();
            this.drawer.SuspendLayout();
            this.panelTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(6, 7);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Padding = new System.Windows.Forms.Padding(6, 7, 0, 5);
            this.miniToolStrip.Size = new System.Drawing.Size(849, 24);
            this.miniToolStrip.TabIndex = 4;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(38)))), ((int)(((byte)(113)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.panelMenuSubmenu);
            this.panelMenu.Controls.Add(this.buttonMenu);
            this.panelMenu.Controls.Add(this.panellogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(178, 432);
            this.panelMenu.TabIndex = 1;
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(38)))), ((int)(((byte)(113)))));
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(178, 97);
            this.panellogo.TabIndex = 2;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(68)))), ((int)(((byte)(170)))));
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
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
            this.buttonClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(113)))), ((int)(((byte)(214)))));
            this.buttonClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClient.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.ForeColor = System.Drawing.Color.White;
            this.buttonClient.Location = new System.Drawing.Point(0, 0);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonClient.Size = new System.Drawing.Size(178, 40);
            this.buttonClient.TabIndex = 0;
            this.buttonClient.Text = "Clients";
            this.buttonClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonTicket
            // 
            this.buttonTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(113)))), ((int)(((byte)(214)))));
            this.buttonTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTicket.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicket.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicket.ForeColor = System.Drawing.Color.White;
            this.buttonTicket.Location = new System.Drawing.Point(0, 40);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonTicket.Size = new System.Drawing.Size(178, 40);
            this.buttonTicket.TabIndex = 1;
            this.buttonTicket.Text = "Tickets";
            this.buttonTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTicket.UseVisualStyleBackColor = false;
            this.buttonTicket.Click += new System.EventHandler(this.buttonTicket_Click);
            // 
            // buttonFlight
            // 
            this.buttonFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(113)))), ((int)(((byte)(214)))));
            this.buttonFlight.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFlight.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlight.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlight.ForeColor = System.Drawing.Color.White;
            this.buttonFlight.Location = new System.Drawing.Point(0, 80);
            this.buttonFlight.Name = "buttonFlight";
            this.buttonFlight.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonFlight.Size = new System.Drawing.Size(178, 40);
            this.buttonFlight.TabIndex = 2;
            this.buttonFlight.Text = "Flights";
            this.buttonFlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFlight.UseVisualStyleBackColor = false;
            this.buttonFlight.Click += new System.EventHandler(this.buttonFlight_Click);
            // 
            // buttonPilot
            // 
            this.buttonPilot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(113)))), ((int)(((byte)(214)))));
            this.buttonPilot.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPilot.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonPilot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPilot.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPilot.ForeColor = System.Drawing.Color.White;
            this.buttonPilot.Location = new System.Drawing.Point(0, 120);
            this.buttonPilot.Name = "buttonPilot";
            this.buttonPilot.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonPilot.Size = new System.Drawing.Size(178, 40);
            this.buttonPilot.TabIndex = 3;
            this.buttonPilot.Text = "Pilots";
            this.buttonPilot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPilot.UseVisualStyleBackColor = false;
            this.buttonPilot.Click += new System.EventHandler(this.buttonPilot_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(68)))), ((int)(((byte)(170)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // drawer
            // 
            this.drawer.Controls.Add(this.panelMenu);
            this.drawer.Location = new System.Drawing.Point(0, 35);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(178, 432);
            this.drawer.TabIndex = 0;
            this.drawer.Paint += new System.Windows.Forms.PaintEventHandler(this.drawer_Paint);
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.Controls.Add(this.panelClose);
            this.panelTopMenu.Controls.Add(this.menuStripMenu);
            this.panelTopMenu.Controls.Add(this.panelMin);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(849, 35);
            this.panelTopMenu.TabIndex = 2;
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(38)))), ((int)(((byte)(113)))));
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Padding = new System.Windows.Forms.Padding(6, 5, 0, 7);
            this.menuStripMenu.Size = new System.Drawing.Size(849, 24);
            this.menuStripMenu.TabIndex = 0;
            this.menuStripMenu.Text = "menuStrip1";
            this.menuStripMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStripMenu_MouseDown_1);
            this.menuStripMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStripMenu_MouseMove_1);
            this.menuStripMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStripMenu_MouseUp_1);
            // 
            // panelClose
            // 
            this.panelClose.Location = new System.Drawing.Point(819, -1);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(30, 30);
            this.panelClose.TabIndex = 3;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click_1);
            this.panelClose.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClose_Paint_1);
            // 
            // panelMin
            // 
            this.panelMin.Location = new System.Drawing.Point(789, 12);
            this.panelMin.Name = "panelMin";
            this.panelMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelMin.Size = new System.Drawing.Size(30, 30);
            this.panelMin.TabIndex = 1;
            this.panelMin.Click += new System.EventHandler(this.panelMin_Click_1);
            this.panelMin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMin_Paint_1);
            // 
            // FormProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 467);
            this.Controls.Add(this.panelTopMenu);
            this.Controls.Add(this.drawer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.miniToolStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProgram";
            this.Load += new System.EventHandler(this.FormProgram_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuSubmenu.ResumeLayout(false);
            this.drawer.ResumeLayout(false);
            this.panelTopMenu.ResumeLayout(false);
            this.panelTopMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelMenuSubmenu;
        private System.Windows.Forms.Button buttonPilot;
        private System.Windows.Forms.Button buttonFlight;
        private System.Windows.Forms.Button buttonTicket;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Panel drawer;
        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Panel panelMin;
    }
}