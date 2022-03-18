
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.labelSeat = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.textBoxSeatsCount = new System.Windows.Forms.TextBox();
            this.buttonFlightInsert = new System.Windows.Forms.Button();
            this.buttonFlightUpdate = new System.Windows.Forms.Button();
            this.buttonFlightDelete = new System.Windows.Forms.Button();
            this.buttonFlightSave = new System.Windows.Forms.Button();
            this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
            this.labelUnderTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitle.Location = new System.Drawing.Point(20, 11);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(118, 34);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Flights";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDate.Location = new System.Drawing.Point(43, 80);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(56, 23);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date";
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDestination.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDestination.Location = new System.Drawing.Point(43, 124);
            this.labelDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(125, 23);
            this.labelDestination.TabIndex = 2;
            this.labelDestination.Text = "Destination";
            // 
            // labelSeat
            // 
            this.labelSeat.AutoSize = true;
            this.labelSeat.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSeat.Location = new System.Drawing.Point(43, 166);
            this.labelSeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeat.Name = "labelSeat";
            this.labelSeat.Size = new System.Drawing.Size(178, 23);
            this.labelSeat.TabIndex = 3;
            this.labelSeat.Text = "Number of Seats";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(268, 78);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(224, 24);
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
            this.comboBoxDestination.Location = new System.Drawing.Point(268, 121);
            this.comboBoxDestination.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(224, 24);
            this.comboBoxDestination.TabIndex = 5;
            // 
            // textBoxSeatsCount
            // 
            this.textBoxSeatsCount.Location = new System.Drawing.Point(268, 164);
            this.textBoxSeatsCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSeatsCount.Name = "textBoxSeatsCount";
            this.textBoxSeatsCount.Size = new System.Drawing.Size(88, 22);
            this.textBoxSeatsCount.TabIndex = 6;
            this.textBoxSeatsCount.TextChanged += new System.EventHandler(this.textBoxNumberOfSeats_TextChanged);
            // 
            // buttonFlightInsert
            // 
            this.buttonFlightInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonFlightInsert.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFlightInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFlightInsert.Location = new System.Drawing.Point(813, 241);
            this.buttonFlightInsert.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFlightInsert.Name = "buttonFlightInsert";
            this.buttonFlightInsert.Size = new System.Drawing.Size(129, 46);
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
            this.buttonFlightUpdate.Location = new System.Drawing.Point(813, 325);
            this.buttonFlightUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFlightUpdate.Name = "buttonFlightUpdate";
            this.buttonFlightUpdate.Size = new System.Drawing.Size(129, 46);
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
            this.buttonFlightDelete.Location = new System.Drawing.Point(813, 406);
            this.buttonFlightDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFlightDelete.Name = "buttonFlightDelete";
            this.buttonFlightDelete.Size = new System.Drawing.Size(129, 46);
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
            this.buttonFlightSave.Location = new System.Drawing.Point(813, 482);
            this.buttonFlightSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFlightSave.Name = "buttonFlightSave";
            this.buttonFlightSave.Size = new System.Drawing.Size(129, 46);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFlights.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlights.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewFlights.Location = new System.Drawing.Point(27, 240);
            this.dataGridViewFlights.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewFlights.Name = "dataGridViewFlights";
            this.dataGridViewFlights.RowHeadersWidth = 51;
            this.dataGridViewFlights.Size = new System.Drawing.Size(752, 287);
            this.dataGridViewFlights.TabIndex = 11;
            this.dataGridViewFlights.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFlights_CellContentClick);
            // 
            // labelUnderTitle
            // 
            this.labelUnderTitle.AutoSize = true;
            this.labelUnderTitle.Location = new System.Drawing.Point(-3, 31);
            this.labelUnderTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnderTitle.Name = "labelUnderTitle";
            this.labelUnderTitle.Size = new System.Drawing.Size(1546, 17);
            this.labelUnderTitle.TabIndex = 12;
            this.labelUnderTitle.Text = "__________________________________________________________--_____________________" +
    "________________________________________________________________________________" +
    "________________________________";
            // 
            // FormFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1128, 583);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelUnderTitle);
            this.Controls.Add(this.dataGridViewFlights);
            this.Controls.Add(this.buttonFlightSave);
            this.Controls.Add(this.buttonFlightDelete);
            this.Controls.Add(this.buttonFlightUpdate);
            this.Controls.Add(this.buttonFlightInsert);
            this.Controls.Add(this.textBoxSeatsCount);
            this.Controls.Add(this.comboBoxDestination);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelSeat);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.labelDate);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox textBoxSeatsCount;
        private System.Windows.Forms.Button buttonFlightInsert;
        private System.Windows.Forms.Button buttonFlightUpdate;
        private System.Windows.Forms.Button buttonFlightDelete;
        private System.Windows.Forms.Button buttonFlightSave;
        private System.Windows.Forms.Label labelUnderTitle;
        internal System.Windows.Forms.DataGridView dataGridViewFlights;
    }
}