using CarExcercise;

internal class Program
{
    private static void Main(string[] args)
    {

        Car firstCar = new Car();
        Car secondCar = new Car();
        firstCar.AskData();
        secondCar.AskData();
        firstCar.ShowCarInfo();
        secondCar.ShowCarInfo();
        firstCar.Accelerate(210);
        firstCar.ShowCarInfo();
        secondCar.Brake();
        secondCar.ShowCarInfo();
    }
}