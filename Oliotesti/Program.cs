using Oliotesti;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--Säiliöiden luominen\n\n");
        Tank säiliö1 = new Tank("VESI", 100);
        Tank säiliö2 = new Tank("RYPSIÖLJY", 100);
        Tank säiliö3 = new Tank("OLIIVIÖLJY", 150);

        Console.WriteLine("--Tulostetaan säiliöiden lähtötilanne");
        Console.WriteLine(säiliö1.ToString());
        Console.WriteLine(säiliö2.ToString());
        Console.WriteLine(säiliö3.ToString());

        Console.WriteLine("\n--Säiliöihin lisääminen");
        Console.WriteLine(säiliö1.AddToTank(110));
        Console.WriteLine(säiliö2.AddToTank(70));
        Console.WriteLine(säiliö3.AddToTank(-50));


        Console.WriteLine("\n--Säiliöistä poistaminen");
        Console.WriteLine(säiliö1.RemoveFromTank(80));
        Console.WriteLine(säiliö2.RemoveFromTank(80));
        Console.WriteLine(säiliö3.RemoveFromTank(80));
        
        Console.WriteLine("\n--Säiliöiden tyhjennys");

        säiliö1.ClearTank();
        säiliö2.ClearTank();
        säiliö3.ClearTank();

        Console.WriteLine("\n--Tulostetaan säilijöiden lopputilanne");
        Console.WriteLine(säiliö1.ToString());
        Console.WriteLine(säiliö2.ToString());
        Console.WriteLine(säiliö3.ToString());

    }
}