using System;
namespace TemaPentruAcasa14_2
{
    interface IBorrowable
    {
        void Borrow();
        void Return();
    }

    class LibraryItem : IBorrowable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public bool IsBorrowed { get; private set; }

        public LibraryItem(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            IsBorrowed = false;
        }

        public void Borrow()
        {
            if (!IsBorrowed)
            {
                IsBorrowed = true;
                Console.WriteLine($"Felicitari! Itemul '{Title}' de '{Author}' din anul {PublicationYear} a fost imprumutat cu succes.");
            }
            else
            {
                Console.WriteLine($"Sorry! Itemul '{Title}' de '{Author}' din anul {PublicationYear} este deja imprumutat.");
            }
        }

        public void Return()
        {
            if (IsBorrowed)
            {
                IsBorrowed = false;
                Console.WriteLine($"Felicitari! Itemul '{Title}' de '{Author}' din anul {PublicationYear} a fost returnat cu succes.");
            }
            else
            {
                Console.WriteLine($"Sorry! Itemul '{Title}' de '{Author}' din anul {PublicationYear} nu este imprumutat.");
            }
        }
    }

}
