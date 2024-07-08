namespace Problema2
{
    public class BankAccount
    {
        /// <summary>
        /// Numarul contului
        /// </summary>
        public string? IBAN { get; set; }
        public Person? Owner { get; set; }
        public DateTime? CreateAt { get; set; }
        public Currency? Currency { get; set; }
        public string? PIN { get; set; }

        /// <summary>
        /// lista de tranzactii
        /// </summary>
        List<double> transations= new List<double>();

        /// <summary>
        /// Calculează și returnează soldul curent, în baza tranzacțiilor înregistrate. 
        /// </summary>
        /// <returns></returns>
        public double? Balance()
        {
            double balance=0;
            foreach(var t in transations)
            {
                balance += t;
            }
            return balance;
        }

        public void DisplayTransactionHistory()
        {
            Console.WriteLine($"Clientul: {Owner?.Name}\nContul: {IBAN}\nData crearii: {CreateAt}\nBalanta: {this.Balance()}");
            Console.WriteLine("Lista tranzactiilor:");
            foreach (var t in transations)
            {
                Console.Write($"{t:F2},");
            }
            Console.WriteLine();
        }

        public void Add(double suma)
        {
            if(suma < 0) throw new ArgumentOutOfRangeException(nameof(suma));
            
            transations.Add(suma);
        }

        public void Extract( double suma)
        {
            if (suma < 0) throw new ArgumentOutOfRangeException(nameof(suma));
            transations.Add(-1* suma);
        }


        /*public override string ToString()
        {
            return this.IBAN;
        }*/
    }
}
