
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonUpdateTickets = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonInsertTickets = new System.Windows.Forms.Button();
            this.buttonDeleteTickets = new System.Windows.Forms.Button();
            this.buttonSaveTickets = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(379, 170);
            this.dataGridView1.TabIndex = 8;
            // 
            // buttonUpdateTickets
            // 
            this.buttonUpdateTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonUpdateTickets.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateTickets.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateTickets.Location = new System.Drawing.Point(485, 150);
            this.buttonUpdateTickets.Name = "buttonUpdateTickets";
            this.buttonUpdateTickets.Size = new System.Drawing.Size(97, 37);
            this.buttonUpdateTickets.TabIndex = 9;
            this.buttonUpdateTickets.Text = "Update";
            this.buttonUpdateTickets.UseVisualStyleBackColor = false;
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
            // buttonInsertTickets
            // 
            this.buttonInsertTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonInsertTickets.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertTickets.ForeColor = System.Drawing.Color.White;
            this.buttonInsertTickets.Location = new System.Drawing.Point(485, 71);
            this.buttonInsertTickets.Name = "buttonInsertTickets";
            this.buttonInsertTickets.Size = new System.Drawing.Size(97, 37);
            this.buttonInsertTickets.TabIndex = 11;
            this.buttonInsertTickets.Text = "Insert";
            this.buttonInsertTickets.UseVisualStyleBackColor = false;
            this.buttonInsertTickets.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonDeleteTickets
            // 
            this.buttonDeleteTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonDeleteTickets.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTickets.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteTickets.Location = new System.Drawing.Point(485, 248);
            this.buttonDeleteTickets.Name = "buttonDeleteTickets";
            this.buttonDeleteTickets.Size = new System.Drawing.Size(97, 37);
            this.buttonDeleteTickets.TabIndex = 12;
            this.buttonDeleteTickets.Text = "Delete";
            this.buttonDeleteTickets.UseVisualStyleBackColor = false;
            // 
            // buttonSaveTickets
            // 
            this.buttonSaveTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonSaveTickets.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveTickets.ForeColor = System.Drawing.Color.White;
            this.buttonSaveTickets.Location = new System.Drawing.Point(485, 335);
            this.buttonSaveTickets.Name = "buttonSaveTickets";
            this.buttonSaveTickets.Size = new System.Drawing.Size(97, 37);
            this.buttonSaveTickets.TabIndex = 13;
            this.buttonSaveTickets.Text = "Save";
            this.buttonSaveTickets.UseVisualStyleBackColor = false;
            // 
            // FormTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(663, 471);
            this.Controls.Add(this.buttonSaveTickets);
            this.Controls.Add(this.buttonDeleteTickets);
            this.Controls.Add(this.buttonInsertTickets);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonUpdateTickets);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdateTickets;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonInsertTickets;
        private System.Windows.Forms.Button buttonDeleteTickets;
        private System.Windows.Forms.Button buttonSaveTickets;
    }
}