
namespace ProjectAirlineManagment
{
    partial class FormFlight
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelSeat = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.textBoxNumberOfSeats = new System.Windows.Forms.TextBox();
            this.buttonFlightInsert = new System.Windows.Forms.Button();
            this.buttonFlightUpdate = new System.Windows.Forms.Button();
            this.buttonFlightDelete = new System.Windows.Forms.Button();
            this.buttonFlightSave = new System.Windows.Forms.Button();
            this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitle.Location = new System.Drawing.Point(25, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(91, 27);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Flights";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDate.Location = new System.Drawing.Point(59, 69);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(46, 18);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDestination.Location = new System.Drawing.Point(59, 117);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(98, 18);
            this.labelDestination.TabIndex = 2;
            this.labelDestination.Text = "Destination";
            // 
            // labelSeat
            // 
            this.labelSeat.AutoSize = true;
            this.labelSeat.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSeat.Location = new System.Drawing.Point(59, 159);
            this.labelSeat.Name = "labelSeat";
            this.labelSeat.Size = new System.Drawing.Size(144, 18);
            this.labelSeat.TabIndex = 3;
            this.labelSeat.Text = "Number of Seats";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(212, 69);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(169, 20);
            this.dateTimePickerDate.TabIndex = 4;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Items.AddRange(new object[] {
            "Tirana, Albania",
            "Sarajevo, Bosnia and Herzegovina",
            "Sofia, Bulgaria",
            "Zagreb, Croatia",
            "Athens, Greece",
            "Pristina, Kosovo",
            "Podgorica, Montenegro",
            "Skopje, North Macedonia",
            "Bucharest, Romania",
            "Belgrade, Sebia",
            "Ljubljana, Slovenia",
            "Ankara, Turkey"});
            this.comboBoxDestination.Location = new System.Drawing.Point(212, 113);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(169, 21);
            this.comboBoxDestination.TabIndex = 5;
            // 
            // textBoxNumberOfSeats
            // 
            this.textBoxNumberOfSeats.Location = new System.Drawing.Point(212, 159);
            this.textBoxNumberOfSeats.Name = "textBoxNumberOfSeats";
            this.textBoxNumberOfSeats.Size = new System.Drawing.Size(67, 20);
            this.textBoxNumberOfSeats.TabIndex = 6;
            // 
            // buttonFlightInsert
            // 
            this.buttonFlightInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonFlightInsert.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlightInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFlightInsert.Location = new System.Drawing.Point(534, 82);
            this.buttonFlightInsert.Name = "buttonFlightInsert";
            this.buttonFlightInsert.Size = new System.Drawing.Size(97, 37);
            this.buttonFlightInsert.TabIndex = 7;
            this.buttonFlightInsert.Text = "Insert";
            this.buttonFlightInsert.UseVisualStyleBackColor = false;
            this.buttonFlightInsert.Click += new System.EventHandler(this.buttonFlightInsert_Click);
            // 
            // buttonFlightUpdate
            // 
            this.buttonFlightUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonFlightUpdate.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlightUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFlightUpdate.Location = new System.Drawing.Point(534, 168);
            this.buttonFlightUpdate.Name = "buttonFlightUpdate";
            this.buttonFlightUpdate.Size = new System.Drawing.Size(97, 37);
            this.buttonFlightUpdate.TabIndex = 8;
            this.buttonFlightUpdate.Text = "Update";
            this.buttonFlightUpdate.UseVisualStyleBackColor = false;
            this.buttonFlightUpdate.Click += new System.EventHandler(this.buttonFlightUpdate_Click);
            // 
            // buttonFlightDelete
            // 
            this.buttonFlightDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonFlightDelete.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlightDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFlightDelete.Location = new System.Drawing.Point(534, 259);
            this.buttonFlightDelete.Name = "buttonFlightDelete";
            this.buttonFlightDelete.Size = new System.Drawing.Size(97, 37);
            this.buttonFlightDelete.TabIndex = 9;
            this.buttonFlightDelete.Text = "Delete";
            this.buttonFlightDelete.UseVisualStyleBackColor = false;
            this.buttonFlightDelete.Click += new System.EventHandler(this.buttonFlightDelete_Click);
            // 
            // buttonFlightSave
            // 
            this.buttonFlightSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonFlightSave.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlightSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFlightSave.Location = new System.Drawing.Point(534, 350);
            this.buttonFlightSave.Name = "buttonFlightSave";
            this.buttonFlightSave.Size = new System.Drawing.Size(97, 37);
            this.buttonFlightSave.TabIndex = 10;
            this.buttonFlightSave.Text = "Save";
            this.buttonFlightSave.UseVisualStyleBackColor = false;
            this.buttonFlightSave.Visible = false;
            this.buttonFlightSave.Click += new System.EventHandler(this.buttonFlightSave_Click);
            // 
            // dataGridViewFlights
            // 
            this.dataGridViewFlights.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.dataGridViewFlights.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlights.Location = new System.Drawing.Point(24, 205);
            this.dataGridViewFlights.Name = "dataGridViewFlights";
            this.dataGridViewFlights.RowHeadersWidth = 51;
            this.dataGridViewFlights.Size = new System.Drawing.Size(484, 182);
            this.dataGridViewFlights.TabIndex = 11;
            // 
            // FormFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(644, 399);
            this.Controls.Add(this.dataGridViewFlights);
            this.Controls.Add(this.buttonFlightSave);
            this.Controls.Add(this.buttonFlightDelete);
            this.Controls.Add(this.buttonFlightUpdate);
            this.Controls.Add(this.buttonFlightInsert);
            this.Controls.Add(this.textBoxNumberOfSeats);
            this.Controls.Add(this.comboBoxDestination);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelSeat);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFlight";
            this.Text = "FormFlight";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelSeat;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.TextBox textBoxNumberOfSeats;
        private System.Windows.Forms.Button buttonFlightInsert;
        private System.Windows.Forms.Button buttonFlightUpdate;
        private System.Windows.Forms.Button buttonFlightDelete;
        private System.Windows.Forms.Button buttonFlightSave;
        private System.Windows.Forms.DataGridView dataGridViewFlights;
    }
}