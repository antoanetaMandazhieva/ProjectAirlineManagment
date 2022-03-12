
namespace ProjectAirlineManagment
{
    partial class FormClients
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
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.labelClients = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNamee = new System.Windows.Forms.Label();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelPassNum = new System.Windows.Forms.Label();
            this.textBoxPassNum = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpdateClient = new System.Windows.Forms.Button();
            this.buttonSaveClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(344, 93);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersWidth = 51;
            this.dataGridViewClients.Size = new System.Drawing.Size(292, 176);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClients.ForeColor = System.Drawing.Color.White;
            this.labelClients.Location = new System.Drawing.Point(38, 31);
            this.labelClients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(93, 28);
            this.labelClients.TabIndex = 1;
            this.labelClients.Text = "Clients";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(56, 93);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 18);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelNamee
            // 
            this.labelNamee.AutoSize = true;
            this.labelNamee.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamee.ForeColor = System.Drawing.Color.White;
            this.labelNamee.Location = new System.Drawing.Point(56, 145);
            this.labelNamee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNamee.Name = "labelNamee";
            this.labelNamee.Size = new System.Drawing.Size(123, 18);
            this.labelNamee.TabIndex = 3;
            this.labelNamee.Text = "Phone number";
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNationality.ForeColor = System.Drawing.Color.White;
            this.labelNationality.Location = new System.Drawing.Point(56, 199);
            this.labelNationality.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(93, 18);
            this.labelNationality.TabIndex = 4;
            this.labelNationality.Text = "Nationality";
            // 
            // labelPassNum
            // 
            this.labelPassNum.AutoSize = true;
            this.labelPassNum.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassNum.ForeColor = System.Drawing.Color.White;
            this.labelPassNum.Location = new System.Drawing.Point(56, 249);
            this.labelPassNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassNum.Name = "labelPassNum";
            this.labelPassNum.Size = new System.Drawing.Size(145, 18);
            this.labelPassNum.TabIndex = 5;
            this.labelPassNum.Text = "Passport number";
            this.labelPassNum.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxPassNum
            // 
            this.textBoxPassNum.Location = new System.Drawing.Point(220, 252);
            this.textBoxPassNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPassNum.Name = "textBoxPassNum";
            this.textBoxPassNum.Size = new System.Drawing.Size(92, 20);
            this.textBoxPassNum.TabIndex = 6;
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Location = new System.Drawing.Point(220, 148);
            this.textBoxPhoneNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(92, 20);
            this.textBoxPhoneNum.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(220, 96);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(92, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Items.AddRange(new object[] {
            "Austrian",
            "Australian",
            "American",
            "Belgian",
            "Brazilian",
            "British",
            "Bulgarian",
            "Chinese",
            "Danish",
            "Egyptian",
            "French",
            "German",
            "Greek",
            "Dutch",
            "Italian",
            "Japanese",
            "Korean",
            "Mexican",
            "Russian",
            "Turkish",
            ""});
            this.comboBoxNationality.Location = new System.Drawing.Point(220, 202);
            this.comboBoxNationality.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(92, 21);
            this.comboBoxNationality.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(72, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUpdateClient
            // 
            this.buttonUpdateClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonUpdateClient.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateClient.Location = new System.Drawing.Point(200, 320);
            this.buttonUpdateClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdateClient.Name = "buttonUpdateClient";
            this.buttonUpdateClient.Size = new System.Drawing.Size(73, 30);
            this.buttonUpdateClient.TabIndex = 11;
            this.buttonUpdateClient.Text = "Update";
            this.buttonUpdateClient.UseVisualStyleBackColor = false;
            this.buttonUpdateClient.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSaveClient
            // 
            this.buttonSaveClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.buttonSaveClient.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveClient.Location = new System.Drawing.Point(326, 320);
            this.buttonSaveClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveClient.Name = "buttonSaveClient";
            this.buttonSaveClient.Size = new System.Drawing.Size(73, 30);
            this.buttonSaveClient.TabIndex = 12;
            this.buttonSaveClient.Text = "Save";
            this.buttonSaveClient.UseVisualStyleBackColor = false;
            this.buttonSaveClient.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(660, 408);
            this.Controls.Add(this.buttonSaveClient);
            this.Controls.Add(this.buttonUpdateClient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxNationality);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPhoneNum);
            this.Controls.Add(this.textBoxPassNum);
            this.Controls.Add(this.labelPassNum);
            this.Controls.Add(this.labelNationality);
            this.Controls.Add(this.labelNamee);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelClients);
            this.Controls.Add(this.dataGridViewClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClients";
            this.Text = "FormClients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNamee;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelPassNum;
        private System.Windows.Forms.TextBox textBoxPassNum;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxNationality;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUpdateClient;
        private System.Windows.Forms.Button buttonSaveClient;
    }
}