
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClients.ColumnHeadersHeight = 29;
            this.dataGridViewClients.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClients.Location = new System.Drawing.Point(20, 210);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersWidth = 51;
            this.dataGridViewClients.Size = new System.Drawing.Size(598, 219);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellContentClick);
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClients.ForeColor = System.Drawing.Color.White;
            this.labelClients.Location = new System.Drawing.Point(15, 9);
            this.labelClients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(93, 27);
            this.labelClients.TabIndex = 1;
            this.labelClients.Text = "Clients";
            // 
            // labelNameClient
            // 
            this.labelNameClient.AutoSize = true;
            this.labelNameClient.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameClient.ForeColor = System.Drawing.Color.White;
            this.labelNameClient.Location = new System.Drawing.Point(56, 84);
            this.labelNameClient.Name = "labelNameClient";
            this.labelNameClient.Size = new System.Drawing.Size(54, 18);
            this.labelNameClient.TabIndex = 2;
            this.labelNameClient.Text = "Name";
            this.labelNameClient.Click += new System.EventHandler(this.labelNameClient_Click);
            // 
            // labelPhoneNumClient
            // 
            this.labelPhoneNumClient.AutoSize = true;
            this.labelPhoneNumClient.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNumClient.ForeColor = System.Drawing.Color.White;
            this.labelPhoneNumClient.Location = new System.Drawing.Point(56, 125);
            this.labelPhoneNumClient.Name = "labelPhoneNumClient";
            this.labelPhoneNumClient.Size = new System.Drawing.Size(123, 18);
            this.labelPhoneNumClient.TabIndex = 3;
            this.labelPhoneNumClient.Text = "Phone number";
            // 
            // labelNationalityClient
            // 
            this.labelNationalityClient.AutoSize = true;
            this.labelNationalityClient.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNationalityClient.ForeColor = System.Drawing.Color.White;
            this.labelNationalityClient.Location = new System.Drawing.Point(428, 84);
            this.labelNationalityClient.Name = "labelNationalityClient";
            this.labelNationalityClient.Size = new System.Drawing.Size(93, 18);
            this.labelNationalityClient.TabIndex = 4;
            this.labelNationalityClient.Text = "Nationality";
            // 
            // labelPassNumClient
            // 
            this.labelPassNumClient.AutoSize = true;
            this.labelPassNumClient.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassNumClient.ForeColor = System.Drawing.Color.White;
            this.labelPassNumClient.Location = new System.Drawing.Point(428, 125);
            this.labelPassNumClient.Name = "labelPassNumClient";
            this.labelPassNumClient.Size = new System.Drawing.Size(145, 18);
            this.labelPassNumClient.TabIndex = 5;
            this.labelPassNumClient.Text = "Passport number";
            // 
            // textBoxPassNumClient
            // 
            this.textBoxPassNumClient.Location = new System.Drawing.Point(572, 128);
            this.textBoxPassNumClient.Name = "textBoxPassNumClient";
            this.textBoxPassNumClient.Size = new System.Drawing.Size(126, 20);
            this.textBoxPassNumClient.TabIndex = 6;
            // 
            // textBoxPhoneNumClient
            // 
            this.textBoxPhoneNumClient.Location = new System.Drawing.Point(181, 128);
            this.textBoxPhoneNumClient.Name = "textBoxPhoneNumClient";
            this.textBoxPhoneNumClient.Size = new System.Drawing.Size(126, 20);
            this.textBoxPhoneNumClient.TabIndex = 7;
            this.textBoxPhoneNumClient.TextChanged += new System.EventHandler(this.textBoxPhoneNumClient_TextChanged);
            // 
            // textBoxNameClient
            // 
            this.textBoxNameClient.Location = new System.Drawing.Point(181, 86);
            this.textBoxNameClient.Name = "textBoxNameClient";
            this.textBoxNameClient.Size = new System.Drawing.Size(126, 20);
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
            this.comboBoxNationalityClient.Location = new System.Drawing.Point(572, 86);
            this.comboBoxNationalityClient.Name = "comboBoxNationalityClient";
            this.comboBoxNationalityClient.Size = new System.Drawing.Size(126, 21);
            this.comboBoxNationalityClient.TabIndex = 9;
            // 
            // buttonInsertClient
            // 
            this.buttonInsertClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.buttonInsertClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertClient.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertClient.ForeColor = System.Drawing.Color.White;
            this.buttonInsertClient.Location = new System.Drawing.Point(683, 210);
            this.buttonInsertClient.Name = "buttonInsertClient";
            this.buttonInsertClient.Size = new System.Drawing.Size(97, 37);
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
            this.buttonUpdateClient.Location = new System.Drawing.Point(683, 302);
            this.buttonUpdateClient.Name = "buttonUpdateClient";
            this.buttonUpdateClient.Size = new System.Drawing.Size(97, 37);
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
            this.buttonSaveClient.Location = new System.Drawing.Point(683, 392);
            this.buttonSaveClient.Name = "buttonSaveClient";
            this.buttonSaveClient.Size = new System.Drawing.Size(97, 37);
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
            this.labelUnderTitle.Location = new System.Drawing.Point(-2, 25);
            this.labelUnderTitle.Name = "labelUnderTitle";
            this.labelUnderTitle.Size = new System.Drawing.Size(1783, 13);
            this.labelUnderTitle.TabIndex = 22;
            this.labelUnderTitle.Text = resources.GetString("labelUnderTitle.Text");
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(846, 474);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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