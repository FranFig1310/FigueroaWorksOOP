using System;


public class Peliculas 
{
    public string Titulo;
    public string getTitulo() => Titulo;
    public void setTitulo(string T)=> Titulo = T;

    public string Director;
    public string getDirector() => Director;
    public void setDirector(string D) => Director = D;

    public string Pais;
    public string getPais() => Pais;
    public void setPais(string P) => Pais = P;

    public Int16 Año;
    public Int16 getAño() => Año;
    public void setAño(Int16 A) => Año = A;
}
namespace ListaPeliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            Peliculas P1 = new Peliculas();
            P1.setTitulo("Joker");
            P1.setAño(2019);
            Console.WriteLine("{0}({1})", P1.getTitulo(), P1.getAño());

            Peliculas P2 = new Peliculas();
            P2.setTitulo("Avatar");
            P2.setAño(2009);
            Console.WriteLine("{0}({1})", P2.getTitulo(), P2.getAño());
        }
    }
}

