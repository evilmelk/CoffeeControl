using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeControl
{
    public class Check
    {
        public DateTime date;
        public List<Product> positions;
        public double price;

        public Check(List<Product> positions)
        {
            this.positions = positions;
            this.date = System.DateTime.Now;

            foreach (Product pos in this.positions)
            {
                pos.amountPrice = pos.price * pos.posCount;
                this.price += pos.price * pos.posCount;
            }
        }

    }
}
