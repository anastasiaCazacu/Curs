namespace Problema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Bank Account:------");

            Person persoana1 = new PersonFizic()
            {
                Name = "Ion Popescu",
                IDNP = "1234567891234"
            };

            Person persoana2 = new PersonJuridic()
            {
                Name = "SRL CompanyPopescu",
                CIF = "001237891234"
            };

            BankAccount bankAccount = new BankAccount()
            {
                CreateAt = DateTime.Now,
                Currency = Currency.MDL,
                IBAN = "1122",
                Owner = persoana1,
                PIN = "1111"
            };

            BankAccount bankAccountJ = new BankAccount()
            {
                CreateAt = DateTime.Now,
                Currency = Currency.MDL,
                IBAN = "3344",
                Owner = persoana2,
                PIN = "1111"
            };

            bankAccount.Add(2000);
            bankAccountJ.Add(1500);
            bankAccount.Extract(500);
            bankAccountJ.Add(3000);
            bankAccount.Add(500);
            bankAccount.Extract(3500);
            bankAccountJ.Extract(3500);
            bankAccount.Extract(2500);


            /*Console.WriteLine(bankAccount);*/
            Console.WriteLine("-------Sold Persoana Fizica------");
            Console.WriteLine(bankAccount.Balance());
            bankAccount.DisplayTransactionHistory();

            Console.WriteLine("\n-------Sold Persoana Juridica------");
            Console.WriteLine(bankAccountJ.Balance());
            bankAccountJ.DisplayTransactionHistory();
        }
    }
}
