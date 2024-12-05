
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProductCatalogApp
{
    public partial class MainForm : Form
    {
        private List<Product> products;

        public MainForm()
        {
            InitializeComponent();
            InitializeProductCatalog();
        }

        private void InitializeProductCatalog()
        {
            // Пример товаров из категории "Одежда"
            products = new List<Product>
            {
                new Product("Куртка Bape зимняя", 25000),
                new Product("Джинсы", 7000),
                new Product("Рубашка хлопковая", 1800),
                new Product("Футболка с принтом", 1200),
                new Product("Тренировочные брюки", 2500)
            };

            UpdateProductList();
        }

        private void UpdateProductList()
        {
            listBoxProducts.Items.Clear();
            foreach (var product in products)
            {
                listBoxProducts.Items.Add($"{product.Name} - {product.Price} руб.");
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var newProduct = new Product("Тренировочные брюки", 1500);
            products.Add(newProduct);
            UpdateProductList();
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
