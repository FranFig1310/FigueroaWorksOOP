using System;
using System.Collections.Generic;

namespace Interfaz
{
    class Usuario:IComparable
    {
        public string Nombre {get; set;}

        private string _correo;

        public Usuario(string n, string c)
        {
            Nombre = n;
            Correo = c;
        }

        public string Correo{get=> _correo; set => _correo = value;}
        public int CompareTo(object obj)
        {
            return Nombre.CompareTo( ((Usuario) obj).Nombre);
        }
    }

 /*  interface IActor
    {

        void Actua();
        void Ensayar();
        void getPremio();
    }
    interface INacionalidad
    {
        string Pais();
        string Nacionalidad();
    }
    abstract class Musico
    {
        protected string _nombre;
        public Musico(string n)
        {
            _nombre = n;
        }
            public string Nombre 
            {
                get => _nombre; 
                set => _nombre = value; 
            }
        public abstract void Afina();
    }

    class Bajista : Musico, IActor, INacionalidad
    {
        public Bajista(string n) : base(n)
        {

        }

        public void Actua()
        {
            throw new NotImplementedException();
        }

        public override void Afina()
        {
            Console.WriteLine("{0} afina su bajo", _nombre);
        }

        public void Ensayar()
        {
            throw new NotImplementedException();
        }

        public void getPremio()
        {
            throw new NotImplementedException();
        }

        public string Nacionalidad()
        {
            throw new NotImplementedException();
        }

        public string Pais()
        {
            throw new NotImplementedException();
        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(new Usuario("Fran", "fmfp120@gmail.com"));
            usuarios.Add(new Usuario("Adrian", "fmfp125@gmail.com"));
            usuarios.Add(new Usuario("Manuel", "fmfp130@gmail.com"));
            usuarios.Add(new Usuario("Zinedine", "fmfp135@gmail.com"));

            usuarios.Sort();

            foreach(Usuario u in usuarios)
            {
                Console.WriteLine(u.Nombre);
            }
        }
    }
}
