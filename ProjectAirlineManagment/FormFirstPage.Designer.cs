
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
            this.iconButtonPilots = new FontAwesome.Sharp.IconButton();
            this.iconButtonTickets = new FontAwesome.Sharp.IconButton();
            this.iconButtonFlights = new FontAwesome.Sharp.IconButton();
            this.iconButtonClients = new FontAwesome.Sharp.IconButton();
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
            this.menuStripMenu.Padding = new System.Windows.Forms.Padding(8, 9, 0, 6);
            this.menuStripMenu.Size = new System.Drawing.Size(1333, 30);
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
            this.panelMax.Location = new System.Drawing.Point(1267, -1);
            this.panelMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMax.Name = "panelMax";
            this.panelMax.Size = new System.Drawing.Size(33, 31);
            this.panelMax.TabIndex = 1;
            this.panelMax.Click += new System.EventHandler(this.panelMax_Click);
            this.panelMax.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMax_Paint);
            // 
            // panelClose
            // 
            this.panelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.panelClose.Location = new System.Drawing.Point(1300, -1);
            this.panelClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(33, 31);
            this.panelClose.TabIndex = 2;
            this.panelClose.Click += new System.EventHandler(this.panelClose_Click);
            this.panelClose.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClose_Paint);
            // 
            // panelMin
            // 
            this.panelMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.panelMin.Location = new System.Drawing.Point(1233, -1);
            this.panelMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMin.Name = "panelMin";
            this.panelMin.Size = new System.Drawing.Size(33, 31);
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
            this.panelSideMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelSideMenu.Location = new System.Drawing.Point(0, 30);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(207, 585);
            this.panelSideMenu.TabIndex = 3;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // panelMenuSubmenu
            // 
            this.panelMenuSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.panelMenuSubmenu.Controls.Add(this.iconButtonPilots);
            this.panelMenuSubmenu.Controls.Add(this.iconButtonTickets);
            this.panelMenuSubmenu.Controls.Add(this.iconButtonFlights);
            this.panelMenuSubmenu.Controls.Add(this.iconButtonClients);
            this.panelMenuSubmenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelMenuSubmenu.Location = new System.Drawing.Point(0, 213);
            this.panelMenuSubmenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenuSubmenu.Name = "panelMenuSubmenu";
            this.panelMenuSubmenu.Size = new System.Drawing.Size(207, 201);
            this.panelMenuSubmenu.TabIndex = 7;
            // 
            // iconButtonPilots
            // 
            this.iconButtonPilots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.iconButtonPilots.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonPilots.FlatAppearance.BorderSize = 0;
            this.iconButtonPilots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPilots.Font = new System.Drawing.Font("Lucida Bright", 11.25F);
            this.iconButtonPilots.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonPilots.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconButtonPilots.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonPilots.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPilots.IconSize = 32;
            this.iconButtonPilots.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPilots.Location = new System.Drawing.Point(0, 147);
            this.iconButtonPilots.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonPilots.Name = "iconButtonPilots";
            this.iconButtonPilots.Size = new System.Drawing.Size(207, 49);
            this.iconButtonPilots.TabIndex = 8;
            this.iconButtonPilots.Text = "Pilots";
            this.iconButtonPilots.UseVisualStyleBackColor = false;
            this.iconButtonPilots.Click += new System.EventHandler(this.iconButtonPilots_Click);
            // 
            // iconButtonTickets
            // 
            this.iconButtonTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.iconButtonTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonTickets.FlatAppearance.BorderSize = 0;
            this.iconButtonTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTickets.Font = new System.Drawing.Font("Lucida Bright", 11.25F);
            this.iconButtonTickets.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonTickets.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.iconButtonTickets.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonTickets.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTickets.IconSize = 32;
            this.iconButtonTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTickets.Location = new System.Drawing.Point(0, 98);
            this.iconButtonTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonTickets.Name = "iconButtonTickets";
            this.iconButtonTickets.Size = new System.Drawing.Size(207, 49);
            this.iconButtonTickets.TabIndex = 7;
            this.iconButtonTickets.Text = "Tickets";
            this.iconButtonTickets.UseVisualStyleBackColor = false;
            this.iconButtonTickets.Click += new System.EventHandler(this.iconButtonTickets_Click);
            // 
            // iconButtonFlights
            // 
            this.iconButtonFlights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.iconButtonFlights.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonFlights.FlatAppearance.BorderSize = 0;
            this.iconButtonFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonFlights.Font = new System.Drawing.Font("Lucida Bright", 11.25F);
            this.iconButtonFlights.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonFlights.IconChar = FontAwesome.Sharp.IconChar.Plane;
            this.iconButtonFlights.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonFlights.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonFlights.IconSize = 32;
            this.iconButtonFlights.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFlights.Location = new System.Drawing.Point(0, 49);
            this.iconButtonFlights.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonFlights.Name = "iconButtonFlights";
            this.iconButtonFlights.Size = new System.Drawing.Size(207, 49);
            this.iconButtonFlights.TabIndex = 6;
            this.iconButtonFlights.Text = "Flights";
            this.iconButtonFlights.UseVisualStyleBackColor = false;
            this.iconButtonFlights.Click += new System.EventHandler(this.iconButtonFlights_Click);
            // 
            // iconButtonClients
            // 
            this.iconButtonClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.iconButtonClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonClients.FlatAppearance.BorderSize = 0;
            this.iconButtonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClients.Font = new System.Drawing.Font("Lucida Bright", 11.25F);
            this.iconButtonClients.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonClients.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButtonClients.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonClients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClients.IconSize = 32;
            this.iconButtonClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClients.Location = new System.Drawing.Point(0, 0);
            this.iconButtonClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonClients.Name = "iconButtonClients";
            this.iconButtonClients.Size = new System.Drawing.Size(207, 49);
            this.iconButtonClients.TabIndex = 5;
            this.iconButtonClients.Text = "Clients";
            this.iconButtonClients.UseVisualStyleBackColor = false;
            this.iconButtonClients.Click += new System.EventHandler(this.iconButtonClients_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMenu.Location = new System.Drawing.Point(0, 157);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.buttonMenu.Size = new System.Drawing.Size(207, 55);
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
            this.buttonHome.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHome.Location = new System.Drawing.Point(0, 102);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(207, 55);
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
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(207, 102);
            this.panelLogo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormFirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 615);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelMin);
            this.Controls.Add(this.panelClose);
            this.Controls.Add(this.panelMax);
            this.Controls.Add(this.menuStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonClients;
        private FontAwesome.Sharp.IconButton iconButtonPilots;
        private FontAwesome.Sharp.IconButton iconButtonTickets;
        private FontAwesome.Sharp.IconButton iconButtonFlights;
    }
}