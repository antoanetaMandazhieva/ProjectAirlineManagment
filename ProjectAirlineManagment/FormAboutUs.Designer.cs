
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
            this.labelSubText = new System.Windows.Forms.Label();
            this.labelIfo = new System.Windows.Forms.Label();
            this.labelUnderTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(15, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(124, 27);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "About Us";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.White;
            this.labelText.Location = new System.Drawing.Point(47, 112);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(716, 100);
            this.labelText.TabIndex = 1;
            this.labelText.Text = resources.GetString("labelText.Text");
            // 
            // labelSubText
            // 
            this.labelSubText.AutoSize = true;
            this.labelSubText.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubText.ForeColor = System.Drawing.Color.White;
            this.labelSubText.Location = new System.Drawing.Point(43, 250);
            this.labelSubText.Name = "labelSubText";
            this.labelSubText.Size = new System.Drawing.Size(366, 40);
            this.labelSubText.TabIndex = 2;
            this.labelSubText.Text = " If you have a problem, call the support center:\r\n\r\n";
            // 
            // labelIfo
            // 
            this.labelIfo.AutoSize = true;
            this.labelIfo.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIfo.ForeColor = System.Drawing.Color.White;
            this.labelIfo.Location = new System.Drawing.Point(47, 281);
            this.labelIfo.Name = "labelIfo";
            this.labelIfo.Size = new System.Drawing.Size(504, 20);
            this.labelIfo.TabIndex = 3;
            this.labelIfo.Text = "phone: 089765438 or email: balkanairsupportcentre@gmail.com ";
            // 
            // labelUnderTitle
            // 
            this.labelUnderTitle.AutoSize = true;
            this.labelUnderTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelUnderTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUnderTitle.Location = new System.Drawing.Point(-193, 25);
            this.labelUnderTitle.Name = "labelUnderTitle";
            this.labelUnderTitle.Size = new System.Drawing.Size(1171, 13);
            this.labelUnderTitle.TabIndex = 22;
            this.labelUnderTitle.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_________________________________";
            // 
            // FormAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(846, 474);
            this.Controls.Add(this.labelIfo);
            this.Controls.Add(this.labelSubText);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelUnderTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAboutUs";
            this.Text = "FormAboutUs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelSubText;
        private System.Windows.Forms.Label labelIfo;
        private System.Windows.Forms.Label labelUnderTitle;
    }
}