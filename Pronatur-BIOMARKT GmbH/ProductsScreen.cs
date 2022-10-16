using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pronatur_BIOMARKT_GmbH
{
    public partial class ProductsScreen : Form
    {

        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\Pro-Natur-Biomarkt-GmbH.mdf;Integrated Security=True;Connect Timeout=30");
        private int lastSelectedProductKey;



        public ProductsScreen()
        {
            InitializeComponent();

            ShowProducts();
            ClearAllFields();

        }




        private void ProductsScreen_Load(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {

            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wählen Sie zuerst ein ziel");
                return;

            }

            string query = string.Format("delete from Products where Id= {0};", lastSelectedProductKey);
            ExecuteQuery(query);
            ClearAllFields();
            ShowProducts();

        }

        private void ExecuteQuery(String query)
        {
            databaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            if (textBoxPreis.Text == "" || textBoxProductName.Text == "" || textBoxProductBrand.Text == "" || comboBoxKategorie.Text == "")
            {
                MessageBox.Show("Bitte füllen Sie alle Werte aus");
                return;
            }

            String productName = textBoxProductName.Text;
            String productBrand = textBoxProductBrand.Text;
            String productKategorie = comboBoxKategorie.Text;
            float productPreis = float.Parse(textBoxPreis.Text);



            string query = string.Format("insert into Products values('{0}','{1}','{2}','{3}')", productName, productBrand, productKategorie, productPreis);
            ExecuteQuery(query);


            ShowProducts();
            ClearAllFields();


        }
        

        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wählen Sie zuerst ein ziel");
                return;

            }
            String productName = textBoxProductName.Text;
            String productBrand = textBoxProductBrand.Text;
            String productKategorie = comboBoxKategorie.Text;
            String productPreis = textBoxPreis.Text;

            string query = String.Format("update Products set Name='{0}',Marke='{1}',Kategorie='{2}',Preis='{3}' where Id = {4}",
                productName, productBrand, productKategorie,productPreis, lastSelectedProductKey );
            ExecuteQuery(query);


            ShowProducts();


        }



        private void ClearAllFields()
        {
            textBoxProductName.Text = "";
            textBoxProductBrand.Text = "";
            comboBoxKategorie.Text = "";
            textBoxPreis.Text = "";
            comboBoxKategorie.SelectedItem = null;
        }

        private void ShowProducts()
        {
            databaseConnection.Open();

            String query = "select * from Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet);

            ProductsDGV.DataSource = dataSet.Tables[0];
            ProductsDGV.Columns[0].Visible = false;



            databaseConnection.Close();
        }

        private void ProductsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxProductName.Text = ProductsDGV.SelectedRows[0].Cells[1].Value.ToString();
            textBoxProductBrand.Text = ProductsDGV.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxKategorie.Text = ProductsDGV.SelectedRows[0].Cells[3].Value.ToString();
            textBoxPreis.Text = ProductsDGV.SelectedRows[0].Cells[4].Value.ToString();

            lastSelectedProductKey = (int)ProductsDGV.SelectedRows[0].Cells[0].Value;
        
     
        }
    }
}
