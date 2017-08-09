using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppleStoreLibrary;

namespace Example02
{
    public partial class MainWindow : Form
    {
        public Product[] Products;
        public int Total;

        public MainWindow()
        {
            InitializeComponent();
            Products = new Product[]
             {
                new Product()
                {
                Id = 1,
                Name = "iPhone 7",
                Price = 28900,
                Categories = new string[] { "iPhone" }
                },
                new Product()
                {
                Id = 2,
                Name = "iPhone 7 plus",
                Price = 31900,
                Categories = new string[] { "iPhone" }
                }
             };
        }

        Total = 0;

        private void AddProduct1Button_Click(object sender, EventArgs e)
        {
            ShoppingCartRichTextBox.Text = ShoppingCartRichTextBox.Text + Products[0].Name + "\n";
            Total += Products[0].Price;
            TotallLabel.Text
        }

        private void AddProduct2Button_Click(object sender, EventArgs e)
        {
            ShoppingCartRichTextBox.Text = ShoppingCartRichTextBox.Text + Products[1].Name + "\n";
            Total += Products[1].Price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Total = 0;
            ShoppingCartRichTextBox.Text = "";
        }
    }
}