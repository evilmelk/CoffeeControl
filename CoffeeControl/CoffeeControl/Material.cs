using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeControl
{
    public class Material
    {
        public string name;
        public enum Units {г, Кг, Л, мЛ, Шт, Упак}
        public string type;
        public string modifier;
        public double pieces;      // сколько в наличии, для кофе например
        public string unitName; // название единиц измерения: г, шт и т.д.

        public Material(string name, double pieces, string unitName, string modifier = null, string type = null)
        {
            this.name = name;
            this.pieces = pieces;
            this.unitName = unitName;
            
            if (modifier != null)
                this.name = this.name + " " + modifier;

            if (type == null)
                this.type = name;
            else 
                this.type = type;            
        }         
    }
}
