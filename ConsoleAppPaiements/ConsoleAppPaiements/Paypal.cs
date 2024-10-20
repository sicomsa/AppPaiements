using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPaiements
{
    internal class Paypal : Paiement
    {
        public string Courriel {  get; set; }

        public Paypal(double montant, string description , string courriel) : base(montant , description)

        { 
            Courriel = courriel;

        }

        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"le montant correspond a {Montant} , avec pour description  {Description} , avec pour email {Courriel}");
        }

    }
}
