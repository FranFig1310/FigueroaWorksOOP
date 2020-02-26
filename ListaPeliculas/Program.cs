using System;
using System.Collections.Generic;

namespace ListaPeliculas
{
    class ListPeliculas
    {
        private string Nombre;
        public ListPeliculas(string Nombre) => this.Nombre = Nombre;
    
    public void Imprimir() => Console.WriteLine(Nombre);
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<ListPeliculas> Peliculas = new List<ListPeliculas>();
            
            Peliculas.Add(new ListPeliculas("El Irlandés"));
            Peliculas.Add(new ListPeliculas("Gladiador"));
            Peliculas.Add(new ListPeliculas("El Padrino"));
            Peliculas.Add(new ListPeliculas("Pelotón"));
            Peliculas.Add(new ListPeliculas("Rocky"));

            foreach (ListPeliculas a in Peliculas)
            {
                a.Imprimir();
            }
        }
    }
}
