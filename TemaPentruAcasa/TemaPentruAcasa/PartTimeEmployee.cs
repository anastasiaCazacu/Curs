using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPentruAcasa14
{
    public class PartTimeEmployee : Employee
    {
        //proprietati specifice 
        public double HourlyRate { get; set; }
        public int  NumbersOfHours { get; set; }    

        public PartTimeEmployee(string Name, int Id, double p_hourRate, int p_numbersOfHours)
            :base(Name,Id)
        {
            HourlyRate = p_hourRate;
            NumbersOfHours = p_numbersOfHours;
        }

        public override void CalculateAnnualSalary()
        {
            double anualSalary = HourlyRate*NumbersOfHours;
            Console.Write(anualSalary);
        }

        public override void ShowInfoEmployee()
        {
            Console.WriteLine($"Nume: {Name}, Id: {Id}, Numarul de ore: {NumbersOfHours}, Pretul unei ore: {HourlyRate}");
        }
    }
}
