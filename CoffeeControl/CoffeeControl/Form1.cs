using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script;

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


        public string GET_http(string url = "http://localhost/coffee-control.ru/materials.php"){
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            System.Net.WebRequest reqGET = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = reqGET.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            string html = sr.ReadToEnd();
            Console.WriteLine(html);
            
            textBox3.Text = html;
         //   [{"materials_id":"1","name":"stacan 01","pieces":"2","unitName":null,"modifier":null}]
           
            return html;
        }


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
            Product Americano04 = new Product("Американо", "0.4", 110, 0.021);
            Product Americano05 = new Product("Американо", "0.5", 140, 0.028);

            Product Capuchino02 = new Product("Капучино", "0.2", 85, 0.007, 65);
            Product Capuchino03 = new Product("Капучино", "0.3", 120, 0.014, 100);
            Product Capuchino04 = new Product("Капучино", "0.4", 155, 0.021, 130);
            Product Capuchino05 = new Product("Капучино", "0.5", 190, 0.028, 160);

            
            Product Latte02 = new Product("Латте","0.2", 85, 0.007, 100);
            Product Latte03 = new Product("Латте", "0.3", 120, 0.007, 150);
            Product Latte04 = new Product("Латте", "0.4", 155, 0.007, 200);
            Product Latte05 = new Product("Латте", "0.5", 190, 0.007, 250);

            Product HotChocolate02 = new Product ("Гор. шок.", "0.2", 110, 0, 120, 0, 0,0.035);
            Product HotChocolate03 = new Product ("Гор. шок.", "0.3", 145, 0, 180, 0, 0, 0.070);
            Product HotChocolate04 = new Product ("Гор. шок.", "0.4", 180, 0, 240, 0, 0, 0.135);
            Product HotChocolate05 = new Product("Гор. шок.", "0.5", 215, 0, 300, 0, 0, 0.170);

            Product SyropCaramel = new Product("Карамел. Сир.", "0.01", 10, 0, 0, 0, 0, 0, 0.01);   
            Product SyropCocount = new Product("Кокос. Сир.", "0.01", 10, 0, 0, 0, 0, 0, 0, 0.01);


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

            Products.Add(SyropCaramel);
            Products.Add(SyropCocount);


            Material Milk = new Material();
            Milk = Milk.createMaterial("Молоко", 20, Material.Units.Л.ToString());

            Material Coffee = new Material();
            Coffee = Coffee.createMaterial("Кофе", 2, Material.Units.Кг.ToString());
            Material Chocolate = new Material();
            Chocolate = Chocolate.createMaterial("Шоколад", 2, Material.Units.Кг.ToString());

            Material Cup01 = new Material();
            Cup01 = Cup01.createMaterial("Стакан", 100, Material.Units.Шт.ToString(), "0.1", "Стаканы");// Material.Types.Стаканы.ToString());
            Material Cup02 = new Material();
            Cup02 = Cup02.createMaterial("Стакан", 100, Material.Units.Шт.ToString(), "0.2", "Стаканы");// Material.Types.Стаканы.ToString());
            Material Cup03 = new Material();
            Cup03 = Cup03.createMaterial("Стакан", 100, Material.Units.Шт.ToString(), "0.3", "Стаканы");// Material.Types.Стаканы.ToString());
            Material Cup04 = new Material();
            Cup04 = Cup04.createMaterial("Стакан", 100, Material.Units.Шт.ToString(), "0.4", "Стаканы");// Material.Types.Стаканы.ToString());
            Material Cup05 = new Material();
            Cup05 = Cup05.createMaterial("Стакан", 100, Material.Units.Шт.ToString(), "0.5", "Стаканы");// Material.Types.Стаканы.ToString());

            Material Covers70 = new Material();
            Covers70 = Covers70.createMaterial("Крышка", 100, Material.Units.Шт.ToString(), "70мм", "Крышки");// Material.Types.Крышки.ToString());
            Material Covers80 = new Material();
            Covers80 = Covers80.createMaterial("Крышка", 100, Material.Units.Шт.ToString(), "80мм", "Крышки");// Material.Types.Крышки.ToString());
            Material Covers90 = new Material();
            Covers90 = Covers90.createMaterial("Крышка", 100, Material.Units.Шт.ToString(), "90мм", "Крышки");// Material.Types.Крышки.ToString());

            Material Spoon = new Material();
            Spoon = Spoon.createMaterial("Ложки", 100, Material.Units.Шт.ToString());
            Material Cream = new Material();
            Cream = Cream.createMaterial("Сливки", 20, Material.Units.Л.ToString());

            Material SyropCaramel1 = new Material();
            SyropCaramel1 = SyropCaramel1.createMaterial("Сироп: карамель", 2, Material.Units.Л.ToString(), null, "Сиропы");// Material.Types.Сиропы.ToString());
            Material SyropCocount1 = new Material();
            SyropCocount1 = SyropCocount1.createMaterial("Сироп: кокос", 2, Material.Units.Л.ToString(), null, "Сиропы");// Material.Types.Сиропы.ToString());

            Material Sugar = new Material();
            Sugar = Sugar.createMaterial("Сахар", 3, Material.Units.Кг.ToString());
            Material Napkins = new Material();
            Napkins = Napkins.createMaterial("Салфетки", 3, Material.Units.Упак.ToString());

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
            GET_http();

        }

        public string GET_http(string url)
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            System.Net.WebRequest reqGET = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = reqGET.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            string json = sr.ReadToEnd();
            return json;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "http://localhost/coffeeControl/getMaterials.php";
            string json = GET_http(url);
            //sysMsgTextBox.Text = json;

            List<Material> responseMaterialsList = new List<Material>();

            responseMaterialsList = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<List<Material>>(json);

            foreach (Material mat in Materials)
            {
                foreach (Material respMat in responseMaterialsList)
                {
                    if (respMat.name == mat.name)
                        mat.pieces = respMat.pieces;
                }
            }
            sysMsgTextBox.Text = "Синхронизировано с БД";
            //responseMaterialsList = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<List<Material>>(json);

        }


    }
}
