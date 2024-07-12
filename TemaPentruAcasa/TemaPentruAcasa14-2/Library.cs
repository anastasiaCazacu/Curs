using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPentruAcasa14_2
{
    internal class Library
    {
        public List<LibraryItem> items = new List<LibraryItem>();

        public void AddItem(LibraryItem item)
        {
            items.Add(item);
        }

        public void BorrowItem(string title)
        {
            LibraryItem foundItem = null;
            foreach (LibraryItem item in items)
            {
                if (item.Title == title)
                {
                    foundItem = item;
                    break;
                }
            }

            if (foundItem != null)
            {
                foundItem.Borrow();
            }
            else
            {
                Console.WriteLine($"Sorry! Itemul cu titlul '{title}' nu a fost gasit in biblioteca.");
            }
        }

        public void ReturnItem(string titleItem)
        {
            LibraryItem foundItem = null;
            foreach (LibraryItem item in items)
            {
                if (item.Title == titleItem)
                {
                    foundItem = item;
                    break;
                }
            }

            if (foundItem != null)
            {
                foundItem.Return();
            }
            else
            {
                Console.WriteLine($"Sorry! Itemul cu titlul '{titleItem}' nu a fost gasit in biblioteca.");
            }
        }
    }

}
