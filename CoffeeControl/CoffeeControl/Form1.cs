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
        double sumPrice = 0;
        int s = 0; int m = 0; int sumTime = 0;
        public List<Product> Products = new List<Product>();
        public List<Material> Materials = new List<Material>();
        public List<Product> currentPositions = new List<Product>();
        public List<Check> currentChecks = new List<Check>();

        List<Shop> Shops = new List<Shop>();

        List<Worker> Workers = new List<Worker>();

        public Form1()
        {

            InitializeComponent();
            loadAllData();
        }

        public void updateMaterials()
        {
            Materials = Data.Materials;
        }


        //Загрузить все данные программы
        private void loadAllData()
        {

            Product Korto = new Product("Корто", null, 50, 0.007);


            Product Lungo = new Product("Лунго", null, 50, 0.007);

            Product Doppio = new Product("Доппио", null, 80, 0.014);

            Product Americano02 = new Product("Американо","0.2", 50, 0.007);

            Product Americano03 = new Product("Американо", "0.3", 80, 0.014);

            //Product Americano04 = new Product();
            //Americano04.name = "Американо 0,4";
            //Americano04.price = 110;
            //Americano04.coffee = 0.021;
            //Americano04.cups = 1;
            //Americano04.covers = 1

            //Product Americano05 = new Product();
            //Americano05.name = "Американо 0,5";
            //Americano05.price = 130;
            //Americano05.coffee = 0.028;
            //Americano05.cups = 1;
            //Americano05.covers = 1;

            //Product Capuchino02 = new Product();
            //Capuchino02.name = "Капучино 0,2";
            //Capuchino02.price = 75;
            //Capuchino02.coffee = 0.007;
            //Capuchino02.cups = 1;
            //Capuchino02.covers = 1;
            //Capuchino02.milk = 0.065;

            //Product Capuchino03 = new Product();
            //Capuchino03.name = "Капучино 0,3";
            //Capuchino03.price = 100;
            //Capuchino03.coffee = 0.014;
            //Capuchino03.cups = 1;
            //Capuchino03.covers = 1;
            //Capuchino03.milk = 0.1;

            //Product Capuchino04 = new Product();
            //Capuchino04.name = "Капучино 0,4";
            //Capuchino04.price = 125;
            //Capuchino04.coffee = 0.021;
            //Capuchino04.cups = 1;
            //Capuchino04.covers = 1;
            //Capuchino04.milk = 0.125;

            //Product Capuchino05 = new Product();
            //Capuchino05.name = "Капучино 0,5";
            //Capuchino05.price = 150;
            //Capuchino05.coffee = 0.028;
            //Capuchino05.cups = 1;
            //Capuchino05.covers = 1;
            //Capuchino05.milk = 0.165;

            //Product Latte02 = new Product();
            //Latte02.name = "Латте 0,2";
            //Latte02.price = 75;
            //Latte02.coffee = 0.004;
            //Latte02.cups = 1;
            //Latte02.covers = 1;
            //Latte02.milk = 0.05;

            //Product Latte03 = new Product();
            //Latte03.name = "Латте 0,3";
            //Latte03.price = 100;
            //Latte03.coffee = 0.014;
            //Latte03.cups = 1;
            //Latte03.covers = 1;
            //Latte03.milk = 0.150;

            //Product Latte04 = new Product();
            //Latte04.name = "Латте 0,4";
            //Latte04.price = 125;
            //Latte04.coffee = 0.021;
            //Latte04.cups = 1;
            //Latte04.covers = 1;
            //Latte04.milk = 0.200;

            //Product Latte05 = new Product();
            //Latte05.name = "Латте 0,5";
            //Latte05.price = 150;
            //Latte05.coffee = 0.021;
            //Latte05.cups = 1;
            //Latte05.covers = 1;
            //Latte05.milk = 0.25;

            //Product HotChocolate02 = new Product();
            //HotChocolate02.name = "Гор. Шок. 0,2";
            //HotChocolate02.price = 100;
            //HotChocolate02.chokolate = 0.02;
            //HotChocolate02.cups = 1;
            //HotChocolate02.covers = 1;
            //HotChocolate02.milk = 0.150;

            //Product HotChocolate03 = new Product();
            //HotChocolate03.name = "Гор. Шок. 0,3";
            //HotChocolate03.price = 150;
            //HotChocolate03.chokolate = 0.04;
            //HotChocolate03.cups = 1;
            //HotChocolate03.covers = 1;
            //HotChocolate03.milk = 0.170;

            //Product HotChocolate04 = new Product();
            //HotChocolate04.name = "Гор. Шок. 0,4";
            //HotChocolate04.price = 200;
            //HotChocolate04.chokolate = 0.06;
            //HotChocolate04.cups = 1;
            //HotChocolate04.covers = 1;
            //HotChocolate04.milk = 0.2700;

            //Product HotChocolate05 = new Product();
            //HotChocolate05.name = "Гор. Шок. 0,5";
            //HotChocolate05.price = 250;
            //HotChocolate05.chokolate = 0.08;
            //HotChocolate05.cups = 1;
            //HotChocolate05.covers = 1;
            //HotChocolate05.milk = 0.320;

            //Product SyropCaramel = new Product();
            //SyropCaramel.name = "Крамел. Сир.";
            //SyropCaramel.price = 10;
            //SyropCaramel.SyropCaramel1 = 0.01;

            Product SyropCocount = new Product("Кокос. Сир.", null, 10, 0, 0, 0, 0, 0, 0, 0.01);


            Products.Add(Korto);
            Products.Add(Lungo);
            Products.Add(Doppio);

            Products.Add(Americano02);
            Products.Add(Americano03);
            //Products.Add(Americano04);
            //Products.Add(Americano05);

            //Products.Add(Capuchino02);
            //Products.Add(Capuchino03);
            //Products.Add(Capuchino04);
            //Products.Add(Capuchino05);

            //Products.Add(Latte02);
            //Products.Add(Latte03);
            //Products.Add(Latte04);
            //Products.Add(Latte05);

            //Products.Add(HotChocolate02);
            //Products.Add(HotChocolate03);
            //Products.Add(HotChocolate04);
            //Products.Add(HotChocolate05);

            //Products.Add(SyropCaramel);
            Products.Add(SyropCocount);


            Material Milk = new Material("Молоко", 20, Material.Units.Л.ToString());
            Material Coffee = new Material("Кофе", 2, Material.Units.Кг.ToString());
            Material Chocolate = new Material("Шоколад", 2, Material.Units.Кг.ToString());

            Material Cup01 = new Material("Стакан", 100, Material.Units.Шт.ToString(), "0.1", "Стаканы");// Material.Types.Стаканы.ToString());
            Material Cup02 = new Material("Стакан", 100, Material.Units.Шт.ToString(), "0.2", "Стаканы");// Material.Types.Стаканы.ToString());
            Material Cup03 = new Material("Стакан", 100, Material.Units.Шт.ToString(), "0.3", "Стаканы");// Material.Types.Стаканы.ToString());
            Material Cup04 = new Material("Стакан", 100, Material.Units.Шт.ToString(), "0.4", "Стаканы");// Material.Types.Стаканы.ToString());
            Material Cup05 = new Material("Стакан", 100, Material.Units.Шт.ToString(), "0.5", "Стаканы");// Material.Types.Стаканы.ToString());

            Material Covers70 = new Material("Крышка", 100, Material.Units.Шт.ToString(), "70мм", "Крышки");// Material.Types.Крышки.ToString());
            Material Covers80 = new Material("Крышка", 100, Material.Units.Шт.ToString(), "80мм", "Крышки");// Material.Types.Крышки.ToString());
            Material Covers90 = new Material("Крышка", 100, Material.Units.Шт.ToString(), "90мм", "Крышки");// Material.Types.Крышки.ToString());

            Material Spoon = new Material("Ложки", 100, Material.Units.Шт.ToString());
            Material Cream = new Material("Сливки", 20, Material.Units.Л.ToString());

            Material SyropCaramel1 = new Material("Сироп: карамель", 2, Material.Units.Л.ToString(), null, "Сиропы");// Material.Types.Сиропы.ToString());
            Material SyropCocount1 = new Material("Сироп: кокос", 2, Material.Units.Л.ToString(), null, "Сиропы");// Material.Types.Сиропы.ToString());

            Material Sugar = new Material("Сахар", 3, Material.Units.Кг.ToString());
            Material Napkins = new Material("Салфетки", 3, Material.Units.Упак.ToString());

            Materials.Add(Coffee);
            Materials.Add(Chocolate);
            Materials.Add(Milk);
            Materials.Add(Cream);
            Materials.Add(Sugar);
            Materials.Add(SyropCaramel1);
            Materials.Add(SyropCocount1);
            Materials.Add(Cup01);
            Materials.Add(Cup02);
            Materials.Add(Cup03);
            Materials.Add(Cup04);
            Materials.Add(Cup05);
            Materials.Add(Covers70);
            Materials.Add(Covers80);
            Materials.Add(Covers90);
            Materials.Add(Spoon);
            Materials.Add(Napkins);

            Shop Barviha = new Shop();
            Barviha.title = "Барвиха";

            Shop Kreml = new Shop();
            Kreml.title = "Кремль";

            Shops.Add(Barviha);
            Shops.Add(Kreml);

            Worker Ivanov = new Worker();
            Ivanov.name = "Иванов Василий";
            Ivanov.workerTime = 0;

            Worker Koil = new Worker();
            Koil.name = "Койл Саша";
            Koil.workerTime = 0;


            Workers.Add(Ivanov);
            Workers.Add(Koil);

            foreach (Material mat in Materials)
            {
                if (findConrtolInPanel(PanelMaterials.Controls, mat.type) == false)
                {
                    Button materialButton = new Button();
                    materialButton.Text = mat.type;
                    materialButton.Width = 96;
                    materialButton.Height = 50;
                    materialButton.BackColor = SystemColors.Menu;
                    materialButton.Click += mater_but_Click;
                    PanelMaterials.Controls.Add(materialButton);
                }
            }

            foreach (Product prod in Products)
            {
                Button productButton = new Button();
                productButton.Text = prod.name;
                productButton.Width = 96;
                productButton.Height = 50;
                productButton.BackColor = SystemColors.Menu;
                productButton.Click += but_Click;
                productButton.MouseWheel += but_Click_remove_one;
                PanelProducts.Controls.Add(productButton);
            }

            foreach (Shop mag in Shops)
            {
                ShopsBox.Items.Add(mag.title);
            }

            foreach (Worker work in Workers)
            {
                WorkerBox.Items.Add(work.name);
            }

        }


        /// <summary>
        /// Функция создает форму для группы расходников
        /// </summary>
        /// <param name="type">Тип расходников (Группа расходников)</param>
        private void openMaterialForm(string type)
        {
            Data.Materials = Materials;
            MaterialsForm materialsForm = new MaterialsForm(type);
            materialsForm.Owner = this;
            materialsForm.ShowDialog();
            updateMaterials();
        }


        /// <summary>
        /// Функция определяет, был ли добавлен контрол на панель или нет
        /// </summary>
        /// <param name="ControlCollection">Коллекция контролов</param>
        /// <param name="ControlName">Название контрола, наличие которого проверяется</param>
        /// <returns>true - если такой контрол с таким названием уже был добавлен, false - в противном случае</returns>
        private bool findConrtolInPanel(Panel.ControlCollection ControlCollection, string ControlName)
        {
            foreach (Control cont in ControlCollection)
            {
                if (cont.Text == ControlName)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Функция добавляет название позиции в чек
        /// </summary>
        /// <param name="positionName">Название позиции</param>
        public void addPositionToCheck(string positionName)
        {
            string summOfCheck = "\t\t\t\t\t\t\t" + "Итог:  " + sumPrice + "р.";

            foreach (Product prod in Products)
            {
                if (positionsList.Items.Contains(summOfCheck))
                {
                    positionsList.Items.Remove(summOfCheck);
                }

                if (prod.name == positionName)
                {
                    string position = prod.name + "\t\t" + prod.posCount + " шт. \t\t" + prod.price * prod.posCount + " р.";
                    if (positionsList.Items.Contains(position))
                    {
                        prod.posCount++;
                        currentPositions.Remove(prod);
                        positionsList.Items.Remove(position);
                    }
                    sumPrice += prod.price;
                    position = prod.name + "\t\t" + prod.posCount + " шт. \t\t" + prod.price * prod.posCount + " р.";
                    currentPositions.Add(prod);
                    positionsList.Items.Add(position);
                }

                if (positionsList.Items.Contains(summOfCheck))
                {
                    positionsList.Items.Remove(summOfCheck);
                }

            }
            summOfCheck = "\t\t\t\t\t\t\t" + "Итог:  " + sumPrice + "р.";
            positionsList.Items.Add(summOfCheck);
        }

        public void dealWithIt()
        {
            Check check = new Check(currentPositions);
            foreach (Product position in currentPositions)
            {
                foreach (Material mat in Materials)
                {
                    foreach (Material posMat in position.materialsForProduct)
                    {
                        if (posMat.name == mat.name)
                            mat.pieces = mat.pieces - position.posCount * posMat.pieces;
                    }
                }
            }
            currentChecks.Add(check);
            currentPositions = new List<Product>();
            positionsList.Items.Clear();
        }

        public void delPositionToCheck(string positionName)
        {
            string summOfCheck = "\t\t\t\t\t\t\t" + "Итог:  " + sumPrice + "р.";

            foreach (Product prod in Products)
            {
                if (positionsList.Items.Contains(summOfCheck))
                {
                    positionsList.Items.Remove(summOfCheck);
                }

                if (prod.name == positionName)
                {
                    string position = prod.name + "\t\t" + prod.posCount + " шт. \t\t" + prod.price * prod.posCount + " р.";
                    if (positionsList.Items.Contains(position))
                    {
                        prod.posCount--;
                        positionsList.Items.Remove(position);
                    }
                    sumPrice -= prod.price;
                    position = prod.name + "\t\t" + prod.posCount + " шт. \t\t" + prod.price * prod.posCount + " р.";
                    positionsList.Items.Add(position);
                }

                if (positionsList.Items.Contains(summOfCheck))
                {
                    positionsList.Items.Remove(summOfCheck);
                }

            }
            summOfCheck = "\t\t\t\t\t\t\t" + "Итог:  " + sumPrice + "р.";
            positionsList.Items.Add(summOfCheck);
        }

        // событие по нажатию кнопки товара
        private void but_Click(object sender, EventArgs e)
        {
            string posName = ((Button)sender).Text;
            addPositionToCheck(posName);
        }

        private void but_Click_remove_one(object sender, EventArgs e)
        {
            string posName = ((Button)sender).Text;
            delPositionToCheck(posName);
        }

        // cобытие по нажатию кнопки группы расходников
        private void mater_but_Click(object sender, EventArgs e)
        {
            string materName = ((Button)sender).Text;
            openMaterialForm(materName);
        }




        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ProductsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //старт
        {
            timer1.Start();
            s = 0; m = 0;
        }

        private void button14_Click(object sender, EventArgs e) //Стоп
        {
            timer1.Stop();
            foreach (Worker work in Workers)
            {
                if (work.name == WorkerBox.SelectedItem)
                {
                    work.workerTime += m; sumTime = work.workerTime;
                    //  textBox1.Text = "Общ. t= " + Convert.ToString( work.workerTime );

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            textBox1.Text = "Общ. t= " + sumTime;
            // textBox1.Text = "Тек. t= " + Convert.ToString(m);

            s++;
            if (s == 600)
            {
                m++;
                s = 0;
                sumTime++;

            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            currentPositions = new List<Product>();
            positionsList.Items.Clear();
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            dealWithIt();
        }


    }
}
