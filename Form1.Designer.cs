namespace Test_Mindbox_SQL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductList = new System.Windows.Forms.ListBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddCategory = new System.Windows.Forms.Button();
            this.CategoryList = new System.Windows.Forms.ListBox();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.RefreshProductList = new System.Windows.Forms.Button();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.RefreshCategoryList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(69, 277);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(100, 23);
            this.AddProduct.TabIndex = 0;
            this.AddProduct.Text = "Добавить";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Продукты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.HorizontalScrollbar = true;
            this.ProductList.ItemHeight = 15;
            this.ProductList.Location = new System.Drawing.Point(49, 80);
            this.ProductList.Name = "ProductList";
            this.ProductList.ScrollAlwaysVisible = true;
            this.ProductList.Size = new System.Drawing.Size(150, 94);
            this.ProductList.TabIndex = 4;
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(49, 207);
            this.ProductName.Name = "ProductName";
            this.ProductName.PlaceholderText = "Название";
            this.ProductName.Size = new System.Drawing.Size(150, 23);
            this.ProductName.TabIndex = 5;
            this.ProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(48, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Добавить продукт";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductCategory
            // 
            this.ProductCategory.Location = new System.Drawing.Point(49, 227);
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.PlaceholderText = "Категория";
            this.ProductCategory.Size = new System.Drawing.Size(150, 23);
            this.ProductCategory.TabIndex = 7;
            this.ProductCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(233, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Добавить категорию";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryProductName
            // 
            this.CategoryProductName.Location = new System.Drawing.Point(233, 205);
            this.CategoryProductName.Name = "CategoryProductName";
            this.CategoryProductName.PlaceholderText = "Название товара";
            this.CategoryProductName.Size = new System.Drawing.Size(150, 23);
            this.CategoryProductName.TabIndex = 11;
            this.CategoryProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(234, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Категории";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddCategory
            // 
            this.AddCategory.Location = new System.Drawing.Point(254, 254);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(100, 23);
            this.AddCategory.TabIndex = 8;
            this.AddCategory.Text = "Добавить";
            this.AddCategory.UseVisualStyleBackColor = true;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // CategoryList
            // 
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.HorizontalScrollbar = true;
            this.CategoryList.ItemHeight = 15;
            this.CategoryList.Location = new System.Drawing.Point(233, 80);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.ScrollAlwaysVisible = true;
            this.CategoryList.Size = new System.Drawing.Size(150, 94);
            this.CategoryList.TabIndex = 13;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Location = new System.Drawing.Point(49, 248);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.PlaceholderText = "Цена";
            this.ProductPrice.Size = new System.Drawing.Size(150, 23);
            this.ProductPrice.TabIndex = 14;
            this.ProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RefreshProductList
            // 
            this.RefreshProductList.BackColor = System.Drawing.Color.IndianRed;
            this.RefreshProductList.Location = new System.Drawing.Point(69, 306);
            this.RefreshProductList.Name = "RefreshProductList";
            this.RefreshProductList.Size = new System.Drawing.Size(100, 23);
            this.RefreshProductList.TabIndex = 15;
            this.RefreshProductList.Text = "Обновить";
            this.RefreshProductList.UseVisualStyleBackColor = false;
            this.RefreshProductList.Click += new System.EventHandler(this.RefreshProductList_Click);
            // 
            // CategoryName
            // 
            this.CategoryName.Location = new System.Drawing.Point(233, 225);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.PlaceholderText = "Категория";
            this.CategoryName.Size = new System.Drawing.Size(150, 23);
            this.CategoryName.TabIndex = 16;
            this.CategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RefreshCategoryList
            // 
            this.RefreshCategoryList.Location = new System.Drawing.Point(254, 283);
            this.RefreshCategoryList.Name = "RefreshCategoryList";
            this.RefreshCategoryList.Size = new System.Drawing.Size(100, 23);
            this.RefreshCategoryList.TabIndex = 17;
            this.RefreshCategoryList.Text = "Обновить";
            this.RefreshCategoryList.UseVisualStyleBackColor = true;
            this.RefreshCategoryList.Click += new System.EventHandler(this.RefreshCategoryList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.RefreshCategoryList);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.RefreshProductList);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoryProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddCategory);
            this.Controls.Add(this.ProductCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CategoryProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.ListBox CategoryList;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Button RefreshProductList;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.Button RefreshCategoryList;
    }
}
