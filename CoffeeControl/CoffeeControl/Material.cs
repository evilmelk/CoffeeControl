namespace CoffeeControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Material
    {
        public int materials_id;
        public string name { get; set; }
        public enum Units {г, Кг, Л, мЛ, Шт, Упак}
        public string type { get; set; }
        public string modifier { get; set; }
        public double pieces { get; set; }      // сколько в наличии, для кофе например
        public string unitName { get; set; } // название единиц измерения: г, шт и т.д.

        public Material createMaterial (string name, double pieces, string unitName, string modifier = null, string type = null)
        {
            this.name = name;
            this.pieces = pieces;
            this.unitName = unitName;


            if (modifier != null)
            {
                this.name = this.name + " " + modifier;
                this.modifier = modifier;
            }

            if (type == null)
                this.type = name;
            else 
                this.type = type;
            return this;
        }         
    }
}
