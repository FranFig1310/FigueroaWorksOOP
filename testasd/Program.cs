using System;

namespace duracion
{
    class Duracion
    {
     private int horas;
     private  int minutos;
     private int segundos;
     
     public void setHoras(int horas)
     {
       this.horas = horas;
     }
     public void getHoras(int hrs)
     {
         horas = hrs;
         return horas;
     }
      public void setMinutos(int min)
     {
       this.minutos = min;
     }
     public void getMinutos(int min)
     {
        minutos = min;
         return minutos;
     }
       public void setSegundos(int seg)
     {
       this.segundos = seg;
     }
     public void getSegundos(int seg)
     {
        segundos = seg;
         return segundos;
     }
     public Duracion(int horas, int minutos, int segundos)
    {
     this.horas = horas;
     this.horas = minutos;
     this.horas = segundos; 
    }

    public void print()
    {
        Console.WriteLine("La duracion de la pelicula, partido o musica es: ");
    }
    
    }
        class Program
    {
        static void Main(string[] args)
        {
            Duracion hms = new Duracion("Las horas, minutos y segundos");
            Duracion m = new Duracion("Los minutos son:");
            Duracion s = new Duracion("Los segundos son:");
            hms.print();
            Console.WriteLine("------");
            m.print();
            Console.WriteLine("------");
            s.print();
            Console.WriteLine("------");

        }
    }
}