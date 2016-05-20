using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeControl
{
    public class Check
    {
        public string date;
        public List<Product> positions;
        public double price;
        public int workerID;
        public int checkID;        

        public Check(List<Product> positions)
        {
            this.positions = positions;
            var dateValue = System.DateTime.Now;
            this.date = dateValue.ToString("yyyy-MM-dd HH:mm:ss");
            

            foreach (Product pos in this.positions)
            {
                pos.amountPrice = pos.price * pos.posCount;
                this.price += pos.price * pos.posCount;
            }
        }

    }
}
