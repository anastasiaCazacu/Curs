//TemaLectia13
public class Angajat
{
    //campurile sau variabilele membre
    private string nume;
    private double salariu;
    private Depatament depatament;

    //constructor
    public Angajat(string nume, double salariu, Depatament depatament)
    {
        this.nume = nume;
        this.salariu = salariu;
        this.depatament = depatament;
    }

    public void AfisareDetalii()
    {
        Console.WriteLine($"Numele: {nume}, Salariu: {salariu}, Departamentul: {depatament}");
    }
}

//Nr2
/*using System;
public*/