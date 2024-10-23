using ConsoleAppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");





        // je suis entrain de faire l ajout de 3 element 

        CarteCredit one = new CarteCredit(1000,"mon achat today",123456);

        CarteCredit two = new CarteCredit(1500, "mon achat de dimanche", 123897);
        CarteCredit three = new CarteCredit(2400, "mon achat de la semaine prochaine ", 200456);

        //affichage des elements de carte de credit
        

        one.AfficherDetails();
        two.AfficherDetails();
        three.AfficherDetails();  

        // j ajoute les elements de paypal


       Paypal ein = new Paypal(3450, "les achats de noel", "ein@gmail.com");

        Paypal zwei = new Paypal(865, "les achats de paque", "zwei@gmail.com");


        // affichage des deux instances de paypal

        
        ein.AfficherDetails();
        zwei.AfficherDetails(); 


        // ajout d un nouveau utilisateur

        utilisateur firs = new utilisateur("yan");

        firs.AfficherDetails();

        firs.AjouterPaiement(one);
        firs.AjouterPaiement(zwei);

        firs.AjouterInfos();     

    }
}