
namespace ProjectAirlineManagment
{
    partial class FormStart
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
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.progressBarStart = new System.Windows.Forms.ProgressBar();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxStartPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.labelName.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(135, 120);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(302, 38);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Balkan Airlines";
            // 
            // progressBarStart
            // 
            this.progressBarStart.Location = new System.Drawing.Point(-1, 286);
            this.progressBarStart.Name = "progressBarStart";
            this.progressBarStart.Size = new System.Drawing.Size(592, 24);
            this.progressBarStart.TabIndex = 2;
            this.progressBarStart.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Enabled = true;
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // pictureBoxStartPhoto
            // 
            this.pictureBoxStartPhoto.Image = global::ProjectAirlineManagment.Properties.Resources.download;
            this.pictureBoxStartPhoto.InitialImage = null;
            this.pictureBoxStartPhoto.Location = new System.Drawing.Point(-49, -54);
            this.pictureBoxStartPhoto.Name = "pictureBoxStartPhoto";
            this.pictureBoxStartPhoto.Size = new System.Drawing.Size(712, 352);
            this.pictureBoxStartPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStartPhoto.TabIndex = 0;
            this.pictureBoxStartPhoto.TabStop = false;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 310);
            this.Controls.Add(this.progressBarStart);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxStartPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStartPhoto;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ProgressBar progressBarStart;
        private System.Windows.Forms.Timer timerProgressBar;
    }
}

