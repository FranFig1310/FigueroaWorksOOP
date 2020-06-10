using System;
using System.Collections.Generic;

namespace Alumnos
{
    class Alumno
    {
        protected string Nombre;

        public Alumno(string N)
        {
            Nombre = N;
        }

        public virtual void Saluda()
        {
            Console.WriteLine("Muy buen día, me presento, soy {0}", Nombre);
        }
        
        public virtual void Pendiente()
        {
            Console.WriteLine("Tengo pendiente: ");
        } 
    }

    class Licenciatura : Alumno
    {
        protected string Carrera;
        protected int Semestre;
        protected int SerSoc; //Servicio Social
        protected string Resid; //Residencia

        public Licenciatura(string Nombre, string Carrera, int Semestre, int SerSoc, string Resid) : base(Nombre)
        {
            this.Carrera = Carrera;
            this.Semestre = Semestre;
            this.SerSoc = SerSoc;
            this.Resid = Resid;
        }

        public override void Saluda()
        {
            Console.WriteLine("Buen día, soy {0} de {1} en {2} semestre", Nombre, Carrera, Semestre);
        }
        public override void Pendiente()
        {
            Console.WriteLine("Tengo pendientes mi Servicio Social con {0} de 480 horas y tengo una Residencia en {1} \n", SerSoc, Resid);
        }
    }

    class Posgrado : Alumno
    {
        protected string Carrera;
        protected int Periodo;
        protected string TemaInvest; //Tema de Investigación

        public Posgrado(string Nombre, string Carrera, int Periodo, string TemaInvest) : base(Nombre)
        {
            this.Carrera = Carrera;
            this.Periodo = Periodo;
            this.TemaInvest = TemaInvest;
        }

        public override void Saluda()
        {
            Console.WriteLine("Buen día, soy {0}, voy en el periodo {1} del posgrado en {2}", Nombre, Periodo, Carrera);
        }

        public override void Pendiente()
        {
            Console.WriteLine("Tengo pendiente mi Tema de Investigación, el cuál es {0} \n", TemaInvest);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> Estudiantes = new List<Alumno>();
            Estudiantes.Add(new Licenciatura("Fran", "Sistemas", 6, 300, "Plantronics"));
            Estudiantes.Add(new Licenciatura("Angel", "Arquitectura", 5,200, "TEN Arquitectos"));
            Estudiantes.Add(new Posgrado("Julio", "Sistemas", 2, "Computación Cuántica"));
            Estudiantes.Add(new Posgrado("Silvia", "Administración", 3, "El Personal Moderno"));

            foreach(Alumno x in Estudiantes)
            {
                x.Saluda();
                x.Pendiente();
            }
        }
    }
}
