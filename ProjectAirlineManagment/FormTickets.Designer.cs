
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
            this.checkBoxOneWay = new System.Windows.Forms.CheckBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.checkedListBoxSeat = new System.Windows.Forms.CheckedListBox();
            this.checkBoxRoundTrip = new System.Windows.Forms.CheckBox();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.buttonTicketsUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonTicketsInsert = new System.Windows.Forms.Button();
            this.buttonTicketDelete = new System.Windows.Forms.Button();
            this.buttonTicketSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTickets
            // 
            this.labelTickets.AutoSize = true;
            this.labelTickets.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTickets.ForeColor = System.Drawing.Color.White;
            this.labelTickets.Location = new System.Drawing.Point(35, 21);
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
            this.labelPrice.Location = new System.Drawing.Point(49, 80);
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
            this.labelSeat.Location = new System.Drawing.Point(49, 121);
            this.labelSeat.Name = "labelSeat";
            this.labelSeat.Size = new System.Drawing.Size(42, 18);
            this.labelSeat.TabIndex = 2;
            this.labelSeat.Text = "Seat";
            // 
            // checkBoxOneWay
            // 
            this.checkBoxOneWay.AutoSize = true;
            this.checkBoxOneWay.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOneWay.ForeColor = System.Drawing.Color.White;
            this.checkBoxOneWay.Location = new System.Drawing.Point(52, 165);
            this.checkBoxOneWay.Name = "checkBoxOneWay";
            this.checkBoxOneWay.Size = new System.Drawing.Size(161, 22);
            this.checkBoxOneWay.TabIndex = 4;
            this.checkBoxOneWay.Text = "A one-way ticket";
            this.checkBoxOneWay.UseVisualStyleBackColor = true;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(116, 80);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(135, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // checkedListBoxSeat
            // 
            this.checkedListBoxSeat.FormattingEnabled = true;
            this.checkedListBoxSeat.Items.AddRange(new object[] {
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
            this.checkedListBoxSeat.Location = new System.Drawing.Point(116, 106);
            this.checkedListBoxSeat.Name = "checkedListBoxSeat";
            this.checkedListBoxSeat.Size = new System.Drawing.Size(135, 49);
            this.checkedListBoxSeat.TabIndex = 6;
            // 
            // checkBoxRoundTrip
            // 
            this.checkBoxRoundTrip.AutoSize = true;
            this.checkBoxRoundTrip.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRoundTrip.ForeColor = System.Drawing.Color.White;
            this.checkBoxRoundTrip.Location = new System.Drawing.Point(245, 165);
            this.checkBoxRoundTrip.Name = "checkBoxRoundTrip";
            this.checkBoxRoundTrip.Size = new System.Drawing.Size(174, 22);
            this.checkBoxRoundTrip.TabIndex = 7;
            this.checkBoxRoundTrip.Text = "A round-trip ticket";
            this.checkBoxRoundTrip.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.dataGridViewTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(52, 215);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.Size = new System.Drawing.Size(379, 170);
            this.dataGridViewTickets.TabIndex = 8;
            // 
            // buttonTicketsUpdate
            // 
            this.buttonTicketsUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonTicketsUpdate.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicketsUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonTicketsUpdate.Location = new System.Drawing.Point(485, 150);
            this.buttonTicketsUpdate.Name = "buttonTicketsUpdate";
            this.buttonTicketsUpdate.Size = new System.Drawing.Size(97, 37);
            this.buttonTicketsUpdate.TabIndex = 9;
            this.buttonTicketsUpdate.Text = "Update";
            this.buttonTicketsUpdate.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(485, 120);
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
            this.buttonTicketsInsert.Location = new System.Drawing.Point(485, 71);
            this.buttonTicketsInsert.Name = "buttonTicketsInsert";
            this.buttonTicketsInsert.Size = new System.Drawing.Size(97, 37);
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
            this.buttonTicketDelete.Location = new System.Drawing.Point(485, 248);
            this.buttonTicketDelete.Name = "buttonTicketDelete";
            this.buttonTicketDelete.Size = new System.Drawing.Size(97, 37);
            this.buttonTicketDelete.TabIndex = 12;
            this.buttonTicketDelete.Text = "Delete";
            this.buttonTicketDelete.UseVisualStyleBackColor = false;
            // 
            // buttonTicketSave
            // 
            this.buttonTicketSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonTicketSave.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicketSave.ForeColor = System.Drawing.Color.White;
            this.buttonTicketSave.Location = new System.Drawing.Point(485, 335);
            this.buttonTicketSave.Name = "buttonTicketSave";
            this.buttonTicketSave.Size = new System.Drawing.Size(97, 37);
            this.buttonTicketSave.TabIndex = 13;
            this.buttonTicketSave.Text = "Save";
            this.buttonTicketSave.UseVisualStyleBackColor = false;
            // 
            // FormTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(663, 471);
            this.Controls.Add(this.buttonTicketSave);
            this.Controls.Add(this.buttonTicketDelete);
            this.Controls.Add(this.buttonTicketsInsert);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonTicketsUpdate);
            this.Controls.Add(this.dataGridViewTickets);
            this.Controls.Add(this.checkBoxRoundTrip);
            this.Controls.Add(this.checkedListBoxSeat);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.checkBoxOneWay);
            this.Controls.Add(this.labelSeat);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTickets";
            this.Text = "FormTickets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTickets;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelSeat;
        private System.Windows.Forms.CheckBox checkBoxOneWay;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.CheckedListBox checkedListBoxSeat;
        private System.Windows.Forms.CheckBox checkBoxRoundTrip;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.Button buttonTicketsUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonTicketsInsert;
        private System.Windows.Forms.Button buttonTicketDelete;
        private System.Windows.Forms.Button buttonTicketSave;
    }
}