using System;


public class Peliculas 
{
    private string Titulo;
    //public string getTitulo() => Titulo;
    //public void setTitulo(string T)=> Titulo = T;

    private string Director;
    //public string getDirector() => Director;
    //public void setDirector(string D) => Director = D;

    private string Pais;
   // public string getPais() => Pais;
    //public void setPais(string P) => Pais = P;

    private Int16 Año;
    //public Int16 getAño() => Año;
    //public void setAño(Int16 A) => Año = A;

    public Peliculas(string Titulo, Int16 Año)
    {
        this.Titulo = Titulo;
        this.Año = Año;
    }
    
    public void Imprimir()
    {
        Console.WriteLine("Titulo:{0} Año:{1}", this.Titulo, this.Año);
    }
}
namespace ListaPeliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            Peliculas P1 = new Peliculas("Joker", 2019);
            // P1.setTitulo("Joker");
           // P1.setAño(2019);
           // Console.WriteLine("{0}({1})", P1.getTitulo(), P1.getAño());

            Peliculas P2 = new Peliculas("The Irishman", 2019);
           // P2.setTitulo("El Irlandés");
           // P2.setAño(2019);
           // Console.WriteLine("{0}({1})", P2.getTitulo(), P2.getAño());

           P1.Imprimir();
           P2.Imprimir();
        }
    }
}

