using TemaPentruAcasa14;

namespace TemaPentruAcasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Gestionare angajati-----------");
            Console.WriteLine("\nFul Time Employee");
            FullTimeEmployee fullTimeEmployee1 = new FullTimeEmployee("Ala", 1122, 10000, 500);
            fullTimeEmployee1.ShowInfoEmployee();
            Console.Write("Salariul anual al FullTimeEmployee este: ");
            fullTimeEmployee1.CalculateAnnualSalary();

            Console.WriteLine("\n\nPart Time Employee ");
            PartTimeEmployee partTimeEmployee1 = new PartTimeEmployee("Ala", 2233, 200, 200);
            partTimeEmployee1.ShowInfoEmployee();
            Console.Write("Salariul anual al PartTimeEmployee este: ");
            partTimeEmployee1.CalculateAnnualSalary();

            Console.WriteLine("\n ");
        }
    }
}
