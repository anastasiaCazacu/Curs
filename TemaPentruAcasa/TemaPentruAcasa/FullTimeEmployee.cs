using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPentruAcasa14
{
    public  class FullTimeEmployee:Employee
    {
        public double Bonus {  get; set; }

        public FullTimeEmployee(string Name,double Salary, int Id,  double p_bonus)
        : base(Name,  Id, Salary)
        {
            Bonus = p_bonus;
        }

        //suparascrieerea metodei
        public override void CalculateAnnualSalary()
        {
            double anualSalary = (Salary * 12)+(Bonus*12);
            Console.Write(anualSalary);
        }
    }
}
