using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPaiements
{
    internal class utilisateur
    {
        public string Nom {  get; set; }
        public List<Paiement> Paiements { get; set; }

        public utilisateur(string nom ) 

        { 
            Nom = nom;
            Paiements = new List<Paiement>();


        }
        public void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add(paiement);
        }
        public void AjouterInfos(Paiement paiement)
        {
            Console.WriteLine($"le nom est {Nom}");
            Console.WriteLine($"les differents paiements ");

            foreach( var Paiement   in Paiements)
            {
                paiement.AfficherDetails();       
            }
        }
    }
}
