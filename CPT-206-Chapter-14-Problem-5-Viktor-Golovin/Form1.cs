using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPT_206_Chapter_14_Problem_5_Viktor_Golovin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Viktor Golovin
        //Cpt 206
        //Lab 1
        //Chapter 14, Problem 5
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);
            //Call DataContext
            ProductsDataContext db = new ProductsDataContext();


           
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //CallData Context again because its in a void 
            ProductsDataContext db = new ProductsDataContext();
            //2 integer variables to parse the text boxes, so that i can use a > or < argument with the 
            //integers in the database
            int num1 = int.Parse(moreThanText.Text);
            int num2 = int.Parse(lessThanText.Text);

            var results = from product in db.Products
                          //Query to select where units on hand are > num1, or < num2
                          where product.Units_On_Hand > num1 
                          where product.Units_On_Hand<num2
                          //Select and return values after query
                          select product;
            //display results in the datagrid
            productDataGrid.DataSource = results;
           

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.FillBy(this.productDBDataSet.Product);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        //Ascending order button, shows on top of the screen to sort units on hand in ascending order
        private void ascendingToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter.Ascending(this.productDBDataSet.Product);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        //Close button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //The End
    }
}
