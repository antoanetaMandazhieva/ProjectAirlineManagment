
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
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
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
            this.labelText.BackColor = System.Drawing.Color.Silver;
            this.labelText.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.White;
            this.labelText.Location = new System.Drawing.Point(47, 101);
            this.labelText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(992, 391);
            this.labelText.TabIndex = 1;
            this.labelText.Text = resources.GetString("labelText.Text");
            this.labelText.Click += new System.EventHandler(this.labelText_Click);
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
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.Image = global::ProjectAirlineManagment.Properties.Resources.MicrosoftTeams_image__2_1;
            this.pictureBoxPlane.Location = new System.Drawing.Point(807, 299);
            this.pictureBoxPlane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(243, 203);
            this.pictureBoxPlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlane.TabIndex = 23;
            this.pictureBoxPlane.TabStop = false;
            // 
            // FormAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1128, 583);
            this.Controls.Add(this.pictureBoxPlane);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelUnderTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAboutUs";
            this.Text = "FormAboutUs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelUnderTitle;
        private System.Windows.Forms.PictureBox pictureBoxPlane;
    }
}