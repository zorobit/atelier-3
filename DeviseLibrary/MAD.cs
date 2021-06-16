using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviseLibrary
{
    public class MAD:Devise
    {
        private double tauxEnDollar = 0.08;
        private double tauxEnEuro = 0.1;

        public MAD (double val):base(val,"MAD")
        {
        }

        public override Devise CovertTo(string type)
        {
            Devise res;
            if (type == "US")
            {
                res = new US(this.echange(tauxEnDollar));
                return res;
            }
           else if (type == "EU")
            {
                res = new EU(this.echange(tauxEnEuro));
                return res;
            }
            Console.WriteLine("Convert invalid");
            return this;
           
        }
    }
}
