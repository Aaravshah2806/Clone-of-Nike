using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NikeWebsite
{
    public partial class MenShoes : Form
    {
        public MenShoes()
        {
            InitializeComponent();
            PopulateProducts();
        }

        private void PopulateProducts()
        {
            var products = new List<Product>
            {
                new Product("Air Max Pulse", 149.99m, Properties.Resources.Gemini_Generated_Image_8g4tuo8g4tuo8g4t_removebg_preview),
                new Product("Air Zoom Pegasus", 129.99m, Properties.Resources.Gemini_Generated_Image_yekqbryekqbryekq_removebg_preview),
                new Product("Air Max 270", 159.99m, Properties.Resources.AJfQ9KSZM53uyPJx0E7BRHx___40mO9S_removebg_preview),
                new Product("Air Force 1 '07", 109.99m, Properties.Resources.Gemini_Generated_Image_q32pmyq32pmyq32p),
                new Product("Metcon 9", 139.99m, Properties.Resources.Gemini_Generated_Image_8g4tuo8g4tuo8g4t_removebg_preview),
                new Product("React Infinity Run", 169.99m, Properties.Resources.Gemini_Generated_Image_yekqbryekqbryekq_removebg_preview),
            };

            foreach (var product in products)
            {
                var card = CreateProductCard(product);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private Control CreateProductCard(Product product)
        {
            var cardPanel = new Panel
            {
                Width = 260,
                Height = 300,
                Margin = new Padding(10),
                BackColor = Color.White
            };

            var productImage = new PictureBox
            {
                Image = product.Image,
                SizeMode = PictureBoxSizeMode.Zoom,
                Width = 240,
                Height = 160,
                Left = 10,
                Top = 10
            };

            var nameLabel = new Label
            {
                Text = product.Name,
                Font = new Font("Segoe UI", 12f, FontStyle.Bold),
                AutoSize = false,
                Width = 240,
                Left = 10,
                Top = 180
            };

            var priceLabel = new Label
            {
                Text = "$" + product.Price.ToString("F2"),
                Font = new Font("Segoe UI", 12f, FontStyle.Regular),
                AutoSize = false,
                Width = 240,
                Left = 10,
                Top = 210
            };

            var addToCartButton = new Button
            {
                Text = "Add to Cart",
                BackColor = Color.Magenta,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Width = 240,
                Height = 36,
                Left = 10,
                Top = 240
            };
            addToCartButton.FlatAppearance.BorderSize = 0;
            addToCartButton.Tag = product;

            cardPanel.Controls.Add(productImage);
            cardPanel.Controls.Add(nameLabel);
            cardPanel.Controls.Add(priceLabel);
            cardPanel.Controls.Add(addToCartButton);

            return cardPanel;
        }

        private sealed class Product
        {
            public string Name { get; }
            public decimal Price { get; }
            public Image Image { get; }

            public Product(string name, decimal price, Image image)
            {
                Name = name;
                Price = price;
                Image = image;
            }
        }

        private void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var home = new Form1();
            home.Show();
            Close();
        }
    }
}
