//TemaLectia13
using System;

class Program
{
    static void Main()
    {
        Angajat angajat1 = new Angajat("Ion Popescu", 16500, Depatament.InginerTestare);
        Angajat angajat2 = new Angajat("Iana Leu", 17650, Depatament.Designer);
        Angajat angajat3 = new Angajat("Lia Tudoreccu", 20200, Depatament.Programator);
        Angajat angajat4 = new Angajat("Paul Toma", 35800, Depatament.Programator);

        //afisarea detalii a fiecarui angajat
        angajat1.AfisareDetalii();
        angajat2.AfisareDetalii();
        angajat3.AfisareDetalii();
        angajat4.AfisareDetalii();
    }
}
