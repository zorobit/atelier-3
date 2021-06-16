using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviseLibrary
{
    public abstract class Devise : IDevise
    {
        private double valeur;
        private string type;

        public Devise(double val,string type)
        {
            this.valeur = val;
            this.type = type;
        }

        public void afficherDevise()
        {
            Console.WriteLine(this.valeur + " " + this.type);
        }
        // surcharge des operateurs 

        public static bool operator >(Devise m1, Devise m2)
        {
            if (m1.GetType() == m2.GetType())
            {
                return (m1.valeur > m2.valeur);
            }
            else
            {
                Console.WriteLine("type differents");
                return false;
            }
           

        }
        public static bool operator <(Devise m1, Devise m2)
        {

            if (m1.GetType() == m2.GetType())
            {
                return (m1.valeur < m2.valeur);
            }
            else
            {
                Console.WriteLine("type differents");
                return false;
            }
        }
        public  Devise Add(Devise m1, Devise m2)
        {
            
            //  Devise res = new Devise(0); impossible
            this.valeur = m1.valeur + m2.valeur;
            return this;
        }
        public static Devise operator +(Devise m1, Devise m2)
        {
            Devise res;
            if (m1.GetType() == m2.GetType())
            {
                if(m1 is MAD)
                {
                    res = new MAD(m1.valeur + m2.valeur);
                    return res;
                }
               else if(m1 is EU)
                {
                    res = new EU(m1.valeur + m2.valeur);
                    return res;
                }
                else
                {
                    res = new US(m1.valeur + m2.valeur);
                    return res;
                }
            }
            else
            {
                Console.WriteLine("types diferrents");
                return null;
            }
            }
        public  Devise sub(Devise m1, Devise m2)
        {
            this.valeur = m1.valeur - m2.valeur;
            return this;
        }
        public  Devise produit(Devise m1, Devise m2)
        {
            this.valeur = m1.valeur * m2.valeur;
            return this;
        }

        public abstract Devise CovertTo(string type);
         public   double  echange(double taux)=> this.valeur * taux;


        public override string ToString()
        {
            return this.valeur+" ";
        }

    }
}
