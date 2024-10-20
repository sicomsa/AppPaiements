using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPaiements
{
    internal class CarteCredit : Paiement
    {
        public int NumeroCarte { get; set; }

        public CarteCredit  (double montant, string description ,int numeroCarte) : base (montant,description)
        {
            NumeroCarte = numeroCarte;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($" le montant correspond a {Montant} , avec pour description  {Description},le numero de la carte est {NumeroCarte}"); 
        }
    }
}
