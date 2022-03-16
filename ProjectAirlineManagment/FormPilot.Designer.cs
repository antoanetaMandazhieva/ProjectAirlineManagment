
namespace ProjectAirlineManagment
{
    partial class FormPilotAge
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
            this.labelPilot = new System.Windows.Forms.Label();
            this.labelPilotName = new System.Windows.Forms.Label();
            this.labelPilotPhoneNum = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.dataGridViewPilot = new System.Windows.Forms.DataGridView();
            this.buttonPilotInsert = new System.Windows.Forms.Button();
            this.buttonPilotUpdate = new System.Windows.Forms.Button();
            this.buttonPiloDelete = new System.Windows.Forms.Button();
            this.buttonPilotSave = new System.Windows.Forms.Button();
            this.textBoxPilotName = new System.Windows.Forms.TextBox();
            this.textBoxPilotPhoneNum = new System.Windows.Forms.TextBox();
            this.textBoxPilotAge = new System.Windows.Forms.TextBox();
            this.radioButtonChiefPilot = new System.Windows.Forms.RadioButton();
            this.radioButtonAssistantPilot = new System.Windows.Forms.RadioButton();
            this.textBoxPilotFlightId = new System.Windows.Forms.TextBox();
            this.labelPilotFlightId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPilot)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPilot
            // 
            this.labelPilot.AutoSize = true;
            this.labelPilot.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPilot.ForeColor = System.Drawing.Color.Transparent;
            this.labelPilot.Location = new System.Drawing.Point(26, 31);
            this.labelPilot.Name = "labelPilot";
            this.labelPilot.Size = new System.Drawing.Size(66, 27);
            this.labelPilot.TabIndex = 0;
            this.labelPilot.Text = "Pilot";
            // 
            // labelPilotName
            // 
            this.labelPilotName.AutoSize = true;
            this.labelPilotName.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPilotName.ForeColor = System.Drawing.Color.White;
            this.labelPilotName.Location = new System.Drawing.Point(55, 90);
            this.labelPilotName.Name = "labelPilotName";
            this.labelPilotName.Size = new System.Drawing.Size(54, 18);
            this.labelPilotName.TabIndex = 1;
            this.labelPilotName.Text = "Name";
            // 
            // labelPilotPhoneNum
            // 
            this.labelPilotPhoneNum.AutoSize = true;
            this.labelPilotPhoneNum.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPilotPhoneNum.ForeColor = System.Drawing.Color.White;
            this.labelPilotPhoneNum.Location = new System.Drawing.Point(55, 155);
            this.labelPilotPhoneNum.Name = "labelPilotPhoneNum";
            this.labelPilotPhoneNum.Size = new System.Drawing.Size(123, 18);
            this.labelPilotPhoneNum.TabIndex = 2;
            this.labelPilotPhoneNum.Text = "Phone number";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.ForeColor = System.Drawing.Color.White;
            this.labelAge.Location = new System.Drawing.Point(55, 124);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(40, 18);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Age";
            // 
            // dataGridViewPilot
            // 
            this.dataGridViewPilot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.dataGridViewPilot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPilot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPilot.Location = new System.Drawing.Point(58, 223);
            this.dataGridViewPilot.Name = "dataGridViewPilot";
            this.dataGridViewPilot.RowHeadersWidth = 51;
            this.dataGridViewPilot.Size = new System.Drawing.Size(425, 164);
            this.dataGridViewPilot.TabIndex = 7;
            // 
            // buttonPilotInsert
            // 
            this.buttonPilotInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonPilotInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPilotInsert.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPilotInsert.ForeColor = System.Drawing.Color.White;
            this.buttonPilotInsert.Location = new System.Drawing.Point(523, 221);
            this.buttonPilotInsert.Name = "buttonPilotInsert";
            this.buttonPilotInsert.Size = new System.Drawing.Size(97, 37);
            this.buttonPilotInsert.TabIndex = 8;
            this.buttonPilotInsert.Text = "Insert";
            this.buttonPilotInsert.UseVisualStyleBackColor = false;
            this.buttonPilotInsert.Click += new System.EventHandler(this.buttonPilotInsert_Click);
            this.buttonPilotInsert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonPilotInsert_MouseUp);
            // 
            // buttonPilotUpdate
            // 
            this.buttonPilotUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonPilotUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPilotUpdate.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPilotUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonPilotUpdate.Location = new System.Drawing.Point(523, 264);
            this.buttonPilotUpdate.Name = "buttonPilotUpdate";
            this.buttonPilotUpdate.Size = new System.Drawing.Size(97, 37);
            this.buttonPilotUpdate.TabIndex = 9;
            this.buttonPilotUpdate.Text = "Update";
            this.buttonPilotUpdate.UseVisualStyleBackColor = false;
            this.buttonPilotUpdate.Click += new System.EventHandler(this.buttonPilotUpdate_Click);
            // 
            // buttonPiloDelete
            // 
            this.buttonPiloDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonPiloDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPiloDelete.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPiloDelete.ForeColor = System.Drawing.Color.White;
            this.buttonPiloDelete.Location = new System.Drawing.Point(523, 307);
            this.buttonPiloDelete.Name = "buttonPiloDelete";
            this.buttonPiloDelete.Size = new System.Drawing.Size(97, 37);
            this.buttonPiloDelete.TabIndex = 10;
            this.buttonPiloDelete.Text = "Delete";
            this.buttonPiloDelete.UseVisualStyleBackColor = false;
            this.buttonPiloDelete.Click += new System.EventHandler(this.buttonPiloDelete_Click);
            // 
            // buttonPilotSave
            // 
            this.buttonPilotSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonPilotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPilotSave.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPilotSave.ForeColor = System.Drawing.Color.White;
            this.buttonPilotSave.Location = new System.Drawing.Point(523, 350);
            this.buttonPilotSave.Name = "buttonPilotSave";
            this.buttonPilotSave.Size = new System.Drawing.Size(97, 37);
            this.buttonPilotSave.TabIndex = 11;
            this.buttonPilotSave.Text = "Save";
            this.buttonPilotSave.UseVisualStyleBackColor = false;
            this.buttonPilotSave.Visible = false;
            this.buttonPilotSave.Click += new System.EventHandler(this.buttonPilotSave_Click);
            // 
            // textBoxPilotName
            // 
            this.textBoxPilotName.Location = new System.Drawing.Point(205, 91);
            this.textBoxPilotName.Name = "textBoxPilotName";
            this.textBoxPilotName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPilotName.TabIndex = 12;
            this.textBoxPilotName.TextChanged += new System.EventHandler(this.textBoxPilotName_TextChanged);
            // 
            // textBoxPilotPhoneNum
            // 
            this.textBoxPilotPhoneNum.Location = new System.Drawing.Point(205, 156);
            this.textBoxPilotPhoneNum.Name = "textBoxPilotPhoneNum";
            this.textBoxPilotPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxPilotPhoneNum.TabIndex = 13;
            this.textBoxPilotPhoneNum.TextChanged += new System.EventHandler(this.textBoxPilotPhoneNum_TextChanged);
            // 
            // textBoxPilotAge
            // 
            this.textBoxPilotAge.Location = new System.Drawing.Point(205, 125);
            this.textBoxPilotAge.Name = "textBoxPilotAge";
            this.textBoxPilotAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxPilotAge.TabIndex = 14;
            // 
            // radioButtonChiefPilot
            // 
            this.radioButtonChiefPilot.AutoSize = true;
            this.radioButtonChiefPilot.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChiefPilot.ForeColor = System.Drawing.Color.White;
            this.radioButtonChiefPilot.Location = new System.Drawing.Point(344, 62);
            this.radioButtonChiefPilot.Name = "radioButtonChiefPilot";
            this.radioButtonChiefPilot.Size = new System.Drawing.Size(108, 22);
            this.radioButtonChiefPilot.TabIndex = 15;
            this.radioButtonChiefPilot.TabStop = true;
            this.radioButtonChiefPilot.Text = "Chief Pilot";
            this.radioButtonChiefPilot.UseVisualStyleBackColor = true;
            // 
            // radioButtonAssistantPilot
            // 
            this.radioButtonAssistantPilot.AutoSize = true;
            this.radioButtonAssistantPilot.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAssistantPilot.ForeColor = System.Drawing.Color.White;
            this.radioButtonAssistantPilot.Location = new System.Drawing.Point(344, 91);
            this.radioButtonAssistantPilot.Name = "radioButtonAssistantPilot";
            this.radioButtonAssistantPilot.Size = new System.Drawing.Size(139, 22);
            this.radioButtonAssistantPilot.TabIndex = 16;
            this.radioButtonAssistantPilot.TabStop = true;
            this.radioButtonAssistantPilot.Text = "Assistant Pilot";
            this.radioButtonAssistantPilot.UseVisualStyleBackColor = true;
            // 
            // textBoxPilotFlightId
            // 
            this.textBoxPilotFlightId.Location = new System.Drawing.Point(205, 186);
            this.textBoxPilotFlightId.Name = "textBoxPilotFlightId";
            this.textBoxPilotFlightId.Size = new System.Drawing.Size(100, 20);
            this.textBoxPilotFlightId.TabIndex = 20;
            // 
            // labelPilotFlightId
            // 
            this.labelPilotFlightId.AutoSize = true;
            this.labelPilotFlightId.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPilotFlightId.ForeColor = System.Drawing.Color.White;
            this.labelPilotFlightId.Location = new System.Drawing.Point(55, 188);
            this.labelPilotFlightId.Name = "labelPilotFlightId";
            this.labelPilotFlightId.Size = new System.Drawing.Size(75, 18);
            this.labelPilotFlightId.TabIndex = 19;
            this.labelPilotFlightId.Text = "Flight ID";
            // 
            // FormPilotAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(644, 399);
            this.Controls.Add(this.textBoxPilotFlightId);
            this.Controls.Add(this.labelPilotFlightId);
            this.Controls.Add(this.radioButtonAssistantPilot);
            this.Controls.Add(this.radioButtonChiefPilot);
            this.Controls.Add(this.textBoxPilotAge);
            this.Controls.Add(this.textBoxPilotPhoneNum);
            this.Controls.Add(this.textBoxPilotName);
            this.Controls.Add(this.buttonPilotSave);
            this.Controls.Add(this.buttonPiloDelete);
            this.Controls.Add(this.buttonPilotUpdate);
            this.Controls.Add(this.buttonPilotInsert);
            this.Controls.Add(this.dataGridViewPilot);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelPilotPhoneNum);
            this.Controls.Add(this.labelPilotName);
            this.Controls.Add(this.labelPilot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPilotAge";
            this.Text = "FormPilot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPilotAge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPilot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPilot;
        private System.Windows.Forms.Label labelPilotName;
        private System.Windows.Forms.Label labelPilotPhoneNum;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.DataGridView dataGridViewPilot;
        private System.Windows.Forms.Button buttonPilotInsert;
        private System.Windows.Forms.Button buttonPilotUpdate;
        private System.Windows.Forms.Button buttonPiloDelete;
        private System.Windows.Forms.Button buttonPilotSave;
        private System.Windows.Forms.TextBox textBoxPilotName;
        private System.Windows.Forms.TextBox textBoxPilotPhoneNum;
        private System.Windows.Forms.TextBox textBoxPilotAge;
        private System.Windows.Forms.RadioButton radioButtonChiefPilot;
        private System.Windows.Forms.RadioButton radioButtonAssistantPilot;
        private System.Windows.Forms.TextBox textBoxPilotFlightId;
        private System.Windows.Forms.Label labelPilotFlightId;
    }
}