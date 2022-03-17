
namespace ProjectAirlineManagment
{
    partial class FormFirstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFirstPage));
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.panelMax = new System.Windows.Forms.Panel();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panelMin = new System.Windows.Forms.Panel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelMenuSubmenu = new System.Windows.Forms.Panel();
            this.buttonPilots = new System.Windows.Forms.Button();
            this.buttonTickets = new System.Windows.Forms.Button();
            this.buttonFlights = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelMenuSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.menuStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Padding = new System.Windows.Forms.Padding(6, 7, 0, 5);
            this.menuStripMenu.Size = new System.Drawing.Size(1000, 24);
            this.menuStripMenu.TabIndex = 0;
            this.menuStripMenu.Text = "menuStrip1";
            this.menuStripMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStripMenu_MouseDown);
            this.menuStripMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStripMenu_MouseMove);
            this.menuStripMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStripMenu_MouseUp);
            // 
            // panelMax
            // 
            this.panelMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.panelMax.Location = new System.Drawing.Point(950, -1);
            this.panelMax.Name = "panelMax";
            this.panelMax.Size = new System.Drawing.Size(25, 25);
            this.panelMax.TabIndex = 1;
            this.panelMax.Click += new System.EventHandler(this.panelMax_Click);
            this.panelMax.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMax_Paint);
            // 
            // panelClose
            // 
            this.panelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.panelClose.Location = new System.Drawing.Point(975, -1);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(25, 25);
            this.panelClose.TabIndex = 2;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            this.panelClose.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClose_Paint);
            // 
            // panelMin
            // 
            this.panelMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.panelMin.Location = new System.Drawing.Point(925, -1);
            this.panelMin.Name = "panelMin";
            this.panelMin.Size = new System.Drawing.Size(25, 25);
            this.panelMin.TabIndex = 2;
            this.panelMin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMin_Paint);
            this.panelMin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMin_MouseClick);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.panelSideMenu.Controls.Add(this.panelMenuSubmenu);
            this.panelSideMenu.Controls.Add(this.buttonMenu);
            this.panelSideMenu.Controls.Add(this.buttonHome);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 24);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(155, 476);
            this.panelSideMenu.TabIndex = 3;
            // 
            // panelMenuSubmenu
            // 
            this.panelMenuSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.panelMenuSubmenu.Controls.Add(this.buttonPilots);
            this.panelMenuSubmenu.Controls.Add(this.buttonTickets);
            this.panelMenuSubmenu.Controls.Add(this.buttonFlights);
            this.panelMenuSubmenu.Controls.Add(this.buttonClients);
            this.panelMenuSubmenu.Location = new System.Drawing.Point(0, 173);
            this.panelMenuSubmenu.Name = "panelMenuSubmenu";
            this.panelMenuSubmenu.Size = new System.Drawing.Size(155, 163);
            this.panelMenuSubmenu.TabIndex = 7;
            // 
            // buttonPilots
            // 
            this.buttonPilots.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPilots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPilots.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPilots.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPilots.Location = new System.Drawing.Point(0, 120);
            this.buttonPilots.Name = "buttonPilots";
            this.buttonPilots.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonPilots.Size = new System.Drawing.Size(155, 40);
            this.buttonPilots.TabIndex = 3;
            this.buttonPilots.Text = "Pilots";
            this.buttonPilots.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPilots.UseVisualStyleBackColor = true;
            this.buttonPilots.Click += new System.EventHandler(this.buttonPilots_Click);
            // 
            // buttonTickets
            // 
            this.buttonTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTickets.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTickets.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTickets.Location = new System.Drawing.Point(0, 80);
            this.buttonTickets.Name = "buttonTickets";
            this.buttonTickets.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonTickets.Size = new System.Drawing.Size(155, 40);
            this.buttonTickets.TabIndex = 2;
            this.buttonTickets.Text = "Tickets";
            this.buttonTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTickets.UseVisualStyleBackColor = true;
            this.buttonTickets.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonFlights
            // 
            this.buttonFlights.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlights.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlights.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFlights.Location = new System.Drawing.Point(0, 40);
            this.buttonFlights.Name = "buttonFlights";
            this.buttonFlights.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonFlights.Size = new System.Drawing.Size(155, 40);
            this.buttonFlights.TabIndex = 1;
            this.buttonFlights.Text = "Flights";
            this.buttonFlights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFlights.UseVisualStyleBackColor = true;
            this.buttonFlights.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClients.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClients.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClients.Location = new System.Drawing.Point(0, 0);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonClients.Size = new System.Drawing.Size(155, 40);
            this.buttonClients.TabIndex = 0;
            this.buttonClients.Text = "Clients";
            this.buttonClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMenu.Location = new System.Drawing.Point(0, 128);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonMenu.Size = new System.Drawing.Size(155, 45);
            this.buttonMenu.TabIndex = 6;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHome.Location = new System.Drawing.Point(0, 83);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(155, 45);
            this.buttonHome.TabIndex = 5;
            this.buttonHome.Text = "Home";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(155, 83);
            this.panelLogo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormFirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelMin);
            this.Controls.Add(this.panelClose);
            this.Controls.Add(this.panelMax);
            this.Controls.Add(this.menuStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMenu;
            this.Name = "FormFirstPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFirstPage";
            this.Load += new System.EventHandler(this.FormFirstPage_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelMenuSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.Panel panelMax;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Panel panelMin;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelMenuSubmenu;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonPilots;
        private System.Windows.Forms.Button buttonTickets;
        private System.Windows.Forms.Button buttonFlights;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}