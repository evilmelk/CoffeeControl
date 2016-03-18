using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeControl
{
    public partial class Form1 : Form
    {
        List<Product> Products = new List<Product>();
        List<Material> Materials = new List<Material>();

        public Form1()
        {
            InitializeComponent();
            

            Product Capuchino03 = new Product();
            Capuchino03.name = "Капучино 0,3";
            Capuchino03.price = 100;
            Capuchino03.coffee = 0.014;
            Capuchino03.cups = 1;
            Capuchino03.covers = 1;
            Capuchino03.milk = 0.1;

            Product Latte05 = new Product();
            Latte05.name = "Латте 0,5";
            Latte05.price = 160;
            Latte05.coffee = 0.021;
            Latte05.cups = 1;
            Latte05.covers = 1;
            Latte05.milk = 0.25;

            Products.Add(Latte05);
            Products.Add(Capuchino03);

            Material Milk = new Material();
            Milk.name = "Молоко";
            Milk.pieces = 20;
            Milk.unitName = "Л";

            Material Coffee = new Material();
            Coffee.name = "Кофе";
            Coffee.pieces = 2; 
            Coffee.unitName = "КГ";

            
            Materials.Add(Milk);
            Materials.Add(Coffee);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cup cup = new cup(); //Создаем экземпляр формы
            cup.Show(); //Выводим форму
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            foreach (Product prod in Products)
            {
                ProductsComboBox.Items.Add(prod.name);
            }
        }
    }
}
