using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Viktor Golovin
//Cpt 206
//Lab1
//Chapter 14, Problem 6

namespace CPT_206_Chapter_14_Problem_6_Viktor_Golovin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDBDataSet.Product);
            //Call productData Context
            ProductsDataContext db = new ProductsDataContext();


        }
        //Adds a ascending order button to put price into ascending order
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
        //Calculate button on click event
        private void calculateButton_Click(object sender, EventArgs e)
        {
            ProductsDataContext db = new ProductsDataContext();
            //parse minimum price and maximum price as integers
            int num1 = int.Parse(minPrice.Text);
            int num2 = int.Parse(maxPrice.Text);
            //2 if statements to show a message box if 0 is entered
            if (num2 == 0)
            {
                MessageBox.Show("Please Enter a valid number");
            }
            if (num1 == 0)
            {
                MessageBox.Show("Please Enter a valid number");
            }
            
            var results = from product in db.Products
                              //Query to select where units on hand are >= num1, or =< num2
                          where product.Price >= num1
                          where product.Price <= num2
                          //Select and return values after query
                          select product;
            //display results in the datagrid
            productDataGrid.DataSource = results;
        }
        //Close program button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    //the end
}
