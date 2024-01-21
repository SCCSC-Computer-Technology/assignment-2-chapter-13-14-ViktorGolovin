
namespace Chapter14_CPT_106_Problem4
{
    partial class Form1
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
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productDesc = new System.Windows.Forms.TextBox();
            this.productDBDataSet = new Chapter14_CPT_106_Problem4.ProductDBDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Chapter14_CPT_106_Problem4.ProductDBDataSetTableAdapters.ProductTableAdapter();
            this.searchButton = new System.Windows.Forms.Button();
            this.productDataGrid = new System.Windows.Forms.DataGridView();
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.searchDesc = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(195, 332);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(129, 26);
            this.productTextBox.TabIndex = 2;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(60, 338);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(89, 20);
            this.productLabel.TabIndex = 3;
            this.productLabel.Text = "Product ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Desc.";
            // 
            // productDesc
            // 
            this.productDesc.Location = new System.Drawing.Point(584, 332);
            this.productDesc.Name = "productDesc";
            this.productDesc.Size = new System.Drawing.Size(129, 26);
            this.productDesc.TabIndex = 5;
            // 
            // productDBDataSet
            // 
            this.productDBDataSet.DataSetName = "ProductDBDataSet";
            this.productDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productDBDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(147, 406);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(160, 33);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search Product";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // productDataGrid
            // 
            this.productDataGrid.AutoGenerateColumns = false;
            this.productDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNumberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitsOnHandDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.productDataGrid.DataSource = this.productBindingSource1;
            this.productDataGrid.Location = new System.Drawing.Point(74, 12);
            this.productDataGrid.Name = "productDataGrid";
            this.productDataGrid.RowHeadersWidth = 62;
            this.productDataGrid.RowTemplate.Height = 28;
            this.productDataGrid.Size = new System.Drawing.Size(896, 281);
            this.productDataGrid.TabIndex = 8;
            // 
            // productNumberDataGridViewTextBoxColumn
            // 
            this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "Product_Number";
            this.productNumberDataGridViewTextBoxColumn.HeaderText = "Product_Number";
            this.productNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
            this.productNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitsOnHandDataGridViewTextBoxColumn
            // 
            this.unitsOnHandDataGridViewTextBoxColumn.DataPropertyName = "Units_On_Hand";
            this.unitsOnHandDataGridViewTextBoxColumn.HeaderText = "Units_On_Hand";
            this.unitsOnHandDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitsOnHandDataGridViewTextBoxColumn.Name = "unitsOnHandDataGridViewTextBoxColumn";
            this.unitsOnHandDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.productDBDataSet;
            // 
            // searchDesc
            // 
            this.searchDesc.Location = new System.Drawing.Point(525, 406);
            this.searchDesc.Name = "searchDesc";
            this.searchDesc.Size = new System.Drawing.Size(188, 33);
            this.searchDesc.TabIndex = 9;
            this.searchDesc.Text = "Search Description";
            this.searchDesc.UseVisualStyleBackColor = true;
            this.searchDesc.Click += new System.EventHandler(this.searchDesc_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(367, 391);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 62);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Close";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 551);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchDesc);
            this.Controls.Add(this.productDataGrid);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.productDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.productTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab1 Viktor Golovin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productDesc;
        private ProductDBDataSet productDBDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ProductDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView productDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsOnHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.Button searchDesc;
        private System.Windows.Forms.Button exitButton;
    }
}

