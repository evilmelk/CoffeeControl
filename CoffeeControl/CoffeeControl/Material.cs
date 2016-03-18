using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeControl
{
    class Material
    {
        public string name;
        public int pieces;        // сколько в наличии, для кофе например  pieces*unit
        //public double unit;    //Единицы измерений - на них умножается количество в товаре
        public string unitName; // название единиц измерения: г, шт и т.д.
    }
}
