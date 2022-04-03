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
    public partial class ProductsScreen : Form
    {
        public ProductsScreen()
        {
            InitializeComponent();
        }

        private void ProductsScreen_Load(object sender, EventArgs e)
        {

        }

  

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            String productName = textBoxProductName.Text;
            String productBrand = textBoxProductBrand.Text;
            String productKategorie = comboBoxKategorie.Text;
            float productPreis;

        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
