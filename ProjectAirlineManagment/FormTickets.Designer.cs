﻿
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
            this.radioButtonOneWay = new System.Windows.Forms.RadioButton();
            this.radioButtonRoundTrip = new System.Windows.Forms.RadioButton();
            this.comboBoxSeat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTicketClientId = new System.Windows.Forms.TextBox();
            this.textBoxTicketFlightId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTickets
            // 
            this.labelTickets.AutoSize = true;
            this.labelTickets.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTickets.ForeColor = System.Drawing.Color.White;
            this.labelTickets.Location = new System.Drawing.Point(48, 50);
            this.labelTickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTickets.Name = "labelTickets";
            this.labelTickets.Size = new System.Drawing.Size(126, 34);
            this.labelTickets.TabIndex = 0;
            this.labelTickets.Text = "Tickets";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(72, 200);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(60, 23);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Price";
            // 
            // labelSeat
            // 
            this.labelSeat.AutoSize = true;
            this.labelSeat.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeat.ForeColor = System.Drawing.Color.White;
            this.labelSeat.Location = new System.Drawing.Point(72, 252);
            this.labelSeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeat.Name = "labelSeat";
            this.labelSeat.Size = new System.Drawing.Size(52, 23);
            this.labelSeat.TabIndex = 2;
            this.labelSeat.Text = "Seat";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(194, 200);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(179, 22);
            this.textBoxPrice.TabIndex = 5;
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.dataGridViewTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(71, 313);
            this.dataGridViewTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowHeadersWidth = 51;
            this.dataGridViewTickets.Size = new System.Drawing.Size(599, 209);
            this.dataGridViewTickets.TabIndex = 8;
            // 
            // buttonTicketUpdate
            // 
            this.buttonTicketUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonTicketUpdate.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicketUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonTicketUpdate.Location = new System.Drawing.Point(712, 233);
            this.buttonTicketUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTicketUpdate.Name = "buttonTicketUpdate";
            this.buttonTicketUpdate.Size = new System.Drawing.Size(129, 46);
            this.buttonTicketUpdate.TabIndex = 9;
            this.buttonTicketUpdate.Text = "Update";
            this.buttonTicketUpdate.UseVisualStyleBackColor = false;
            this.buttonTicketUpdate.Click += new System.EventHandler(this.buttonTicketUpdate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(712, 188);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonTicketsInsert
            // 
            this.buttonTicketsInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonTicketsInsert.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicketsInsert.ForeColor = System.Drawing.Color.White;
            this.buttonTicketsInsert.Location = new System.Drawing.Point(712, 127);
            this.buttonTicketsInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTicketsInsert.Name = "buttonTicketsInsert";
            this.buttonTicketsInsert.Size = new System.Drawing.Size(129, 46);
            this.buttonTicketsInsert.TabIndex = 11;
            this.buttonTicketsInsert.Text = "Insert";
            this.buttonTicketsInsert.UseVisualStyleBackColor = false;
            this.buttonTicketsInsert.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonTicketDelete
            // 
            this.buttonTicketDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonTicketDelete.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicketDelete.ForeColor = System.Drawing.Color.White;
            this.buttonTicketDelete.Location = new System.Drawing.Point(712, 341);
            this.buttonTicketDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTicketDelete.Name = "buttonTicketDelete";
            this.buttonTicketDelete.Size = new System.Drawing.Size(129, 46);
            this.buttonTicketDelete.TabIndex = 12;
            this.buttonTicketDelete.Text = "Delete";
            this.buttonTicketDelete.UseVisualStyleBackColor = false;
            this.buttonTicketDelete.Click += new System.EventHandler(this.buttonTicketDelete_Click);
            // 
            // buttonTicketSave
            // 
            this.buttonTicketSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonTicketSave.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicketSave.ForeColor = System.Drawing.Color.White;
            this.buttonTicketSave.Location = new System.Drawing.Point(712, 452);
            this.buttonTicketSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTicketSave.Name = "buttonTicketSave";
            this.buttonTicketSave.Size = new System.Drawing.Size(129, 46);
            this.buttonTicketSave.TabIndex = 13;
            this.buttonTicketSave.Text = "Save";
            this.buttonTicketSave.UseVisualStyleBackColor = false;
            this.buttonTicketSave.Visible = false;
            this.buttonTicketSave.Click += new System.EventHandler(this.buttonTicketSave_Click);
            // 
            // radioButtonOneWay
            // 
            this.radioButtonOneWay.AutoSize = true;
            this.radioButtonOneWay.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOneWay.ForeColor = System.Drawing.Color.White;
            this.radioButtonOneWay.Location = new System.Drawing.Point(421, 146);
            this.radioButtonOneWay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonOneWay.Name = "radioButtonOneWay";
            this.radioButtonOneWay.Size = new System.Drawing.Size(199, 27);
            this.radioButtonOneWay.TabIndex = 14;
            this.radioButtonOneWay.TabStop = true;
            this.radioButtonOneWay.Text = "A one-way ticket";
            this.radioButtonOneWay.UseVisualStyleBackColor = true;
            // 
            // radioButtonRoundTrip
            // 
            this.radioButtonRoundTrip.AutoSize = true;
            this.radioButtonRoundTrip.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRoundTrip.ForeColor = System.Drawing.Color.White;
            this.radioButtonRoundTrip.Location = new System.Drawing.Point(421, 182);
            this.radioButtonRoundTrip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonRoundTrip.Name = "radioButtonRoundTrip";
            this.radioButtonRoundTrip.Size = new System.Drawing.Size(216, 27);
            this.radioButtonRoundTrip.TabIndex = 15;
            this.radioButtonRoundTrip.TabStop = true;
            this.radioButtonRoundTrip.Text = "A round-trip ticket";
            this.radioButtonRoundTrip.UseVisualStyleBackColor = true;
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
            this.comboBoxSeat.Location = new System.Drawing.Point(194, 248);
            this.comboBoxSeat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSeat.Name = "comboBoxSeat";
            this.comboBoxSeat.Size = new System.Drawing.Size(179, 24);
            this.comboBoxSeat.TabIndex = 16;
            this.comboBoxSeat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Flidht Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Client Id";
            // 
            // textBoxTicketClientId
            // 
            this.textBoxTicketClientId.Location = new System.Drawing.Point(194, 107);
            this.textBoxTicketClientId.Name = "textBoxTicketClientId";
            this.textBoxTicketClientId.Size = new System.Drawing.Size(179, 22);
            this.textBoxTicketClientId.TabIndex = 19;
            // 
            // textBoxTicketFlightId
            // 
            this.textBoxTicketFlightId.Location = new System.Drawing.Point(194, 153);
            this.textBoxTicketFlightId.Name = "textBoxTicketFlightId";
            this.textBoxTicketFlightId.Size = new System.Drawing.Size(179, 22);
            this.textBoxTicketFlightId.TabIndex = 20;
            // 
            // FormTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(884, 580);
            this.Controls.Add(this.textBoxTicketFlightId);
            this.Controls.Add(this.textBoxTicketClientId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSeat);
            this.Controls.Add(this.radioButtonRoundTrip);
            this.Controls.Add(this.radioButtonOneWay);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.RadioButton radioButtonOneWay;
        private System.Windows.Forms.RadioButton radioButtonRoundTrip;
        private System.Windows.Forms.ComboBox comboBoxSeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTicketClientId;
        private System.Windows.Forms.TextBox textBoxTicketFlightId;
    }
}