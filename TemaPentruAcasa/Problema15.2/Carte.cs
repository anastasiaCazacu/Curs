using System;

namespace Problema15._2
{
    class Carte
    {
        public Carte(string titlu, string autor, int anPublicare, int numarDePagini)
        {
            this.titlu = titlu;
            this.autor = autor;
            this.anPublicare = anPublicare;
            this.numarDePagini = numarDePagini;
        }

        public string titlu { get; set; }
        public string autor { get; set; }
        public int anPublicare { get; set; }
        public int numarDePagini { get; set; }

        //metoda de afisare
        public void AfisareDetalii()
        {
            Console.WriteLine($"Titlul: {titlu}\nAutorul: {autor}\nAnul publicarii: {anPublicare}\nNumarul de pagini: {numarDePagini}\n");
        }
    }
}
