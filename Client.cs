using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attelier1
{
    class Client :Compte
    {
        public string nom;
        public string prenom;
        public string adresse;

        public Client() 
        {

        }

        public void ajouter_client()
        {
            Console.WriteLine(cpt);
           
            Console.WriteLine("Donner votre nom :");
            this.nom = Console.ReadLine();
            Console.WriteLine("Donner votre prenom :");
            this.prenom = Console.ReadLine();
            Console.WriteLine("Donner votre Adresse :");
            this.adresse = Console.ReadLine();
            Console.WriteLine(cpt );

            Console.WriteLine($"votre nom est : {this.nom} votre prenom est : {prenom} votre Adresse est : "+ adresse+" Votre numero de comt est : " +Compte.cpt);
           



        }
    }

}
