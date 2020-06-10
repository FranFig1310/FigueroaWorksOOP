using System;
using System.Collections.Generic;

namespace Pluma
{
    interface IPluma
    {
        string Color{get; set;}
        bool Open();
        bool Close();
        void Escribir(string Text);
    }

    class Cello : IPluma
    {
        private bool canPrint = false;
        public Cello(string C)
        {
            Color = C;
        }
        private string _color;
        public string Color { get => _color; set => _color = value; }

        private bool Tapon = true;
        public bool Close()
        {
            Tapon = true;
            return Tapon;
        }

        public bool OpenPen()
        {
            canPrint = true;
            return canPrint;
        }
        public void Escribir(string Text)
        {
            if (!Tapon)
            {
                Console.WriteLine("Escribe el texto {0} en Color {1}", Text, Color);
            }
            else 
            {
                Console.WriteLine("No escribe nada");
            }
        }

        public bool Open()
        {
            Tapon = false;
            return Tapon;
        }
    }

    class Gis 
    {
        public Gis(string C)
        {
            Color = C;
        }
        string Color{get; set;}
        public void Escribir(string Text)
        {
            Console.WriteLine("Escribe el texto {0} en Color {1}", Text, Color);
        }
    }
    class Bic: IPluma
    {
        public Bic(string C)
        {
            Color = C;
        }
        public string Color{get; set;}
        private bool canPrint = false;
        public bool OpenPen()
        {
            canPrint = true;
            return canPrint;
        }
        bool IPluma.Close()
        {
            canPrint = false;
            return canPrint;
        }
        public void Escribir(string Text)
        {
            if (!Tapon)
            {
                Console.WriteLine("Escribe el texto {0} en Color {1}", Text, Color);
            }
            else 
            {
                Console.WriteLine("No escribe nada");
            }
        }

        public bool Open()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           Cello pluma_cello = new Cello("Rojo");
           Bic pluma_bic = new Bic("Azul");
           Gis gis1 = new Gis("Blanco");

            pluma_cello.OpenPen();
            pluma_cello.Escribir("Hola");
            pluma_bic.OpenPen();
            pluma_bic.Escribir("Holas");

            List<IPluma> plumas = new List<IPluma>();
            plumas.Add(pluma_cello);
            plumas.Add(pluma_bic);
            plumas.Add(gis1);

        }
    }
}
