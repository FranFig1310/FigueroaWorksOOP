using System;
using System.Collections.Generic;

namespace ListaActores
{}
public class Peliculas 
{
    private string Titulo;

    private string Director;

    private string Pais;

    private short Año;

    public Peliculas(string Titulo, short Año, string Director, string Pais)
    {
        this.Titulo = Titulo;
        this.Año = Año;
        this.Director = Director;
        this.Pais = Pais;
    }

    public void Imprimir()
    {
        Console.WriteLine("Titulo: {0} Año: {1} Director: {2} Pais: {3}", this.Titulo, this.Año, this.Director, this.Pais);
    }
}
    public class Actores
    {
        private string NombreAct;
        private short AñoNac;

        public Actores(string NombreAct, short AñoNac)
        {
            this.NombreAct = NombreAct;
            this.AñoNac = AñoNac;
        }
    public void ImprimirAct() => Console.WriteLine(NombreAct + ", " + AñoNac);
}
class Program
{
    static void Main(string[] args)
    {
        Peliculas P1 = new Peliculas("Joker", 2019, "Todd Phillips", "Estados Unidos");
        P1.Imprimir();

        List<Actores> Actors = new List<Actores>();
        
        Actors.Add(new Actores("Joaquin Phoenix", 1974));
        Actors.Add(new Actores("Robert de Niro", 1943));
        Actors.Add(new Actores("Zazie Beetz", 1991));
        Actors.Add(new Actores("Frances Conroy", 1953));
        Actors.Add(new Actores("Brett Cullen", 1956));

        foreach (Actores a in Actors)
        {
        a.ImprimirAct();
        }
    }
}