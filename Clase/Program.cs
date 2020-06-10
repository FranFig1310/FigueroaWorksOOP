using System;

namespace Clase
{
    class Racional
    {
        public int Numerador;
        public int Denominador;
        public Racional(int Num, int Den)
        {
            Numerador = Num;
            Denominador = Den;
        }
        public override string ToString()
        {
            return String.Format("{0}/{1}", Numerador, Denominador);
        }
        
        public static Racional operator +(Racional x, Racional y)
        {
            int Numerador = (x.Numerador * y.Denominador) + (y.Numerador * x.Denominador);
            int Denominador = x.Denominador * y.Denominador;
            return new Racional(Numerador, Denominador);
        }
        public static Racional operator ++(Racional x)
        {
            return new Racional(x.Numerador+1, x.Denominador+1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Racional a = new Racional (1,3);
            Racional b = new Racional (2,9);

            Racional c = a + b;
            Racional x = c++;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(x);
        }
    }
}
