
namespace ProjectAirlineManagment
{
    partial class FormTickets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTickets));
            this.labelTickets = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelSeat = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.buttonTicketUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonTicketsInsert = new System.Windows.Forms.Button();
            this.buttonTicketDelete = new System.Windows.Forms.Button();
            this.buttonTicketSave = new System.Windows.Forms.Button();
            this.comboBoxSeat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTicketClientId = new System.Windows.Forms.TextBox();
            this.textBoxTicketFlightId = new System.Windows.Forms.TextBox();
            this.labelUnderTitle = new System.Windows.Forms.Label();
            this.rjRadioButtonRoundTrip = new ProjectAirlineManagment.RJRadioButton();
            this.rjRadioButtonOneWay = new ProjectAirlineManagment.RJRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTickets
            // 
            this.labelTickets.AutoSize = true;
            this.labelTickets.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTickets.ForeColor = System.Drawing.Color.White;
            this.labelTickets.Location = new System.Drawing.Point(15, 9);
            this.labelTickets.Name = "labelTickets";
            this.labelTickets.Size = new System.Drawing.Size(98, 27);
            this.labelTickets.TabIndex = 0;
            this.labelTickets.Text = "Tickets";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(336, 84);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(48, 18);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price";
            // 
            // labelSeat
            // 
            this.labelSeat.AutoSize = true;
            this.labelSeat.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeat.ForeColor = System.Drawing.Color.White;
            this.labelSeat.Location = new System.Drawing.Point(338, 114);
            this.labelSeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeat.Name = "labelSeat";
            this.labelSeat.Size = new System.Drawing.Size(42, 18);
            this.labelSeat.TabIndex = 2;
            this.labelSeat.Text = "Seat";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(408, 84);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(126, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTickets.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTickets.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTickets.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTickets.Location = new System.Drawing.Point(20, 205);
            this.dataGridViewTickets.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowHeadersWidth = 51;
            this.dataGridViewTickets.Size = new System.Drawing.Size(658, 221);
            this.dataGridViewTickets.TabIndex = 8;
            this.dataGridViewTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTickets_CellContentClick);
            // 
            // buttonTicketUpdate
            // 
            this.buttonTicketUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.buttonTicketUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicketUpdate.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicketUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonTicketUpdate.Location = new System.Drawing.Point(705, 271);
            this.buttonTicketUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTicketUpdate.Name = "buttonTicketUpdate";
            this.buttonTicketUpdate.Size = new System.Drawing.Size(97, 37);
            this.buttonTicketUpdate.TabIndex = 9;
            this.buttonTicketUpdate.Text = "Update";
            this.buttonTicketUpdate.UseVisualStyleBackColor = false;
            this.buttonTicketUpdate.Click += new System.EventHandler(this.buttonTicketUpdate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(932, 133);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonTicketsInsert
            // 
            this.buttonTicketsInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.buttonTicketsInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicketsInsert.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicketsInsert.ForeColor = System.Drawing.Color.White;
            this.buttonTicketsInsert.Location = new System.Drawing.Point(705, 205);
            this.buttonTicketsInsert.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTicketsInsert.Name = "buttonTicketsInsert";
            this.buttonTicketsInsert.Size = new System.Drawing.Size(97, 37);
            this.buttonTicketsInsert.TabIndex = 11;
            this.buttonTicketsInsert.Text = "Insert";
            this.buttonTicketsInsert.UseVisualStyleBackColor = false;
            this.buttonTicketsInsert.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonTicketDelete
            // 
            this.buttonTicketDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.buttonTicketDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicketDelete.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicketDelete.ForeColor = System.Drawing.Color.White;
            this.buttonTicketDelete.Location = new System.Drawing.Point(705, 332);
            this.buttonTicketDelete.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTicketDelete.Name = "buttonTicketDelete";
            this.buttonTicketDelete.Size = new System.Drawing.Size(97, 37);
            this.buttonTicketDelete.TabIndex = 12;
            this.buttonTicketDelete.Text = "Delete";
            this.buttonTicketDelete.UseVisualStyleBackColor = false;
            this.buttonTicketDelete.Click += new System.EventHandler(this.buttonTicketDelete_Click);
            // 
            // buttonTicketSave
            // 
            this.buttonTicketSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.buttonTicketSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicketSave.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicketSave.ForeColor = System.Drawing.Color.White;
            this.buttonTicketSave.Location = new System.Drawing.Point(705, 394);
            this.buttonTicketSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTicketSave.Name = "buttonTicketSave";
            this.buttonTicketSave.Size = new System.Drawing.Size(97, 37);
            this.buttonTicketSave.TabIndex = 13;
            this.buttonTicketSave.Text = "Save";
            this.buttonTicketSave.UseVisualStyleBackColor = false;
            this.buttonTicketSave.Visible = false;
            this.buttonTicketSave.Click += new System.EventHandler(this.buttonTicketSave_Click);
            // 
            // comboBoxSeat
            // 
            this.comboBoxSeat.FormattingEnabled = true;
            this.comboBoxSeat.Items.AddRange(new object[] {
            "1А",
            "2А",
            "3А",
            "4А",
            "5А",
            "6А",
            "7А",
            "8А",
            "9А",
            "10А",
            "11А",
            "12А",
            "13А",
            "14А",
            "15А",
            "16А",
            "17А",
            "18А",
            "19А",
            "20А",
            "1C",
            "2C",
            "3C",
            "4C",
            "5C",
            "6C",
            "7C",
            "8C",
            "9C",
            "10C",
            "11C",
            "12C",
            "13C",
            "14C",
            "15C",
            "16C",
            "17C",
            "18C",
            "19C",
            "20C",
            "1D",
            "2D",
            "3D",
            "4D",
            "5D",
            "6D",
            "7D",
            "8D",
            "9D",
            "10D",
            "11D",
            "12D",
            "13D",
            "14D",
            "15D",
            "16D",
            "17D",
            "18D",
            "19D",
            "20D",
            "1E",
            "2E",
            "3E",
            "4E",
            "5E",
            "6E",
            "7E",
            "8E",
            "9E",
            "10E",
            "11E",
            "12E",
            "13E",
            "14E",
            "15E",
            "16E",
            "17E",
            "18E",
            "19E",
            "20E",
            "1F",
            "2F",
            "3F",
            "4F",
            "5F",
            "6F",
            "7F",
            "8F",
            "9F",
            "10F",
            "11F",
            "12F",
            "13F",
            "14F",
            "15F",
            "16F",
            "17F",
            "18F",
            "19F",
            "20F"});
            this.comboBoxSeat.Location = new System.Drawing.Point(408, 114);
            this.comboBoxSeat.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxSeat.Name = "comboBoxSeat";
            this.comboBoxSeat.Size = new System.Drawing.Size(126, 21);
            this.comboBoxSeat.TabIndex = 16;
            this.comboBoxSeat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Flidht Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Client Id";
            // 
            // textBoxTicketClientId
            // 
            this.textBoxTicketClientId.Location = new System.Drawing.Point(132, 84);
            this.textBoxTicketClientId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTicketClientId.Name = "textBoxTicketClientId";
            this.textBoxTicketClientId.Size = new System.Drawing.Size(126, 20);
            this.textBoxTicketClientId.TabIndex = 19;
            // 
            // textBoxTicketFlightId
            // 
            this.textBoxTicketFlightId.Location = new System.Drawing.Point(132, 114);
            this.textBoxTicketFlightId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTicketFlightId.Name = "textBoxTicketFlightId";
            this.textBoxTicketFlightId.Size = new System.Drawing.Size(126, 20);
            this.textBoxTicketFlightId.TabIndex = 20;
            // 
            // labelUnderTitle
            // 
            this.labelUnderTitle.AutoSize = true;
            this.labelUnderTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelUnderTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUnderTitle.Location = new System.Drawing.Point(-2, 25);
            this.labelUnderTitle.Name = "labelUnderTitle";
            this.labelUnderTitle.Size = new System.Drawing.Size(865, 13);
            this.labelUnderTitle.TabIndex = 23;
            this.labelUnderTitle.Text = "_________________________________________________________________________________" +
    "______________________________________________________________";
            // 
            // rjRadioButtonRoundTrip
            // 
            this.rjRadioButtonRoundTrip.AutoSize = true;
            this.rjRadioButtonRoundTrip.CheckedColor = System.Drawing.Color.DarkOrchid;
            this.rjRadioButtonRoundTrip.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.rjRadioButtonRoundTrip.ForeColor = System.Drawing.Color.White;
            this.rjRadioButtonRoundTrip.Location = new System.Drawing.Point(630, 114);
            this.rjRadioButtonRoundTrip.Margin = new System.Windows.Forms.Padding(4);
            this.rjRadioButtonRoundTrip.MinimumSize = new System.Drawing.Size(0, 26);
            this.rjRadioButtonRoundTrip.Name = "rjRadioButtonRoundTrip";
            this.rjRadioButtonRoundTrip.Size = new System.Drawing.Size(185, 26);
            this.rjRadioButtonRoundTrip.TabIndex = 25;
            this.rjRadioButtonRoundTrip.TabStop = true;
            this.rjRadioButtonRoundTrip.Text = "A round-trip ticket";
            this.rjRadioButtonRoundTrip.UnChekedColor = System.Drawing.Color.Indigo;
            this.rjRadioButtonRoundTrip.UseVisualStyleBackColor = true;
            this.rjRadioButtonRoundTrip.CheckedChanged += new System.EventHandler(this.rjRadioButtonRoundTrip_CheckedChanged);
            // 
            // rjRadioButtonOneWay
            // 
            this.rjRadioButtonOneWay.AutoSize = true;
            this.rjRadioButtonOneWay.CheckedColor = System.Drawing.Color.DarkOrchid;
            this.rjRadioButtonOneWay.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.rjRadioButtonOneWay.ForeColor = System.Drawing.Color.White;
            this.rjRadioButtonOneWay.Location = new System.Drawing.Point(630, 84);
            this.rjRadioButtonOneWay.Margin = new System.Windows.Forms.Padding(4);
            this.rjRadioButtonOneWay.MinimumSize = new System.Drawing.Size(0, 26);
            this.rjRadioButtonOneWay.Name = "rjRadioButtonOneWay";
            this.rjRadioButtonOneWay.Size = new System.Drawing.Size(172, 26);
            this.rjRadioButtonOneWay.TabIndex = 24;
            this.rjRadioButtonOneWay.TabStop = true;
            this.rjRadioButtonOneWay.Text = "A one-way ticket";
            this.rjRadioButtonOneWay.UnChekedColor = System.Drawing.Color.Indigo;
            this.rjRadioButtonOneWay.UseVisualStyleBackColor = true;
            this.rjRadioButtonOneWay.CheckedChanged += new System.EventHandler(this.rjRadioButtonOneWay_CheckedChanged);
            // 
            // FormTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(846, 474);
            this.Controls.Add(this.rjRadioButtonRoundTrip);
            this.Controls.Add(this.rjRadioButtonOneWay);
            this.Controls.Add(this.textBoxTicketFlightId);
            this.Controls.Add(this.textBoxTicketClientId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSeat);
            this.Controls.Add(this.buttonTicketSave);
            this.Controls.Add(this.buttonTicketDelete);
            this.Controls.Add(this.buttonTicketsInsert);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonTicketUpdate);
            this.Controls.Add(this.dataGridViewTickets);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelSeat);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelTickets);
            this.Controls.Add(this.labelUnderTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTickets";
            this.Text = "FormTickets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTickets;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelSeat;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.Button buttonTicketUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonTicketsInsert;
        private System.Windows.Forms.Button buttonTicketDelete;
        private System.Windows.Forms.Button buttonTicketSave;
        private System.Windows.Forms.ComboBox comboBoxSeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTicketClientId;
        private System.Windows.Forms.TextBox textBoxTicketFlightId;
        private System.Windows.Forms.Label labelUnderTitle;
        private RJRadioButton rjRadioButtonOneWay;
        private RJRadioButton rjRadioButtonRoundTrip;
    }
}