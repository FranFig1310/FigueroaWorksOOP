using System;

namespace TrabajoDomino
{
    class Domino
    {
        // Atributos de la Clase
        private int Espacio1;
        private int Espacio2;

        //Constructor con condición
        public Domino(int Espacio1, int Espacio2)
        {
            //Validación de Datos Espacio 1
            if((Espacio1>6)||(Espacio1<0))
            {
                Console.WriteLine("ATENCIÓN: Se necesita un valor válido para el Espacio 1, inferior o igual a 6 y mayor o igual a 0.");
            }
            else this.Espacio1=Espacio1;

            //Validación de Datos Espacio 2
            if((Espacio2>6)||(Espacio2<0))
            {
                Console.WriteLine("ATENCIÓN: Se necesita un valor válido para el Espacio 2, inferior o igual a 6 y mayor o igual a 0.");
            }
            else this.Espacio2=Espacio2;
        }

        //Creación de los Métodos GET
        public int getEspacio1()=>Espacio1;
        public int getEspacio2()=>Espacio2;

        //Metodo para la impresión de valores simulando una ficha de dominó 
        public override string ToString()=>String.Format("Valor Superior: {0}\nValor Inferior: {1}\n",this.Espacio1,this.Espacio2);

        //Sobrecarga del Operador + para devolver un valor Entero
        public static int operator +(Domino x,Domino y)
        {
        return y.getEspacio1()+y.getEspacio2()+x.getEspacio1()+x.getEspacio2();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Inicialización de los valores para las fichas de dominó
            //Ficha 1
            Domino a=new Domino(5,4);
            Console.WriteLine(a);

            //Ficha 2
            Domino b=new Domino(3,2);
            Console.WriteLine(b);

            //Suma de Puntos en las fichas
            int Final = a + b;

            //Impresión del resultado de sumar los puntos
            Console.Write("El Resultado Final de la suma de puntos es: "+Final);
        }
    }
}
