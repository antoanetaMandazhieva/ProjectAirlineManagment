
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClients));
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.labelClients = new System.Windows.Forms.Label();
            this.labelNameClient = new System.Windows.Forms.Label();
            this.labelPhoneNumClient = new System.Windows.Forms.Label();
            this.labelNationalityClient = new System.Windows.Forms.Label();
            this.labelPassNumClient = new System.Windows.Forms.Label();
            this.textBoxPassNumClient = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumClient = new System.Windows.Forms.TextBox();
            this.textBoxNameClient = new System.Windows.Forms.TextBox();
            this.comboBoxNationalityClient = new System.Windows.Forms.ComboBox();
            this.buttonInsertClient = new System.Windows.Forms.Button();
            this.buttonUpdateClient = new System.Windows.Forms.Button();
            this.buttonSaveClient = new System.Windows.Forms.Button();
            this.labelUnderTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClients.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewClients.ColumnHeadersHeight = 29;
            this.dataGridViewClients.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClients.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewClients.Location = new System.Drawing.Point(26, 259);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersWidth = 51;
            this.dataGridViewClients.Size = new System.Drawing.Size(797, 270);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellContentClick);
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClients.ForeColor = System.Drawing.Color.White;
            this.labelClients.Location = new System.Drawing.Point(20, 11);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(119, 34);
            this.labelClients.TabIndex = 1;
            this.labelClients.Text = "Clients";
            // 
            // labelNameClient
            // 
            this.labelNameClient.AutoSize = true;
            this.labelNameClient.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameClient.ForeColor = System.Drawing.Color.White;
            this.labelNameClient.Location = new System.Drawing.Point(74, 103);
            this.labelNameClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameClient.Name = "labelNameClient";
            this.labelNameClient.Size = new System.Drawing.Size(68, 23);
            this.labelNameClient.TabIndex = 2;
            this.labelNameClient.Text = "Name";
            this.labelNameClient.Click += new System.EventHandler(this.labelNameClient_Click);
            // 
            // labelPhoneNumClient
            // 
            this.labelPhoneNumClient.AutoSize = true;
            this.labelPhoneNumClient.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNumClient.ForeColor = System.Drawing.Color.White;
            this.labelPhoneNumClient.Location = new System.Drawing.Point(74, 154);
            this.labelPhoneNumClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNumClient.Name = "labelPhoneNumClient";
            this.labelPhoneNumClient.Size = new System.Drawing.Size(159, 23);
            this.labelPhoneNumClient.TabIndex = 3;
            this.labelPhoneNumClient.Text = "Phone number";
            // 
            // labelNationalityClient
            // 
            this.labelNationalityClient.AutoSize = true;
            this.labelNationalityClient.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNationalityClient.ForeColor = System.Drawing.Color.White;
            this.labelNationalityClient.Location = new System.Drawing.Point(571, 103);
            this.labelNationalityClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNationalityClient.Name = "labelNationalityClient";
            this.labelNationalityClient.Size = new System.Drawing.Size(118, 23);
            this.labelNationalityClient.TabIndex = 4;
            this.labelNationalityClient.Text = "Nationality";
            // 
            // labelPassNumClient
            // 
            this.labelPassNumClient.AutoSize = true;
            this.labelPassNumClient.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassNumClient.ForeColor = System.Drawing.Color.White;
            this.labelPassNumClient.Location = new System.Drawing.Point(571, 154);
            this.labelPassNumClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassNumClient.Name = "labelPassNumClient";
            this.labelPassNumClient.Size = new System.Drawing.Size(183, 23);
            this.labelPassNumClient.TabIndex = 5;
            this.labelPassNumClient.Text = "Passport number";
            // 
            // textBoxPassNumClient
            // 
            this.textBoxPassNumClient.Location = new System.Drawing.Point(762, 157);
            this.textBoxPassNumClient.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassNumClient.Name = "textBoxPassNumClient";
            this.textBoxPassNumClient.Size = new System.Drawing.Size(167, 22);
            this.textBoxPassNumClient.TabIndex = 6;
            // 
            // textBoxPhoneNumClient
            // 
            this.textBoxPhoneNumClient.Location = new System.Drawing.Point(241, 157);
            this.textBoxPhoneNumClient.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhoneNumClient.Name = "textBoxPhoneNumClient";
            this.textBoxPhoneNumClient.Size = new System.Drawing.Size(167, 22);
            this.textBoxPhoneNumClient.TabIndex = 7;
            this.textBoxPhoneNumClient.TextChanged += new System.EventHandler(this.textBoxPhoneNumClient_TextChanged);
            // 
            // textBoxNameClient
            // 
            this.textBoxNameClient.Location = new System.Drawing.Point(241, 106);
            this.textBoxNameClient.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNameClient.Name = "textBoxNameClient";
            this.textBoxNameClient.Size = new System.Drawing.Size(167, 22);
            this.textBoxNameClient.TabIndex = 8;
            this.textBoxNameClient.TextChanged += new System.EventHandler(this.textBoxNameClient_TextChanged);
            // 
            // comboBoxNationalityClient
            // 
            this.comboBoxNationalityClient.FormattingEnabled = true;
            this.comboBoxNationalityClient.Items.AddRange(new object[] {
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
            this.comboBoxNationalityClient.Location = new System.Drawing.Point(762, 106);
            this.comboBoxNationalityClient.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNationalityClient.Name = "comboBoxNationalityClient";
            this.comboBoxNationalityClient.Size = new System.Drawing.Size(167, 24);
            this.comboBoxNationalityClient.TabIndex = 9;
            // 
            // buttonInsertClient
            // 
            this.buttonInsertClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.buttonInsertClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertClient.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertClient.ForeColor = System.Drawing.Color.White;
            this.buttonInsertClient.Location = new System.Drawing.Point(911, 259);
            this.buttonInsertClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInsertClient.Name = "buttonInsertClient";
            this.buttonInsertClient.Size = new System.Drawing.Size(129, 46);
            this.buttonInsertClient.TabIndex = 10;
            this.buttonInsertClient.Text = "Insert";
            this.buttonInsertClient.UseVisualStyleBackColor = false;
            this.buttonInsertClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUpdateClient
            // 
            this.buttonUpdateClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.buttonUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateClient.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateClient.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateClient.Location = new System.Drawing.Point(911, 372);
            this.buttonUpdateClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateClient.Name = "buttonUpdateClient";
            this.buttonUpdateClient.Size = new System.Drawing.Size(129, 46);
            this.buttonUpdateClient.TabIndex = 10;
            this.buttonUpdateClient.Text = "Update";
            this.buttonUpdateClient.UseVisualStyleBackColor = false;
            this.buttonUpdateClient.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSaveClient
            // 
            this.buttonSaveClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.buttonSaveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveClient.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveClient.ForeColor = System.Drawing.Color.White;
            this.buttonSaveClient.Location = new System.Drawing.Point(911, 483);
            this.buttonSaveClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveClient.Name = "buttonSaveClient";
            this.buttonSaveClient.Size = new System.Drawing.Size(129, 46);
            this.buttonSaveClient.TabIndex = 10;
            this.buttonSaveClient.Text = "Save";
            this.buttonSaveClient.UseVisualStyleBackColor = false;
            this.buttonSaveClient.Visible = false;
            this.buttonSaveClient.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelUnderTitle
            // 
            this.labelUnderTitle.AutoSize = true;
            this.labelUnderTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelUnderTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUnderTitle.Location = new System.Drawing.Point(-3, 31);
            this.labelUnderTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnderTitle.Name = "labelUnderTitle";
            this.labelUnderTitle.Size = new System.Drawing.Size(2376, 17);
            this.labelUnderTitle.TabIndex = 22;
            this.labelUnderTitle.Text = resources.GetString("labelUnderTitle.Text");
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1128, 583);
            this.Controls.Add(this.buttonSaveClient);
            this.Controls.Add(this.buttonUpdateClient);
            this.Controls.Add(this.buttonInsertClient);
            this.Controls.Add(this.comboBoxNationalityClient);
            this.Controls.Add(this.textBoxNameClient);
            this.Controls.Add(this.textBoxPhoneNumClient);
            this.Controls.Add(this.textBoxPassNumClient);
            this.Controls.Add(this.labelPassNumClient);
            this.Controls.Add(this.labelNationalityClient);
            this.Controls.Add(this.labelPhoneNumClient);
            this.Controls.Add(this.labelNameClient);
            this.Controls.Add(this.labelClients);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.labelUnderTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormClients";
            this.RightToLeftLayout = true;
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
        private System.Windows.Forms.Label labelNameClient;
        private System.Windows.Forms.Label labelPhoneNumClient;
        private System.Windows.Forms.Label labelNationalityClient;
        private System.Windows.Forms.Label labelPassNumClient;
        private System.Windows.Forms.TextBox textBoxPassNumClient;
        private System.Windows.Forms.TextBox textBoxPhoneNumClient;
        private System.Windows.Forms.TextBox textBoxNameClient;
        private System.Windows.Forms.ComboBox comboBoxNationalityClient;
        private System.Windows.Forms.Button buttonInsertClient;
        private System.Windows.Forms.Button buttonUpdateClient;
        private System.Windows.Forms.Button buttonSaveClient;
        private System.Windows.Forms.Label labelUnderTitle;
    }
}