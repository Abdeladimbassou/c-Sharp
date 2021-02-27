using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attelier1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Compte cpt1 = new Compte(1000,5000);
            cpt1.solde_cpt();
            cpt1.virment();
            cpt1.ret_arg();

            Compte cpt2 = new Compte(2000,5000);
             cpt2.solde_cpt() ;
            cpt2.ret_arg();
           */

            Client C1 = new Client();
            Client C2 = new Client();

            C1.ajouter_client();
            C1.virment();
            C1.ret_arg();
            C1.solde_cpt();

            C2.ajouter_client();
            C2.virment();
            C2.ret_arg();
            C2.solde_cpt();

            C1.virement_deb(C2);
            C2.solde_cpt();
            C1.solde_cpt();
            
            Console.ReadKey();
        }
    }
}
