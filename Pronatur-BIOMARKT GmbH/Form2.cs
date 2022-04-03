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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Produkte_Click(object sender, EventArgs e)
        {
            ProductsScreen products = new ProductsScreen();

            products.Show();

            this.Hide();
        }

        private void Rechnung_Click(object sender, EventArgs e)
        {
            Rechnung rechnung = new Rechnung();
            rechnung.Show();
            this.Hide();
        }
    }
}
