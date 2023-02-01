﻿using System.Net.Mail;
using System.Security.AccessControl;
using System.Text.Json.Serialization;
using VehicleExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        //Person person = new Person();
        /*
        Employee employee1 = new Employee();
        employee1.GetInfo();
        Employee johtaja = new Employee("Kalle", "zxc");
        Employee johtaja2 = new Employee("Kulle", "sc");
        johtaja.GetInfo();

        Console.WriteLine(johtaja.ToString());
        
        Console.WriteLine(johtaja.Equals(johtaja2));
        if(johtaja.Equals(johtaja2))
        {
            Console.WriteLine(johtaja.ToString() + "erisuuri kuin " + johtaja2.ToString());
        }
        else
        {
            Console.WriteLine(johtaja.ToString() + "eris kuin " + johtaja2.ToString());
        }
        Employee p = johtaja2 as Employee;
        p.GetInfo(); 
        */
        /*
        Vehicle car1 = new Vehicle("Audi", "A3", 1970, 2500);
        car1.PrintInformation();
        Console.WriteLine();*/

        // LAITA ABSRACTICSI JA VIHREÄMAALAA SEN JÄLKEEN

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

        Truck ford = new Truck("Ford", "AV24", 1985,20000, 300,"Truck", 2, 1500, 50);
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