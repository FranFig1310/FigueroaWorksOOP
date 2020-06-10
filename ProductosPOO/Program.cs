using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ProductosPOO
{
    public class PrecioFecha{
        public DateTime FechaInicio;
        public DateTime FechaFinal;
        public Decimal Precio;
        
        public PrecioFecha(DateTime fechaInicio, DateTime fechaFinal, Decimal precio){
            FechaInicio = fechaInicio;
            FechaFinal = fechaFinal;
            Precio = precio;
        }
        //Comprobación de si la fecha está dentro del rango existente, desde año hasta meses y días
        public static Producto GetPrecio(Producto Producto, DateTime DateC)
        {
            if(DateC.Year >= Producto.PrecioYFecha.FechaInicio.Year && DateC.Year <= Producto.PrecioYFecha.FechaFinal.Year)
            {
                if(DateC.Month >= Producto.PrecioYFecha.FechaInicio.Month && DateC.Month <= Producto.PrecioYFecha.FechaFinal.Year)
                {
                    if(DateC.Day >= Producto.PrecioYFecha.FechaInicio.Day && DateC.Day <= Producto.PrecioYFecha.FechaFinal.Day)
                    {
                        return Producto;
                    }
                    else{
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Fecha fuera de rango de registro.");
                    }
                }
                else{
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Fecha fuera de rango de registro.");
                }
            }
            else{
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Fecha fuera de rango de registro.");
            }
            return null;
        }
    }
    public class Producto{
        public PrecioFecha PrecioYFecha{get; set;}
        public string Codigo{get; set;}
        public string Descripcion{get; set;}
        public int Departamento{get; set;}
        public int Likes{get; set;}
        //Constructor
        public Producto (string C, string D, int Depto, int Like, PrecioFecha precio){
            Codigo = C;
            Descripcion = D;
            Departamento = Depto;
            Likes = Like;
            PrecioYFecha = precio;
        }
        //Lista del método departamento que busca el departamento asignado en la Lista de Productos
        public static List<Producto> GetDepartamento(int Depto, List<Producto> productos){
            List<Producto> productsback = new List<Producto>();
            
            foreach (Producto p in productos)
            {
                if (p.Departamento == Depto)
                    productsback.Add(p);
            }
            return productsback;
        }
    }
    class ProductoDB
    {
        //Método para escribir con todo y precio, método listo a TXT
        public static void EscribeAtxt(string path, List<Producto> productos){     
                                                          //Método usado con Append para inicializar el archivo necesario
            StreamWriter salidaTXT = new StreamWriter(    //Create para crear o sobreescribir archivo
                                     new FileStream(path, FileMode.Append, FileAccess.Write));
            foreach(Producto p in productos)
            {
                string fechaInicio = String.Format("{0}/{1}/{2}",p.PrecioYFecha.FechaInicio.Day, p.PrecioYFecha.FechaInicio.Month, p.PrecioYFecha.FechaInicio.Year);
                salidaTXT.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6} ", 
                p.Codigo, p.Descripcion, p.Departamento, p.Likes, String.Format("{0}/{1}/{2}", p.PrecioYFecha.FechaInicio.Day, p.PrecioYFecha.FechaInicio.Month, p.PrecioYFecha.FechaInicio.Year), 
                String.Format("{0}/{1}/{2}", p.PrecioYFecha.FechaFinal.Day, p.PrecioYFecha.FechaFinal.Month, p.PrecioYFecha.FechaFinal.Year),p.PrecioYFecha.Precio.ToString());
            }
            salidaTXT.Close();
        }
        //Método para leer archivo TXT en Documentos > Productos > Productos.txt
        public static List<Producto> ReadFromTXT(string path)
        {
            List<Producto> productos = new List<Producto>();
            StreamReader txtIn = new StreamReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            while(txtIn.Peek()!=-1)
            {
                string line = txtIn.ReadLine();
                string[] columns = line.Split('|');
                Producto p = new Producto(columns[0],columns[1], Int32.Parse(columns[2]), Int32.Parse(columns[3]), 
                                            new PrecioFecha(DateTime.Parse(columns[4]), DateTime.Parse(columns[5]), Decimal.Parse(columns[6]))); 
                productos.Add(p);
            }
            return productos;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Errores Conocidos:\n" + "En la opción 1 al capturar la fecha, no es del todo posible capturar fechas incorrectas\n" +
            "Además, en la misma opción, a la hora de guardar en un archivo, por alguna razón se escriben 233 artículos habiendo solo 43.\n" + 
            "En la opción 2, se imprimen todos los productos, los que significa que se repiten por el cambio de fecha en el mismo archivo. \n" + 
            "En la opción 3, se imprime las excepciones junto a los productos bien ordenados.");
            Console.WriteLine("La excepción general de escribir una fecha fuera de rango hace que se imprima la excepción el número de veces\n " + 
            "que productos hay en el propio archivo (43 veces).");
            //Lista con productos inicializados con precio y fecha
            List<Producto> productos = new List<Producto>();
            productos.Clear();
            /*productos.Add(new Producto("TELEGALM31", "Samsumg Galaxy", 2, 350000, new PrecioFecha(new DateTime(2019,06,01), new DateTime(2019,12,31), 8000)));
            productos.Add(new Producto("TELEGALM11", "Samsumg Galaxy", 2, 375000, new PrecioFecha(new DateTime(2019,06,01), new DateTime(2019,12,31), 3700)));
            productos.Add(new Producto("TELEGALA01", "Samsumg Galaxy", 2, 400000, new PrecioFecha(new DateTime(2019,06,01), new DateTime(2019,12,31), 2400)));
            productos.Add(new Producto("TELEGAS20U", "Samsumg Galaxy", 1, 1550000, new PrecioFecha(new DateTime(2019,06,01), new DateTime(2019,12,31), 30000)));
            productos.Add(new Producto("TELEGALS20", "Samsumg Galaxy", 1, 1250000, new PrecioFecha(new DateTime(2019,06,01), new DateTime(2019,12,31), 20000)));
            productos.Add(new Producto("TELEGAS20P", "Samsumg Galaxy", 1, 1375000, new PrecioFecha(new DateTime(2019,06,01), new DateTime(2019,12,31), 26000)));
            productos.Add(new Producto("TELEGALXZF", "Samsumg Galaxy", 1, 405000, new PrecioFecha(new DateTime(2019,06,01), new DateTime(2019,12,31), 28000)));*/
            try {
            productos = ProductoDB.ReadFromTXT(@".\Productos.txt"); //Archivo previamente creado en carpeta raíz del archivo .cs del programa
            }
            catch (FormatException e){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("Error en formato de Fecha en el archivo Productos.txt\n" + e);
            }
            catch (IndexOutOfRangeException e){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("Parece que hay una linea en blanco entre artículos de la lista.\n Por favor revise el archivo Productos.txt\n" + e);
            }
            catch (Exception e){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("Lo lamento, ha ocurrido un error desconocido.\n" + e);
            }
            //ProductoDB.EscribeAtxt(@".\Productos.txt", productos); //Archivo en carpeta raíz del programa
            
            int caso = -1;
            while(caso != 0){ //Validación de caso.
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nInserte un número según lo que desea hacer");
                Console.WriteLine("\n1 para capturar fecha y buscar precios; \n2 para capturar número de departamento y buscar productos en él." + 
                 "\n3 para ver los productos con más Likes" + "\n0 para Salir");
                try{
                caso = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException e){
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine("Error en formato de captura, introduzca un número válido.\n" + e);
                }
                DateTime dateValue = new DateTime(); //Declaración "global" de variables
            
                switch (caso)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Saliendo del Programa...");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 1:  
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Clear();
                        Console.WriteLine("Precios desde el 01/06/2019 hasta el 01/06/2020");
                        bool fechaCorrecta = false;
                        while(!fechaCorrecta){
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Por favor inserte la fecha que busca en formato DD/MM/AAAA");
                            string dateString = Console.ReadLine();
                            fechaCorrecta = DateTime.TryParse(dateString, out dateValue);
                        }
                        if(!fechaCorrecta){
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Clear();
                            Console.WriteLine("Introduce una fecha correcta.");
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        List<Producto> productosFecha = new List<Producto>();
                        productosFecha.Clear();//Se supone que limpia la Lista
                        ProductoDB.EscribeAtxt(@".\ProductosconFecha.txt", productosFecha);//Creando
                        foreach(Producto p in productos) if(PrecioFecha.GetPrecio(p, dateValue) != null) //Validación de los productos
                        {
                            productosFecha.Add(p);
                            Console.WriteLine("Producto:{0}. Tiene {1} Likes y cuesta ${2} MXN", p.Descripcion, p.Likes, p.PrecioYFecha.Precio);
                            ProductoDB.EscribeAtxt(@".\ProductosconFecha.txt", productosFecha);//Sobreescribiendo
                        }
                        break;
                    case 2:
                        //Captura de departamento
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Clear();
                        Console.WriteLine("Inserte el número de departamento que desea buscar: ");
                        int depabuscado = Int32.Parse(Console.ReadLine());
                        List<Producto> resultado = Producto.GetDepartamento(depabuscado, productos);
                        if (resultado.Count() != 0) //Validando si el departamento existe buscando con el método Count() si regresan valores
                        {
                            Console.WriteLine("Lista de Productos en el Departamento: " + depabuscado);
                            foreach(Producto p in resultado){
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Producto:{0}. Tiene {1} Likes. y cuesta ${2} MXN", p.Descripcion, p.Likes, p.PrecioYFecha.Precio);
                            }
                        }
                        else{
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("\nUn error ha ocurrido, revise que escribió bien el departamento en número");
                            Console.WriteLine("O si ha escrito un departamento existente [1-3]");
                        }
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Precios desde el 01/06/2019 hasta el 01/06/2020");
                        Console.WriteLine("Se usará la fecha actual para la consulta.\n");
                        DateTime dateValue2 = DateTime.Today; //Capturando fecha de hoy

                        //lista donde se ordenan los Likes de mayor a menor
                        List<Producto> productosFecha2 = new List<Producto>();
                        productosFecha2.Clear();
                        foreach(Producto p in productos) if(PrecioFecha.GetPrecio(p, dateValue2) != null) //Validación de los productos
                        {
                            productosFecha2.Add(p);
                        }
                        productosFecha2 = productosFecha2.OrderByDescending(p => p.Likes).ToList(); //Ordenando por Likes
    
                        Console.WriteLine("Productos con más Likes ordenados de mayor a menor: ");
                        foreach(Producto p in productosFecha2){
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Producto:{0}. Tiene {1} Likes y cuesta ${2} MXN", p.Descripcion, p.Likes, p.PrecioYFecha.Precio);
                        }
                        break;
                    default: 
                        Console.BackgroundColor = ConsoleColor.Black;
    
                        Console.Clear();
                        Console.WriteLine("Inserte un número de caso válido. (1, 2, 3 o 0 para salir).");
                        break;
                } //Fin del Switch
            }
        }
    }
}