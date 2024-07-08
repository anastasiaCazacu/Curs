using System;


namespace TemaPentruAcasa14
{
    public  class Employee
    {
        //proprietatile
        public int Id { get; set; }
        public string Name { get; set; }    
        public double Salary { get; set; }

        public Employee(string p_name="V", int p_id=0, double p_salary=0) 
        { 
            Name = p_name;
            Id = p_id;
            Salary = p_salary;
        }
        public Employee(string p_name  , int p_id ) 
        {
            Name=p_name;
            Id = p_id;
        }
        public virtual void CalculateAnnualSalary()
        {
            double anualSalary = Salary * 12;
            Console.Write(anualSalary);
        }
        public virtual void ShowInfoEmployee()
        {
            Console.WriteLine($"Nume: {Name}, Id: {Id}, Salariu: {Salary}");
        }
    }


}
