using System.Net.Mail;
using System.Security.AccessControl;
using System.Text.Json.Serialization;
using VehicleExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Vehicle luokasta muutettu abstrackti mutta alun koodeja tuossa
        Vehicle car1 = new Vehicle("Audi", "A3", 1970, 2500);
        Tulostaa vehicle luokan tiedot PrintÍnformationin avulla
        car1.PrintInformation();
        Console.WriteLine();*/
        
        Car mersu = new Car("Mersu", "A1", 1990, 10000, 150, "Sport" , 4);
        Car toyota = new Car("Toyota", "Avensis", 1980, 15000, 250, "Farmari", 4);

        Console.WriteLine("\nAuton tiedot PrintInformationin avulla");
        mersu.PrintInformation();

        Console.WriteLine("\n\nAuton tiedot ToStringin avulla");
        Console.WriteLine(toyota.ToString());

        Console.WriteLine("\nVertailee kahta eri autoa .Equals() avulla\n");
        if(mersu.Equals(toyota))
        {
            Console.WriteLine(mersu.ToString() + "\nOn sama kuin\n" + toyota.ToString());
        }
        else
        {
            Console.WriteLine(mersu.ToString() + "\nOn eri kuin\n" + toyota.ToString());
        }

        Truck ford = new Truck("Ford", "AV24", 1985,20000, 300,"Truck", 2, 1500, 40);
        Console.WriteLine("\nTulostaa rekan tiedot");
        ford.PrintInformation();

        Console.WriteLine("\nTulostaa rekan kulutuksen");
        ford.CalculateConsumption();

        Console.WriteLine("\nYrittää muuttaa Car luokkaa Truck luokaksi ja toisten päin, kertoo jos mahdollista\n");
        Truck truck1 = toyota as Truck;
        if(truck1 != null)
        {
            Console.WriteLine(truck1.ToString());
        }
        else
        {
            Console.WriteLine("Ei voida muuntaa Car => Truck");
        }

        Car car2 = ford as Car; //Tämä toimisi itsestään mutta jätin if loopin tähän
        if (car2 != null)
        {
            Console.WriteLine("\nOn mahdollista muuntaa Truck => Car, tulostaa muutetun luokan tiedot tiedot");
            Console.WriteLine(car2.ToString());
        }
        else
        {
            Console.WriteLine("Ei voida muuntaa");
        }



    }
}