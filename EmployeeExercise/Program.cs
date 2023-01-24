using System.Transactions;
using EmployeeExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee[] employees = new Employee[3];
        employees[0] = new Employee("Pekka","1","Johtaja",5000);
        employees[1] = new Employee("Mari", "2", "Sihteeri", 3000);
        employees[2] = new Employee("Keijo", "3", "Siivooja", 1500);

        Console.WriteLine("\nVertaa kahden työntekijän palkkoja keskenään CompareSalaryn avulla.");
        employees[0].CompareSalary(employees[1]);

        Console.WriteLine("\nTulostaa työntekijän tiedot PrintEmployeeInfon avulla.");
        employees[0].PrintEmployeeInfo();

        Console.WriteLine("\nTulostaa työntekijän tiedot ToStringin avulla.");
        Console.WriteLine(employees[0].ToString());

        Console.WriteLine("\nTulostaa kaikkien työntekijöiden tiedot näytölle");
        employees[0].PrintEmployeeInfo();
        employees[1].PrintEmployeeInfo();
        employees[2].PrintEmployeeInfo();

        Console.WriteLine("\nKäy kaikki taulukon henkilöt läpi for loopin avulla ja vertailee heidän palkkaansa käyttäen CompareSalarya");
        int n = 1;        
        for(int i = 0; i < employees.Length; i++)
        {
            if (n == employees.Length)
            {
                n = 0;
            }
                employees[i].CompareSalary(employees[n]);
                n++;
        }
        
    }

}