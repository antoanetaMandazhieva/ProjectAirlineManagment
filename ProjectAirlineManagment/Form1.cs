using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAirlineManagment
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerProgressBar.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            if (progressBarStart.Value < 100)
            {
                progressBarStart.Value += 2;
            }
            else
            {
                timerProgressBar.Stop();
                FormProgram form = new FormProgram();
                form.ShowDialog();
            }
        }
    }
}
