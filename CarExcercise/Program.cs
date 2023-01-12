using CarExcercise;

internal class Program
{
    private static void Main(string[] args)
    {

        Car firstCar = new Car();
        Car secondCar = new Car();
        firstCar.AskData();
        secondCar.AskData();
        Console.WriteLine("Kahden auton syöttämäsi tiedot");
        firstCar.ShowCarInfo();
        secondCar.ShowCarInfo();
        Console.WriteLine("\nLisätään ensimmäisen auton nopeutta");
        firstCar.Accelerate();
        Console.WriteLine();
        secondCar.Brake();
        Console.ReadLine();
        
    }
}