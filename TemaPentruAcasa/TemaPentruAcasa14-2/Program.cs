using System;
namespace TemaPentruAcasa14_2
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("-----------Library----------");

            Library library = new Library();

            Magazine magazin1 = new Magazine("Hello", "HelloMedia", 2010);
            Magazine magazin2 = new Magazine("Constitutia RM", "GGMedia", 2024);
            Magazine magazin3 = new Magazine("PC Magazine May", "ZDHolding", 2024);
            Magazine magazin4 = new Magazine("Game Over", "KLMedia", 2023);

            DVD dvd1 = new DVD("Relax Music Vol2", "ABRecord", 2020);
            DVD dvd2 = new DVD("Madam", "SimpleRecord", 2022);
            DVD dvd3 = new DVD("Danss1", "ABRecord", 2024);
            DVD dvd4 = new DVD("Danss2", "ABRecord", 2024);

            Book book1 = new Book("Aventurile Lui Tom Sawyer", "Mark Twain", 2013);
            Book book2 = new Book("Print si cersetor", "Mark Twain", 2023);
            Book book3 = new Book("Aventurile Lui Huckleberry Finn", "Mark Twain", 2020);
            Book book4 = new Book("La firul ierbii", "Dabija Doina", 2024);

            library.AddItem(book1);
            library.AddItem(book2);
            library.AddItem(book3);
            library.AddItem(book4);

            library.AddItem(dvd1);
            library.AddItem(dvd2);
            library.AddItem(dvd3);
            library.AddItem(dvd4);

            library.AddItem(magazin1);
            library.AddItem(magazin2);
            library.AddItem(magazin3);
            library.AddItem(magazin4);

            library.BorrowItem("Danss1");
            library.BorrowItem("Aventurile Lui Tom Sawyer"); 
            library.ReturnItem("Danss1");
            library.ReturnItem("Aventurile Lui Tom Sawyer");
            library.ReturnItem("La firul ierbii");
        }
    }
}
