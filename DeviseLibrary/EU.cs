using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviseLibrary
{
 public   class EU:Devise
    {
        private double tauxEnDollar = 1.19;
        private double tauxEnMAD = 10.68;
        public EU(double val): base(val, "EU")
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
            else if (type == "MAD")
            {
                res = new MAD(this.echange(tauxEnMAD));
                return res;
            }
            Console.WriteLine("Convert invalid");
            return this;
        }
    }
}
