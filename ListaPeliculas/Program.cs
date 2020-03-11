using System;
using System.Collections.Generic;

namespace ListaPeliculas
{
    class ListPeliculas
    {
        private string Nombre;
        private short AñoEst;
        public ListPeliculas(string Nombre, short AñoEst)
        { 
            this.Nombre = Nombre;
            this.AñoEst = AñoEst;
        }
    
    public void Imprimir() => Console.WriteLine(Nombre + ", " + AñoEst);
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<ListPeliculas> Peliculas = new List<ListPeliculas>();
            
            Peliculas.Add(new ListPeliculas("El Irlandés", 2019));
            Peliculas.Add(new ListPeliculas("Gladiador", 2000));
            Peliculas.Add(new ListPeliculas("El Padrino", 1972));
            Peliculas.Add(new ListPeliculas("Pelotón", 1986));
            Peliculas.Add(new ListPeliculas("Rocky", 1975));

            foreach (ListPeliculas a in Peliculas)
            {
                a.Imprimir();
            }
        }
    }
}
