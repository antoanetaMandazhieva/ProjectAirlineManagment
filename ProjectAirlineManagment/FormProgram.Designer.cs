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
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenuSubmenu = new System.Windows.Forms.Panel();
            this.buttonPilot = new System.Windows.Forms.Button();
            this.buttonFlight = new System.Windows.Forms.Button();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.panelMin = new System.Windows.Forms.Panel();
            this.drawer = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelMenuSubmenu.SuspendLayout();
            this.panelTopMenu.SuspendLayout();
            this.drawer.SuspendLayout();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Location = new System.Drawing.Point(6, 7);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Padding = new System.Windows.Forms.Padding(6, 7, 0, 5);
            this.miniToolStrip.Size = new System.Drawing.Size(849, 24);
            this.miniToolStrip.TabIndex = 4;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.panelMenuSubmenu);
            this.panelMenu.Controls.Add(this.buttonMenu);
            this.panelMenu.Controls.Add(this.panellogo);
            this.panelMenu.Location = new System.Drawing.Point(0, -28);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(237, 575);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.buttonPilot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.buttonPilot.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPilot.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonPilot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPilot.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPilot.ForeColor = System.Drawing.Color.White;
            this.buttonPilot.Location = new System.Drawing.Point(0, 147);
            this.buttonPilot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPilot.Name = "buttonPilot";
            this.buttonPilot.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.buttonPilot.Size = new System.Drawing.Size(237, 49);
            this.buttonPilot.TabIndex = 3;
            this.buttonPilot.Text = "Pilots";
            this.buttonPilot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPilot.UseVisualStyleBackColor = false;
            this.buttonPilot.Click += new System.EventHandler(this.buttonPilot_Click);
            // 
            // buttonFlight
            // 
            this.buttonFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.buttonFlight.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFlight.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlight.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlight.ForeColor = System.Drawing.Color.White;
            this.buttonFlight.Location = new System.Drawing.Point(0, 98);
            this.buttonFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFlight.Name = "buttonFlight";
            this.buttonFlight.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.buttonFlight.Size = new System.Drawing.Size(237, 49);
            this.buttonFlight.TabIndex = 2;
            this.buttonFlight.Text = "Flights";
            this.buttonFlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFlight.UseVisualStyleBackColor = false;
            this.buttonFlight.Click += new System.EventHandler(this.buttonFlight_Click);
            // 
            // buttonTicket
            // 
            this.buttonTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.buttonTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTicket.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicket.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicket.ForeColor = System.Drawing.Color.White;
            this.buttonTicket.Location = new System.Drawing.Point(0, 49);
            this.buttonTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.buttonTicket.Size = new System.Drawing.Size(237, 49);
            this.buttonTicket.TabIndex = 1;
            this.buttonTicket.Text = "Tickets";
            this.buttonTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTicket.UseVisualStyleBackColor = false;
            this.buttonTicket.Click += new System.EventHandler(this.buttonTicket_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.buttonClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClient.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.ForeColor = System.Drawing.Color.White;
            this.buttonClient.Location = new System.Drawing.Point(0, 0);
            this.buttonClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.buttonClient.Size = new System.Drawing.Size(237, 49);
            this.buttonClient.TabIndex = 0;
            this.buttonClient.Text = "Clients";
            this.buttonClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(237, 119);
            this.panellogo.TabIndex = 2;
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.Controls.Add(this.panelClose);
            this.panelTopMenu.Controls.Add(this.menuStripMenu);
            this.panelTopMenu.Controls.Add(this.panelMin);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(1132, 43);
            this.panelTopMenu.TabIndex = 2;
            // 
            // panelClose
            // 
            this.panelClose.Location = new System.Drawing.Point(1092, -1);
            this.panelClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(40, 37);
            this.panelClose.TabIndex = 3;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click_1);
            this.panelClose.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClose_Paint_1);
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.menuStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Padding = new System.Windows.Forms.Padding(8, 6, 0, 9);
            this.menuStripMenu.Size = new System.Drawing.Size(1132, 24);
            this.menuStripMenu.TabIndex = 0;
            this.menuStripMenu.Text = "menuStrip1";
            this.menuStripMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStripMenu_MouseDown_1);
            this.menuStripMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStripMenu_MouseMove_1);
            this.menuStripMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStripMenu_MouseUp_1);
            // 
            // panelMin
            // 
            this.panelMin.Location = new System.Drawing.Point(1052, 15);
            this.panelMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMin.Name = "panelMin";
            this.panelMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelMin.Size = new System.Drawing.Size(40, 37);
            this.panelMin.TabIndex = 1;
            this.panelMin.Click += new System.EventHandler(this.panelMin_Click_1);
            this.panelMin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMin_Paint_1);
            // 
            // drawer
            // 
            this.drawer.Controls.Add(this.panelMenu);
            this.drawer.Location = new System.Drawing.Point(0, 43);
            this.drawer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(237, 532);
            this.drawer.TabIndex = 0;
            this.drawer.Paint += new System.Windows.Forms.PaintEventHandler(this.drawer_Paint);
            // 
            // FormProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 575);
            this.Controls.Add(this.panelTopMenu);
            this.Controls.Add(this.drawer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.miniToolStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProgram";
            this.Load += new System.EventHandler(this.FormProgram_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuSubmenu.ResumeLayout(false);
            this.panelTopMenu.ResumeLayout(false);
            this.panelTopMenu.PerformLayout();
            this.drawer.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Panel panelMin;
        private System.Windows.Forms.Panel drawer;
    }
}