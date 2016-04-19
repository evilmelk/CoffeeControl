using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeControl
{
    public class Product // класс Товар
    {
        public string name;
        public int price;
        public string portion; // порция или какой-то другой атрибут
        public List<Material> materialsForProduct;


        // Перечисление количества единиц расходников Material


        
        //public int cups;
        //public int covers;
        //public double coffee;
        //public double milk;
        //public int sugar;
        //public int cream;
        //public int syrop;
        //public double chokolate;
        //public double syropCaramel;
        //public double syropCocount1;

        

        public int posCount = 1;
        public int amountPrice = 0;

        public Product(string name, string portion, int price, 
            double coffee = 0, double milk = 0, int sugar = 0, int cream = 0, double chokolate = 0,  
            double syropCaramel1 = 0, double syropCocount1 = 0, 
            int cups = 1, int covers = 1, double spoon = 1)
        {

            this.name = name;
            this.price = price;

            this.materialsForProduct = new List<Material>();
            Material Milk = new Material("Молоко", milk, Material.Units.Л.ToString());
            Material Coffee = new Material("Кофе", coffee, Material.Units.Кг.ToString());
            Material Chocolate = new Material("Шоколад", chokolate, Material.Units.Кг.ToString());
            Material Cream = new Material("Сливки", cream, Material.Units.Л.ToString());
            Material SyropCaramel1 = new Material("Сироп: карамель", syropCaramel1, Material.Units.Л.ToString(), null, "Сиропы");
            Material SyropCocount1 = new Material("Сироп: кокос", syropCocount1, Material.Units.Л.ToString(), null, "Сиропы");
            Material Sugar = new Material("Сахар", sugar, Material.Units.Кг.ToString());

            if (portion != null)
            {
                this.name = this.name + " " + portion;
                this.portion = portion;
                Material Cup = new Material("Стакан", 1, Material.Units.Шт.ToString(), portion, "Стаканы");
                Material Cover = null;
                if (portion == "0.3")
                {
                    Cover = new Material("Крышка", 1, Material.Units.Шт.ToString(), "70мм", "Крышки");
                }
                else if (portion == "0.4")
                {
                    Cover = new Material("Крышка", 1, Material.Units.Шт.ToString(), "80мм", "Крышки");
                }
                else if (portion == "0.5")
                {
                    Cover = new Material("Крышка", 1, Material.Units.Шт.ToString(), "90мм", "Крышки");
                }                    
                else
                    Cover = new Material("Крышка", 0, Material.Units.Шт.ToString(), "70мм", "Крышки");

                Material Spoon = new Material("Ложки", spoon, Material.Units.Шт.ToString());

                materialsForProduct.Add(Cup);
                materialsForProduct.Add(Cover);
                materialsForProduct.Add(Spoon);
            }            

            materialsForProduct.Add(Coffee);
            materialsForProduct.Add(Chocolate);
            materialsForProduct.Add(Milk);
            materialsForProduct.Add(Cream);
            materialsForProduct.Add(Sugar);
            materialsForProduct.Add(SyropCaramel1);
            materialsForProduct.Add(SyropCocount1);            
        }
        
    }
}
