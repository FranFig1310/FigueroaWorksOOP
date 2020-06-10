using System;

namespace Musicos
{
    class Musico
    {
        protected string Nombre;

        public virtual void Saluda() => Console.WriteLine("¡¡Qué pasa Tijuanaaaa, todos con las manos bien arriba!! Yo soy: {0}", Nombre);

        public Musico(string N) => Nombre = N;

        class Baterista:Musico
        {
            protected string Bateria;

            public Baterista(string Nombre, string Bateria) : base(Nombre) => this.Bateria = Bateria;
        
            public override void Saluda() => Console.WriteLine("¡¡¿Cómo hace ruido Tijuana?!! Yo soy el baterista: {1} y mi batería {0}", Nombre, Bateria);
        }

        class Bajista:Musico
        {
            protected string Bajo;

            public Bajista(string Nombre, string Bajo) : base(Nombre) => this.Bajo = Bajo;
        
            public override void Saluda() => Console.WriteLine("Muy buenas tardes Tijuana, yo soy: {0} y mi bajo: {1}", Nombre, Bajo);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Musico Juan = new Musico("Juan");
            Juan.Saluda();

            Baterista Ringo = new Baterista("Ringo", "Tama");
            Ringo.Saluda();

            Bajista Tom = new Bajista("Tom", "Gibson");
            Tom.Saluda();
        }
    }
}
