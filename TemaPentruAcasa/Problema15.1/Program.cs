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
