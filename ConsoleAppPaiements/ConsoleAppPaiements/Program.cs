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

        //affichage 

        one.AfficherDetails();
        two.AfficherDetails();
        three.AfficherDetails();

    }
}