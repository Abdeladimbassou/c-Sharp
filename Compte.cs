using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attelier1
{
    class Compte
    {
        public static int cpt = 0;
        public int num_cpt;
        public double sold;
        public double ret_plaf;


        public Compte()
        {
            cpt++;
            this.num_cpt = cpt;
            this.ret_plaf = 5000;
        }
        public Compte( double sold ,double ret) 
        {
            
            this.num_cpt = cpt;
            this.sold = sold;
            ret_plaf = ret ;

        }

         public  void   solde_cpt( ) 
        {
            Console.WriteLine("Votre numero de compte est : " + this.num_cpt+" Votre solde est : " + this.sold + " MAD");
        }
        public double ret_arg()
        {
            double a;
            Console.WriteLine(" donnez le montan que voulez vous retaire");
            a = (int.Parse(Console.ReadLine()));
            if (a < 0 || a>ret_plaf)
            {
                Console.WriteLine("imposiible d'effectuer l'operation");
            }
            else
            {
            if (a < sold )
            {
                sold = sold - a;
                Console.WriteLine(" il rest " + sold + " MAD" + " Dans votre compte");

            }

                else
                {

                /* sold = (a - sold) * -1;*/
                      sold = sold - a;
                     Console.WriteLine(" votre credit est " + sold + " MAD Dans votre compte");
                }

                if (sold == 0)

                {
                    Console.WriteLine("Votre solde est : " + sold);
                }
            }
            return sold; 


            /*double k;
                    if (sold >= a)
                    {
                        a = Math.Abs(a);
                        sold = sold - a;
                        k = sold;
                        Console.WriteLine("a = "+a);
                       

                    }
                    else
                       if( a<0  )
                    {
                        a = Math.Abs(-a);
                        sold = sold - a;

                        k = sold;
                        
                    }
                    else
                        Console.WriteLine("Votre solde est epuise");
                    x*/
           

        }

        public  double  virment( )
        {
            double a;
            Console.WriteLine(" donnez le montan que voulez vous virser ");
            a = (int.Parse(Console.ReadLine()));
            sold = sold + a;
            Console.WriteLine("Votre solde devient " + sold + " MAD");
             return sold ;
            
        }
        public double virement_deb(Compte cpt2)
        {
            double d, v;
            

            if (this.sold < 0) 
            {
                d = this.sold;
                Console.WriteLine("d :"+d);
                v = cpt2.sold + d;
                Console.WriteLine("cpt2.sold  :" + cpt2.sold);
                Console.WriteLine("v :" + v);
                this.sold = v;
            }
            else
            {
                d = cpt2.sold;
                v = -this.sold + d;
                cpt2.sold = v;
            }

            return v;
            
        }

    }
}
