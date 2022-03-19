
namespace ProjectAirlineManagment
{
    partial class FormAboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutUs));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.labelUnderTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 11);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(157, 34);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "About Us";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(15)))), ((int)(((byte)(34)))));
            this.labelText.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.White;
            this.labelText.Location = new System.Drawing.Point(92, 103);
            this.labelText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(920, 414);
            this.labelText.TabIndex = 1;
            this.labelText.Text = resources.GetString("labelText.Text");
            // 
            // labelUnderTitle
            // 
            this.labelUnderTitle.AutoSize = true;
            this.labelUnderTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelUnderTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUnderTitle.Location = new System.Drawing.Point(-257, 31);
            this.labelUnderTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnderTitle.Name = "labelUnderTitle";
            this.labelUnderTitle.Size = new System.Drawing.Size(1560, 17);
            this.labelUnderTitle.TabIndex = 22;
            this.labelUnderTitle.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_________________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectAirlineManagment.Properties.Resources.Orange_Minimalist_Greeting_Condolences_of_Airline_Crash_for_Instagram_Post_Template__2_;
            this.pictureBox1.Location = new System.Drawing.Point(744, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // FormAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1128, 583);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelUnderTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAboutUs";
            this.Text = "FormAboutUs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelUnderTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}