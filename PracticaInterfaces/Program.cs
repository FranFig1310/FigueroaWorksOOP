using System;
using System.Collections.Generic;

namespace PracticaInterfaces
{
    interface IDibujos
    {
        int x {get; set;}
        int y {get; set;}
        string color {get; set;}
        void Dibuja();
        void printColor();

    }
    /*class Figura 
    {
        protected int x;
        protected int y;
        protected string color;

        public Figura(int x, int y, string c){
            this.x = x; this.y = y; color = c;
        }

        public void dibuja()
        {
            Console.WriteLine("Se dibuja una figura color {0}", 
            color);
        }

        public void printColor() {
            Console.WriteLine(color);
        }
    }*/

    class Circulo : IDibujos 
    {
        int x1,y1;
        string Color1;

        public Circulo(int x2, int y2, string c2)
        {
            this.x = x2;
            this.y = y2;
            this.Color1=c2;
        }

        public int x { get => x1; set => x1 = value; }
        public int y { get => y1; set => y1 = value; }
        public string color {  get => Color1; set => Color1 = value; }
        public void Dibuja()
        {
            Console.WriteLine("Se dibuja un circulo {0}", Color1);
        }

        public void printColor()
        {
            Console.WriteLine("Imprime color", Color1);
        }
    }

    class Program{
        static void Main(string[] args){
            List<IDibujos> figuras = new List<IDibujos>();
            figuras.Add(new Circulo(12,13,"verde")) ;

            figuras.Add(new Circulo(12,13,"rojo")) ;
            foreach (var item in figuras){
                item.Dibuja();
            }    
            Circulo r = new Circulo(10,10,"azul");   
            r.Dibuja();
            }
        }
}