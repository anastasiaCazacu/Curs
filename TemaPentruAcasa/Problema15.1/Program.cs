/*Tema: Utilizarea unei clase statice.
Creați o clasă statică numită Helper care să conțină o metodă statică numită GenerareCodUnic care să genereze un cod unic format dintr-un prefix și un număr.
Metoda GenerareCodUnic trebuie să primească un prefix și să returneze un cod unic format din prefix și un număr generat aleatoriu.
Testați clasa Helper în funcția Main a programului.
Apelați metoda GenerareCodUnic de mai multe ori cu diferite valori de prefix și afișați codurile generate. 
*/

using System;
namespace Problema15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------GenerareCodUnic-------------");

            string cod1 = Helper.GenerareCodUnic("NCI");
            Console.WriteLine(cod1 + "\n");

            string cod2 = Helper.GenerareCodUnic("TRX");
            Console.WriteLine(cod2 + "\n");

            string cod3 = Helper.GenerareCodUnic("TRX");
            Console.WriteLine(cod3 + "\n");
        }
    }
}
