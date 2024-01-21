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
//CPT 206 
//Chapter 14-Problem 4
//Lab 1
namespace Chapter14_CPT_106_Problem4
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
           
            //Loads the data of the database table into the program
            this.productTableAdapter.Fill(this.productDBDataSet.Product);
            //new database context
            newProductDataContext db = new newProductDataContext();
            foreach (Product item in db.Products)
            {


            }



        }


        //On click even of the search product Number button
            private void searchButton_Click(object sender, EventArgs e)
            {
            //Call the data context again
            newProductDataContext db = new newProductDataContext();
            //make a new variable to filter the data in the table
            var results = from product in db.Products
                          //query to only select where the product number in the table
                          //matches the text in the ProductTextBox
                          where product.Product_Number.Contains(productTextBox.Text)
                          //Select and return values after query
                          select product;
            //display results in the datagrid
            productDataGrid.DataSource =results;

            
        }
        //2nd button, to search for description
        private void searchDesc_Click(object sender, EventArgs e)
        {
            //call data context again
            newProductDataContext db = new newProductDataContext();
            //second variable, or filter/query
            var resultsTwo = from description in db.Products
                             //Query to see if the text in the data table contains the textbox text
                             where description.Description.Contains(productDesc.Text)
                             //select the description variable
                             select description;
            //Display results in datagrid 
            productDataGrid.DataSource = resultsTwo;
        }
        //Close button 
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //the end
    }
        
    }
    

