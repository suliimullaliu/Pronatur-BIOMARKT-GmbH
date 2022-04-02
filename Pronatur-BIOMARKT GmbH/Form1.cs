using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pronatur_BIOMARKT_GmbH
{
    public partial class ProNatur : Form


    {
        int value;

        public ProNatur()
        {
            InitializeComponent();
        }
        


        private void ProNatur_Load(object sender, EventArgs e)
        {
            timer1.Start();


        }
        private void timer1_Tick(object sender, EventArgs e)

        { 
            value++;

            progressBar1.Value = value;
            prozentWert.Text = Convert.ToString(value)+"%";

            if(value == 100)
            {
                timer1.Stop();
            Application.Exit();
            }
        }

      
    }
}
