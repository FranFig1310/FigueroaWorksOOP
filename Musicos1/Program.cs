using System;
using System.Collections.Generic;

namespace Musicos
{
    abstract class Musico
    {
        protected string Nombre;

        public abstract void Saluda();
        public abstract void Afina();

        public abstract void Toca();

        public Musico(string N)
        {
            Nombre = N;
        }
    }

    class Vocalista : Musico
    {
        protected string Cancion;

        public Vocalista(string Nombre, string Cancion) : base(Nombre)
        {
           this.Cancion = Cancion;
        }
        
        public override void Saluda()
        {
        Console.WriteLine("Hola a toda Tijuana, ya me conocen, soy {0} y hoy tocaremos {1}", Nombre, Cancion);
        }

        public override void Afina()
        {
            Console.WriteLine("El vocalista {0} afina su voz",Nombre);
        }

        public override void Toca()
        {
            Console.WriteLine("Y empezamos con {0}, y dice mas o menos así...", Cancion);
        }
    }
    class Baterista : Musico
    {
        protected string Bateria;

        public Baterista(string Nombre, string Bateria) : base(Nombre)
        {
           this.Bateria = Bateria;
        }
        
        public override void Saluda()
        {
        Console.WriteLine("¡¡¿Cómo hace ruido Tijuana?!! Yo soy el baterista: {1} y mi batería {0}", Nombre, Bateria);
        }

        public override void Afina()
        {
            Console.WriteLine("El baterista {0} está afinando",Nombre);
        }

        public override void Toca()
        {
            Console.WriteLine("El baterista empieza a tocar su batería {0}", Bateria);
        }
    }

    class Bajista : Musico
    {
        protected string Bajo;

        public Bajista(string Nombre, string Bajo) : base(Nombre)
        {
            this.Bajo = Bajo;
        }
        
        public override void Saluda()
        {
            Console.WriteLine("Muy buenas tardes Tijuana, yo soy: {0} y mi bajo: {1}", Nombre, Bajo);
        }

        public override void Afina()
        {
            Console.WriteLine("El bajista {0} está afinando",Nombre);
        }

        public override void Toca()
        {
            Console.WriteLine("El bajista empieza a tocar su {0}", Bajo);
        }
    }
    
    class Guitarrista : Musico
    {
        protected string Guitarra;

        public Guitarrista(string Nombre, string Guitarra) : base(Nombre)
        {
            this.Guitarra = Guitarra;
        }

        public override void Saluda()
        {
            Console.WriteLine("¡Welcome to Tijuana! Hoy venimos a hacer escándalo, soy:{0} y mi guitarra: {1}", Nombre, Guitarra);
        }

        public override void Afina()
        {
            Console.WriteLine("El guitarrista {0} está afinando",Nombre);
        }

        public override void Toca()
        {
            Console.WriteLine("El guitarrista empieza a tocar su {0}", Guitarra);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Musico> Musicos = new List<Musico>();
            Musicos.Add(new Vocalista("Elvis", "Jailhouse Rock"));
            Musicos.Add(new Bajista("Tom", "Gibson"));
            Musicos.Add(new Baterista("Ringo", "Tama"));
            Musicos.Add(new Guitarrista("Brian", "Fender"));
            Musicos.Add(new Guitarrista("Angus", "Yamaha" + "\n"));

            foreach(Musico m in Musicos)
            {
                m.Saluda();
            }

            foreach(Musico n in Musicos)
            {
                n.Afina();
            }
            
            foreach(Musico o in Musicos)
            {
                o.Toca();
            }
        }
    }
}