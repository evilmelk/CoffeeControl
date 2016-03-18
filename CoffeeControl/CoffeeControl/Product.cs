using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeControl
{
    public class Product // класс Товар
    {
        public string name = "Название товара";
        public int price = 100;
        // Перечисление количества единиц расходников Material
        public int cups = 0;
        public int covers = 0;
        public double coffee = 0;
        public double milk = 0;
        public int sugar = 0;
        public int cream = 0;
        public int syrop = 0;
    }
}
