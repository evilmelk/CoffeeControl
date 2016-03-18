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

            Product Korto = new Product();
            Korto.name = "Корто";
            Korto.price = 50;
            Korto.coffee = 0.007;
            Korto.cups = 1;
            Korto.covers = 1;
            

            Product Lungo = new Product();
            Lungo.name = "Лунго";
            Lungo.price = 50;
            Lungo.coffee = 0.007;
            Lungo.cups = 1;
            Lungo.covers = 1;
            

            Product Doppio = new Product();
            Doppio.name = "Доппио";
            Doppio.price = 80;
            Doppio.coffee = 0.014;
            Doppio.cups = 1;
            Doppio.covers = 1;

            Product Americano02 = new Product();
            Americano02.name = "Американо 0,2";
            Americano02.price = 50;
            Americano02.coffee = 0.007;
            Americano02.cups = 1;
            Americano02.covers = 1;

            Product Americano03 = new Product();
            Americano03.name = "Американо 0,3";
            Americano03.price = 80;
            Americano03.coffee = 0.014;
            Americano03.cups = 1;
            Americano03.covers = 1;

            Product Americano04 = new Product();
            Americano04.name = "Американо 0,4";
            Americano04.price = 110;
            Americano04.coffee = 0.021;
            Americano04.cups = 1;
            Americano04.covers = 1;

            Product Americano05 = new Product();
            Americano05.name = "Американо 0,5";
            Americano05.price = 130;
            Americano05.coffee = 0.028;
            Americano05.cups = 1;
            Americano05.covers = 1;

            Product Capuchino02 = new Product();
            Capuchino02.name = "Капучино 0,2";
            Capuchino02.price = 75;
            Capuchino02.coffee = 0.007;
            Capuchino02.cups = 1;
            Capuchino02.covers = 1;
            Capuchino02.milk = 0.065;

            Product Capuchino03 = new Product();
            Capuchino03.name = "Капучино 0,3";
            Capuchino03.price = 100;
            Capuchino03.coffee = 0.014;
            Capuchino03.cups = 1;
            Capuchino03.covers = 1;
            Capuchino03.milk = 0.1;

            Product Capuchino04 = new Product();
            Capuchino04.name = "Капучино 0,4";
            Capuchino04.price = 125;
            Capuchino04.coffee = 0.021;
            Capuchino04.cups = 1;
            Capuchino04.covers = 1;
            Capuchino04.milk = 0.125;

            Product Capuchino05 = new Product();
            Capuchino05.name = "Капучино 0,5";
            Capuchino05.price = 150;
            Capuchino05.coffee = 0.028;
            Capuchino05.cups = 1;
            Capuchino05.covers = 1;
            Capuchino05.milk = 0.165;

            Product Latte02 = new Product();
            Latte02.name = "Латте 0,2";
            Latte02.price = 75;
            Latte02.coffee = 0.004;
            Latte02.cups = 1;
            Latte02.covers = 1;
            Latte02.milk = 0.05;

            Product Latte03 = new Product();
            Latte03.name = "Латте 0,3";
            Latte03.price = 100;
            Latte03.coffee = 0.014;
            Latte03.cups = 1;
            Latte03.covers = 1;
            Latte03.milk = 0.150;

            Product Latte04 = new Product();
            Latte04.name = "Латте 0,4";
            Latte04.price = 125;
            Latte04.coffee = 0.021;
            Latte04.cups = 1;
            Latte04.covers = 1;
            Latte04.milk = 0.200;

            Product Latte05 = new Product();
            Latte05.name = "Латте 0,5";
            Latte05.price = 150;
            Latte05.coffee = 0.021;
            Latte05.cups = 1;
            Latte05.covers = 1;
            Latte05.milk = 0.25;

            Product HotChocolate02 = new Product();
            HotChocolate02.name = "Гор. Шок. 0,2";
            HotChocolate02.price = 100;
            HotChocolate02.chokolate = 0.02;
            HotChocolate02.cups = 1;
            HotChocolate02.covers = 1;
            HotChocolate02.milk = 0.150;

            Product HotChocolate03 = new Product();
            HotChocolate03.name = "Гор. Шок. 0,3";
            HotChocolate03.price = 150;
            HotChocolate03.chokolate = 0.04;
            HotChocolate03.cups = 1;
            HotChocolate03.covers = 1;
            HotChocolate03.milk = 0.170;

            Product HotChocolate04 = new Product();
            HotChocolate04.name = "Гор. Шок. 0,4";
            HotChocolate04.price = 200;
            HotChocolate04.chokolate = 0.06;
            HotChocolate04.cups = 1;
            HotChocolate04.covers = 1;
            HotChocolate04.milk = 0.2700;

            Product HotChocolate05 = new Product();
            HotChocolate05.name = "Гор. Шок. 0,5";
            HotChocolate05.price = 250;
            HotChocolate05.chokolate = 0.08;
            HotChocolate05.cups = 1;
            HotChocolate05.covers = 1;
            HotChocolate05.milk = 0.320;


            Products.Add(Korto);
            Products.Add(Lungo);
            Products.Add(Doppio);

            Products.Add(Americano02);
            Products.Add(Americano03);
            Products.Add(Americano04);
            Products.Add(Americano05);

            Products.Add(Capuchino02);
            Products.Add(Capuchino03);
            Products.Add(Capuchino04);
            Products.Add(Capuchino05);

            Products.Add(Latte02);
            Products.Add(Latte03);
            Products.Add(Latte04);
            Products.Add(Latte05);

            Products.Add(HotChocolate02);
            Products.Add(HotChocolate03);
            Products.Add(HotChocolate04);
            Products.Add(HotChocolate05);

            

            Material Milk = new Material();
            Milk.name = "Молоко";
            Milk.pieces = 20;
            Milk.unitName = "Л";

            Material Coffee = new Material();
            Coffee.name = "Кофе";
            Coffee.pieces = 2; 
            Coffee.unitName = "КГ";

            Material Chocolate = new Material();
            Chocolate.name = "Шоколад";
            Chocolate.pieces = 2;
            Chocolate.unitName = "КГ";

          
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
