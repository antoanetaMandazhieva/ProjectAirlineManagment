
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPilotAge));
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
            this.textBoxPilotFlightId = new System.Windows.Forms.TextBox();
            this.labelPilotFlightId = new System.Windows.Forms.Label();
            this.labelUnderTitle = new System.Windows.Forms.Label();
            this.rjRadioButtonAssistantPilot = new ProjectAirlineManagment.RJRadioButton();
            this.rjRadioButtonChiefPilot = new ProjectAirlineManagment.RJRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPilot)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPilot
            // 
            this.labelPilot.AutoSize = true;
            this.labelPilot.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPilot.ForeColor = System.Drawing.Color.Transparent;
            this.labelPilot.Location = new System.Drawing.Point(20, 11);
            this.labelPilot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPilot.Name = "labelPilot";
            this.labelPilot.Size = new System.Drawing.Size(102, 34);
            this.labelPilot.TabIndex = 0;
            this.labelPilot.Text = "Pilots";
            // 
            // labelPilotName
            // 
            this.labelPilotName.AutoSize = true;
            this.labelPilotName.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPilotName.ForeColor = System.Drawing.Color.White;
            this.labelPilotName.Location = new System.Drawing.Point(75, 103);
            this.labelPilotName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPilotName.Name = "labelPilotName";
            this.labelPilotName.Size = new System.Drawing.Size(68, 23);
            this.labelPilotName.TabIndex = 1;
            this.labelPilotName.Text = "Name";
            // 
            // labelPilotPhoneNum
            // 
            this.labelPilotPhoneNum.AutoSize = true;
            this.labelPilotPhoneNum.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPilotPhoneNum.ForeColor = System.Drawing.Color.White;
            this.labelPilotPhoneNum.Location = new System.Drawing.Point(368, 103);
            this.labelPilotPhoneNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPilotPhoneNum.Name = "labelPilotPhoneNum";
            this.labelPilotPhoneNum.Size = new System.Drawing.Size(159, 23);
            this.labelPilotPhoneNum.TabIndex = 2;
            this.labelPilotPhoneNum.Text = "Phone number";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.ForeColor = System.Drawing.Color.White;
            this.labelAge.Location = new System.Drawing.Point(75, 154);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(49, 23);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Age";
            // 
            // dataGridViewPilot
            // 
            this.dataGridViewPilot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPilot.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewPilot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPilot.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewPilot.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPilot.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPilot.Location = new System.Drawing.Point(27, 258);
            this.dataGridViewPilot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewPilot.Name = "dataGridViewPilot";
            this.dataGridViewPilot.RowHeadersWidth = 51;
            this.dataGridViewPilot.Size = new System.Drawing.Size(877, 270);
            this.dataGridViewPilot.TabIndex = 7;
            // 
            // buttonPilotInsert
            // 
            this.buttonPilotInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.buttonPilotInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPilotInsert.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPilotInsert.ForeColor = System.Drawing.Color.White;
            this.buttonPilotInsert.Location = new System.Drawing.Point(948, 258);
            this.buttonPilotInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPilotInsert.Name = "buttonPilotInsert";
            this.buttonPilotInsert.Size = new System.Drawing.Size(129, 46);
            this.buttonPilotInsert.TabIndex = 8;
            this.buttonPilotInsert.Text = "Insert";
            this.buttonPilotInsert.UseVisualStyleBackColor = false;
            this.buttonPilotInsert.Click += new System.EventHandler(this.buttonPilotInsert_Click);
            this.buttonPilotInsert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonPilotInsert_MouseUp);
            // 
            // buttonPilotUpdate
            // 
            this.buttonPilotUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.buttonPilotUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPilotUpdate.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPilotUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonPilotUpdate.Location = new System.Drawing.Point(948, 331);
            this.buttonPilotUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPilotUpdate.Name = "buttonPilotUpdate";
            this.buttonPilotUpdate.Size = new System.Drawing.Size(129, 46);
            this.buttonPilotUpdate.TabIndex = 9;
            this.buttonPilotUpdate.Text = "Update";
            this.buttonPilotUpdate.UseVisualStyleBackColor = false;
            this.buttonPilotUpdate.Click += new System.EventHandler(this.buttonPilotUpdate_Click);
            // 
            // buttonPiloDelete
            // 
            this.buttonPiloDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.buttonPiloDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPiloDelete.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPiloDelete.ForeColor = System.Drawing.Color.White;
            this.buttonPiloDelete.Location = new System.Drawing.Point(948, 406);
            this.buttonPiloDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPiloDelete.Name = "buttonPiloDelete";
            this.buttonPiloDelete.Size = new System.Drawing.Size(129, 46);
            this.buttonPiloDelete.TabIndex = 10;
            this.buttonPiloDelete.Text = "Delete";
            this.buttonPiloDelete.UseVisualStyleBackColor = false;
            this.buttonPiloDelete.Click += new System.EventHandler(this.buttonPiloDelete_Click);
            // 
            // buttonPilotSave
            // 
            this.buttonPilotSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.buttonPilotSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPilotSave.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPilotSave.ForeColor = System.Drawing.Color.White;
            this.buttonPilotSave.Location = new System.Drawing.Point(948, 482);
            this.buttonPilotSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPilotSave.Name = "buttonPilotSave";
            this.buttonPilotSave.Size = new System.Drawing.Size(129, 46);
            this.buttonPilotSave.TabIndex = 11;
            this.buttonPilotSave.Text = "Save";
            this.buttonPilotSave.UseVisualStyleBackColor = false;
            this.buttonPilotSave.Visible = false;
            this.buttonPilotSave.Click += new System.EventHandler(this.buttonPilotSave_Click);
            // 
            // textBoxPilotName
            // 
            this.textBoxPilotName.Location = new System.Drawing.Point(149, 106);
            this.textBoxPilotName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPilotName.Name = "textBoxPilotName";
            this.textBoxPilotName.Size = new System.Drawing.Size(167, 22);
            this.textBoxPilotName.TabIndex = 12;
            this.textBoxPilotName.TextChanged += new System.EventHandler(this.textBoxPilotName_TextChanged);
            // 
            // textBoxPilotPhoneNum
            // 
            this.textBoxPilotPhoneNum.Location = new System.Drawing.Point(535, 106);
            this.textBoxPilotPhoneNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPilotPhoneNum.Name = "textBoxPilotPhoneNum";
            this.textBoxPilotPhoneNum.Size = new System.Drawing.Size(167, 22);
            this.textBoxPilotPhoneNum.TabIndex = 13;
            this.textBoxPilotPhoneNum.TextChanged += new System.EventHandler(this.textBoxPilotPhoneNum_TextChanged);
            // 
            // textBoxPilotAge
            // 
            this.textBoxPilotAge.Location = new System.Drawing.Point(149, 158);
            this.textBoxPilotAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPilotAge.Name = "textBoxPilotAge";
            this.textBoxPilotAge.Size = new System.Drawing.Size(167, 22);
            this.textBoxPilotAge.TabIndex = 14;
            // 
            // textBoxPilotFlightId
            // 
            this.textBoxPilotFlightId.Location = new System.Drawing.Point(535, 158);
            this.textBoxPilotFlightId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPilotFlightId.Name = "textBoxPilotFlightId";
            this.textBoxPilotFlightId.Size = new System.Drawing.Size(167, 22);
            this.textBoxPilotFlightId.TabIndex = 20;
            // 
            // labelPilotFlightId
            // 
            this.labelPilotFlightId.AutoSize = true;
            this.labelPilotFlightId.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPilotFlightId.ForeColor = System.Drawing.Color.White;
            this.labelPilotFlightId.Location = new System.Drawing.Point(368, 154);
            this.labelPilotFlightId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPilotFlightId.Name = "labelPilotFlightId";
            this.labelPilotFlightId.Size = new System.Drawing.Size(95, 23);
            this.labelPilotFlightId.TabIndex = 19;
            this.labelPilotFlightId.Text = "Flight ID";
            // 
            // labelUnderTitle
            // 
            this.labelUnderTitle.AutoSize = true;
            this.labelUnderTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelUnderTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUnderTitle.Location = new System.Drawing.Point(-3, 31);
            this.labelUnderTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnderTitle.Name = "labelUnderTitle";
            this.labelUnderTitle.Size = new System.Drawing.Size(1560, 17);
            this.labelUnderTitle.TabIndex = 21;
            this.labelUnderTitle.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_________________________________";
            // 
            // rjRadioButtonAssistantPilot
            // 
            this.rjRadioButtonAssistantPilot.AutoSize = true;
            this.rjRadioButtonAssistantPilot.CheckedColor = System.Drawing.Color.Indigo;
            this.rjRadioButtonAssistantPilot.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjRadioButtonAssistantPilot.ForeColor = System.Drawing.Color.White;
            this.rjRadioButtonAssistantPilot.Location = new System.Drawing.Point(780, 153);
            this.rjRadioButtonAssistantPilot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rjRadioButtonAssistantPilot.MinimumSize = new System.Drawing.Size(0, 26);
            this.rjRadioButtonAssistantPilot.Name = "rjRadioButtonAssistantPilot";
            this.rjRadioButtonAssistantPilot.Size = new System.Drawing.Size(182, 27);
            this.rjRadioButtonAssistantPilot.TabIndex = 23;
            this.rjRadioButtonAssistantPilot.TabStop = true;
            this.rjRadioButtonAssistantPilot.Text = "Assistant Pilot";
            this.rjRadioButtonAssistantPilot.UnChekedColor = System.Drawing.Color.DarkOrchid;
            this.rjRadioButtonAssistantPilot.UseVisualStyleBackColor = true;
            // 
            // rjRadioButtonChiefPilot
            // 
            this.rjRadioButtonChiefPilot.AutoSize = true;
            this.rjRadioButtonChiefPilot.CheckedColor = System.Drawing.Color.Indigo;
            this.rjRadioButtonChiefPilot.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjRadioButtonChiefPilot.ForeColor = System.Drawing.Color.White;
            this.rjRadioButtonChiefPilot.Location = new System.Drawing.Point(780, 101);
            this.rjRadioButtonChiefPilot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rjRadioButtonChiefPilot.MinimumSize = new System.Drawing.Size(0, 26);
            this.rjRadioButtonChiefPilot.Name = "rjRadioButtonChiefPilot";
            this.rjRadioButtonChiefPilot.Size = new System.Drawing.Size(144, 27);
            this.rjRadioButtonChiefPilot.TabIndex = 22;
            this.rjRadioButtonChiefPilot.TabStop = true;
            this.rjRadioButtonChiefPilot.Text = "Chief Pilot";
            this.rjRadioButtonChiefPilot.UnChekedColor = System.Drawing.Color.DarkOrchid;
            this.rjRadioButtonChiefPilot.UseVisualStyleBackColor = true;
            this.rjRadioButtonChiefPilot.CheckedChanged += new System.EventHandler(this.rjRadioButtonChiefPilot_CheckedChanged);
            // 
            // FormPilotAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1128, 583);
            this.Controls.Add(this.rjRadioButtonAssistantPilot);
            this.Controls.Add(this.rjRadioButtonChiefPilot);
            this.Controls.Add(this.textBoxPilotFlightId);
            this.Controls.Add(this.labelPilotFlightId);
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
            this.Controls.Add(this.labelUnderTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox textBoxPilotFlightId;
        private System.Windows.Forms.Label labelPilotFlightId;
        private System.Windows.Forms.Label labelUnderTitle;
        private RJRadioButton rjRadioButtonChiefPilot;
        private RJRadioButton rjRadioButtonAssistantPilot;
    }
}