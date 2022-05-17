using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_Mindbox_SQL.Data;

namespace Test_Mindbox_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void AddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                using AppDbContext context = new AppDbContext();
                await context.Products.AddAsync(new Product()
                {
                    Name = ProductName.Text,
                    Price = decimal.Parse(ProductPrice.Text),
                    Categories = new List<Category>()
                {
                    new Category
                    {
                        Name = ProductCategory.Text
                    }
                }
                });
                await context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private async void RefreshProductList_Click(object sender, EventArgs e)
        {
            ProductList.Items.Clear();

            using AppDbContext context = new AppDbContext();
            var p = await context.Products
                .Include(x => x.Categories)
                .AsNoTracking()
                .ToListAsync();

            foreach(var c in p)
            {
                string categories = "";
                foreach (var s in c.Categories) categories += s.Name + " ";
                ProductList.Items.Add($"{c.Id} {c.Name} {c.Price} {categories}");
            }
        }

        private async void AddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                using AppDbContext context = new AppDbContext();
                var product = await context.Products
                    .Include(x => x.Categories)
                    .FirstOrDefaultAsync(x => EF.Functions.Like(x.Name, CategoryProductName.Text));
                product.Categories.Add(new Category() { Name = CategoryName.Text });
                await context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void RefreshCategoryList_Click(object sender, EventArgs e)
        {
            CategoryList.Items.Clear();

            using AppDbContext context = new AppDbContext();
            var p = await context.Categories
                .AsNoTracking()
                .ToListAsync();

            foreach (var c in p) CategoryList.Items.Add($"{c.Id} {c.Name}");            
        }
    }
}
