
namespace CPT_206_Chapter_14_Problem_5_Viktor_Golovin
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
            this.productDataGrid = new System.Windows.Forms.DataGridView();
            this.moreThanText = new System.Windows.Forms.TextBox();
            this.lessThanText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.ascendingToolStrip = new System.Windows.Forms.ToolStrip();
            this.ascendingToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDBDataSet = new CPT_206_Chapter_14_Problem_5_Viktor_Golovin.ProductDBDataSet();
            this.productTableAdapter = new CPT_206_Chapter_14_Problem_5_Viktor_Golovin.ProductDBDataSetTableAdapters.ProductTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).BeginInit();
            this.ascendingToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.productDataGrid.DataSource = this.productBindingSource;
            this.productDataGrid.Location = new System.Drawing.Point(57, 37);
            this.productDataGrid.Name = "productDataGrid";
            this.productDataGrid.RowHeadersWidth = 62;
            this.productDataGrid.RowTemplate.Height = 28;
            this.productDataGrid.Size = new System.Drawing.Size(825, 301);
            this.productDataGrid.TabIndex = 0;
            // 
            // moreThanText
            // 
            this.moreThanText.Location = new System.Drawing.Point(295, 371);
            this.moreThanText.Name = "moreThanText";
            this.moreThanText.Size = new System.Drawing.Size(100, 26);
            this.moreThanText.TabIndex = 1;
            // 
            // lessThanText
            // 
            this.lessThanText.Location = new System.Drawing.Point(450, 371);
            this.lessThanText.Name = "lessThanText";
            this.lessThanText.Size = new System.Drawing.Size(100, 26);
            this.lessThanText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Units On hand >";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "<";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(574, 365);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(149, 39);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ascendingToolStrip
            // 
            this.ascendingToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ascendingToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripButton});
            this.ascendingToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ascendingToolStrip.Name = "ascendingToolStrip";
            this.ascendingToolStrip.Size = new System.Drawing.Size(1000, 34);
            this.ascendingToolStrip.TabIndex = 7;
            this.ascendingToolStrip.Text = "ascendingToolStrip";
            // 
            // ascendingToolStripButton
            // 
            this.ascendingToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ascendingToolStripButton.Name = "ascendingToolStripButton";
            this.ascendingToolStripButton.Size = new System.Drawing.Size(99, 29);
            this.ascendingToolStripButton.Text = "Ascending";
            this.ascendingToolStripButton.Click += new System.EventHandler(this.ascendingToolStripButton_Click);
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
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productDBDataSet;
            // 
            // productDBDataSet
            // 
            this.productDBDataSet.DataSetName = "ProductDBDataSet";
            this.productDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ascendingToolStrip);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lessThanText);
            this.Controls.Add(this.moreThanText);
            this.Controls.Add(this.productDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).EndInit();
            this.ascendingToolStrip.ResumeLayout(false);
            this.ascendingToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productDataGrid;
        private ProductDBDataSet productDBDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ProductDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsOnHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox moreThanText;
        private System.Windows.Forms.TextBox lessThanText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ToolStrip ascendingToolStrip;
        private System.Windows.Forms.ToolStripButton ascendingToolStripButton;
        private System.Windows.Forms.Button button1;
    }
}

