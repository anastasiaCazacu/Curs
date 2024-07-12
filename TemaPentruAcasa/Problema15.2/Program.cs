/*Tema: Utilizarea proprietăților și metodelor într-o clasă.
Creați o clasă numită Carte care să reprezinte informații despre o carte.
Adăugați următoarele proprietăți la clasa Carte:
Titlu - pentru a reține titlul cărții
Autor - pentru a reține numele autorului cărții
AnPublicare - pentru a reține anul de publicare al cărții
NumarPagini - pentru a reține numărul de pagini al cărții
Implementați un constructor cu parametri în clasa Carte care să primească argumente pentru titlu, autor, anul de publicare și numărul de pagini și să le atribuie proprietăților corespunzătoare.
Adăugați o metodă numită AfisareDetalii în clasa Carte care să afișeze toate detaliile cărții.
Testați clasa Carte în funcția Main a programului.
Creați un obiect de tip Carte, specificând valorile pentru titlu, autor, anul de publicare și numărul de pagini.
Apelați metoda AfisareDetalii pentru a afișa detaliile cărții.

*/
namespace Problema15._2
{
   

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Clasa carte------------");
            Carte carte1 = new Carte("Amintiri din copilarie", "Ion Creanga", 1866, 655);
            carte1.AfisareDetalii();

            Carte carte2 = new Carte("Poiezii", "Mihai Eminescu", 1965, 200);
            carte2.AfisareDetalii();
        }
    }
}
