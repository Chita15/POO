using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace BaratillosChitaT2
{
    class Program
    {
        class Producto
        {
            public string Codigo { get; set; }
            public string Descripción { get; set; }
            public double Precios, PrecioFF;
            public int Departamento { get; set; }
            public int Likes { get; set; }
            public DateTime FechaProducto, FechaFF;

            //Se genera el constructor del Producto para asignar los valores que tendrá cada producto 
            public Producto(string Codigo, string Descripción, int Departamento, double Precios, int Likes, DateTime FechaProducto, DateTime FechaFF, double PrecioFF)
            {
                this.Codigo = Codigo;
                this.Descripción = Descripción;
                this.Departamento = Departamento;
                this.Likes = Likes;
                this.Precios = Precios;
                this.FechaProducto = FechaProducto;
                this.FechaFF = FechaFF;
                this.PrecioFF = PrecioFF;
            }
            public Producto() { }

            public static List<Producto> GetDepartamento(int depar, List<Producto> productos) 
        {
            List<Producto> ProductoD = new List<Producto>();
            Console.WriteLine("\nLos productos dentro de ese departamento son:\n");
            foreach(Producto p in productos)
            {
                if(p.Departamento == depar)
                {
                    ProductoD.Add(p);
                }                
            }
                if(depar > 5 || depar < 0)
                    {
                        Console.WriteLine("\t\t¡¡¡No existe ese departamento!!!");
                    }
            return ProductoD;
        }

           /* public static List<Producto> OrdenaLikes(List<Producto> productosFecha) //Ordenamiento de likes por Reverse() pero con condición, no libre
                {
                 List<Producto> ordenadoslik = new List<Producto>();
                    productosFecha.Reverse();
                
                    foreach (Producto p in productosFecha)
                    {
                        
                        Console.WriteLine("Código: |{0}| Descripción: |{1}| Departamento: |{2}| Likes: |{3}| Fecha Inicial: |{4}| Precio Inicial: |{5}| Fecha Final: |{6}| Precio Final: |{7}| \n", p.Codigo, p.Descripción, p.Departamento, p.Likes, p.FechaProducto, p.Precios, p.FechaFF, p.PrecioFF);
                        ordenadoslik.Add(p);
                    }   
                    return ordenadoslik;
                }*/
                public static void OrdenaLikes(List<Producto> productos)
                {
                 IEnumerable<Producto> likes = /*productos.AsQueryable().OrderBy(Producto => productos.Likes);*/
                                               from p in productos
                                               orderby p.Likes
                                               select p;
                    foreach(Producto p in likes)
                    Console.WriteLine("Código: |{0}| Descripción: |{1}| Departamento: |{2}| Likes: |{3}| Fecha Inicial: |{4}| Precio Inicial: |{5}| Fecha Final: |{6}| Precio Final: |{7}| \n", p.Codigo, p.Descripción, p.Departamento, p.Likes, p.FechaProducto, p.Precios, p.FechaFF, p.PrecioFF);
                   
                }
        }


        class ProductoDB
        {
            //Escribir todos los productos disponibles en la tienda a un archivo
            public static void WriteToTXT(string path, List<Producto> productos)
            {
                try{
                StreamWriter txtOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
                foreach (Producto p in productos)
                {
                    txtOut.WriteLine("Código: |{0}| Descripción: |{1}| Departamento: |{2}| Likes: |{3} ♥| Fecha Inicial: |{4}| Precio Inicial: |{5} $| Fecha Final: |{6}| Precio Final: |{7} $| ", p.Codigo, p.Descripción, p.Departamento, p.Likes, p.FechaProducto, p.Precios, p.FechaFF, p.PrecioFF);
                }
                txtOut.Close();
                }
                catch(IOException EM)
                {
                    Console.WriteLine("Error con el archivo");
                    Console.WriteLine(EM.Message);
                }
            }

            //Nuevo metodo creado para escribir los productos que son solicitados por el usuario dependiendo de la fecha
            //que se ingresa. Se escriben en un nuevo archivo.
            public static void CrearNuevoArchivo(string path, List<Producto> productos, DateTime fecha)
            {
                try{
                StreamWriter nuevoArchivo = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
                List<Producto> productosFecha = new List<Producto>();

                            foreach (Producto p in productos)
                            //Condiciones por si el usuario ingresa un mes o año en el que no existe un producto con tales fechas
                             if(p.FechaProducto.Year < fecha.Year && p.FechaFF.Year < fecha.Year|| p.FechaProducto.Year > fecha.Year && p.FechaFF.Year > fecha.Year || fecha.Month < 5)
                            {
                                Console.WriteLine("No hay productos con esa fecha solicitada");
                            }
                            //Cuando se ingresa un fecha válida. Son 30 días de "promoción".
                            else if (p.FechaProducto.Day <= (fecha.Day + 30) && p.FechaProducto.Day >= fecha.Day)
                            {
                            productosFecha.Add(p);
                            }

                if(productosFecha.Count != 0)
                {
                    foreach (Producto p in productosFecha)
                    {
                        nuevoArchivo.WriteLine("Código: |{0}| Descripción: |{1}| Departamento: |{2}| Likes: |{3} ♥| Fecha Inicial: |{4}| Precio Inicial: |{5} $| Fecha Final: |{6}| Precio Final: |{7} $| ", p.Codigo, p.Descripción, p.Departamento, p.Likes, p.FechaProducto, p.Precios, p.FechaFF, p.PrecioFF);
                        Console.WriteLine("Código: |{0}| Descripción: |{1}| Departamento: |{2}| Likes: |{3} ♥| Fecha Inicial: |{4}| Precio Inicial: |{5} $| Fecha Final: |{6}| Precio Final: |{7} $| ", p.Codigo, p.Descripción, p.Departamento, p.Likes, p.FechaProducto, p.Precios, p.FechaFF, p.PrecioFF);
                        Console.ReadKey();
                    }
                    Console.WriteLine("\n\t\t\t¡LOS ARCHIVOS SE HAN GENERADO CON ÉXITO!\n");
                    nuevoArchivo.Close();
                }
                else
                Console.WriteLine("\n\t\t\tPresiona Enter para salir del programa\n");
                Console.ReadKey();
                }
                catch(IOException Err)
                {
                    Console.WriteLine("Error con el archivo");
                    Console.WriteLine(Err.Message);
                }
            }
           /* public static void ReadCrearNuevoArchivo(string path, List<Producto> productosFecha)
            {   
                try
                {
                List<Producto> productosF = new List<Producto>();
                StreamReader txtIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
                foreach(Producto p in productosFecha)
                Console.WriteLine("Código: |{0}| Descripción: |{1}| Departamento: |{2}| Likes: |{3}| Fecha Inicial: |{4}| Precio Inicial: |{5}| Fecha Final: |{6}| Precio Final: |{7}| ", p.Codigo, p.Descripción, p.Departamento, p.Likes, p.FechaProducto, p.Precios, p.FechaFF, p.PrecioFF);
                Producto.OrdenaLikes(productosFecha);
                
                string line;
                while (txtIn.Peek() != -1)
                {
                 line = txtIn.ReadLine();
                 
                }
                }
                catch(IOException Rerror)
                {
                    Console.WriteLine("Hubo un error al abrir el archivo y dar lectura");
                    Console.WriteLine(Rerror.Message);
                }
            }*/ //Intento de dar lectura a los productos del nuevo archivo para ordenarlos por likes
            
            /*public static void ReadFromTXT(string path, List<Producto> productos)
            {
                try
                {
                StreamReader txtIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

                List<Producto> productosFecha;
                string line;
                while (txtIn.Peek() != -1)
                {
                    line = txtIn.ReadLine();
                }
                }
                catch(IOException ME)
                {
                    Console.WriteLine("Hubo un error con el archivo o al momento de abrirlo");
                    Console.WriteLine(ME.Message);
                }

            }*/
           /* public static void ReadFromTXT(string path, List<Producto> productos)
            {
                try{
                List<Producto> products = new List<Producto>();
                StreamReader txtIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
                while (txtIn.Peek() != -1)
                {
                    string line = txtIn.ReadLine();
                    string[] columns = line.Split('|');
                    Producto p = new Producto(columns[1], columns[3], int.Parse(columns[5]), int.Parse(columns[11]), int.Parse(columns[7]), DateTime.Parse(columns[9]), DateTime.Parse(columns[13]), double.Parse(columns[15]));
                    products.Add(p);
                }
                }
                catch(IOException txtError)
                {
                    Console.WriteLine("Error de lectura al abrir el archivo");
                    Console.WriteLine(txtError.Message);
                }

            }*/
        }

        static void Main(string[] args)
        {
            //Creación de la variable fecha para solicitarla al usuario 
            DateTime fecha;
            //Creación de la varible para tomar la decisión de buscar por departamento 
            string decisión;
            //Creación de la variable para tomar la decisión de mostrar ordenamiento de los productos por likes
            string decision2;

            //Console.BackgroundColor = ConsoleColor.Magenta; //Cambiar el color de fondo en la consola
            //Console.ForegroundColor = ConsoleColor.White;  //Cambiar el color del texto en consola
            Console.Clear(); //Limpiar la consola al correrla de nuevo 

            //Breve descripción y presentación para la tienda
            Console.WriteLine("\t\t\t¡Bienvenido(a) a Baratillos Chita!\n");
            Console.WriteLine("\tAquí podrás adquirir los productos que necesites a precios accesibles.");
            Console.WriteLine("\t¡Vamos!, ingresa una fecha y ve los artículos que tenemos disponibles.\n");

            //Creación de los productos 
            //El DateTime se colocara al constructor en la clase producto, luego comprobara el dia que tiene ese date time, a pesar que
            //parece string, lo separa por mes, año y dias 
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("147548", "Libretas Universitarias", 05, 70, 500, new DateTime(2020, 05, 20), new DateTime(2020, 12, 31), 120));
            productos.Add(new Producto("147548", "Plumones Sharpie\t", 05, 65.3, 453, new DateTime(2020, 07, 20), new DateTime(2020, 12, 31), 85.5));
            productos.Add(new Producto("258969", "Pringles Original\t", 04, 30, 489, new DateTime(2020, 10, 12), new DateTime(2020, 12, 25), 65.30));
            productos.Add(new Producto("258969", "SOUR PATCH Kids\t", 04, 50, 576, new DateTime(2020, 08, 26), new DateTime(2020, 12, 15), 100));
            productos.Add(new Producto("354157", "Laptop LENOVO ideapad 330\t", 03, 2500, 372, new DateTime(2020, 05, 25), new DateTime(2020, 12, 31), 3200));
            productos.Add(new Producto("159604", "Crema NIVEA Milk Nutrive\t", 02, 43.6, 339, new DateTime(2020, 12, 12), new DateTime(2020, 12, 31), 60.8));
            productos.Add(new Producto("642819", "Camiseta lisa para mujer\t", 01, 65, 132, new DateTime(2020, 10, 12), new DateTime(2020, 12, 01), 85.90));
            productos.Add(new Producto("642819", "Blusa de tirantes verde\t", 01, 38.4, 162, new DateTime(2020, 8, 12), new DateTime(2020, 12, 05), 72.15));

            ProductoDB.WriteToTXT("ProductosChitaT.txt", productos);
            //ProductoDB.ReadFromTXT("./ProductosChitaT.txt");

            //Entrada de la fecha 
            Console.WriteLine("Ingrese fecha (Año, Mes, Día): ");
           try
            {
                fecha = Convert.ToDateTime(Console.ReadLine());
                Console.Clear(); //Limpiar la consola una vez se ingresa la fecha para mostrarla en un formato
                Console.WriteLine("Para la fecha ingresada: {0}", (fecha.ToString("MM/dd/yyyy"))); //Se muestra la fecha ingresa en el formato establecido para que se relacione con el formato de las fechas de los productos
                Console.WriteLine("\nLos productos disponibles son:\n");
                ProductoDB.CrearNuevoArchivo("ProductosEnConsola.txt", productos, fecha);
            }
            catch (FormatException ErrorFormato)
            {
                Console.WriteLine("\t ---El formato es incorrecto debes ingresar números, NO caracteres o has ingresado meses/días inexistentes--- \n\t\t\t\t\t\t ¡¡¡REVISALO (0_0)!!!");
                Console.WriteLine(ErrorFormato.Message);
            }
            finally
            {      
                //Se deja vacio para que permita hacer lectura de la excepción y además continuar con el proceso para
                //escribir en el archivo
            }

        //Buscar productos por departamento 
            //Console.Clear();
            Console.WriteLine("\n\n\t--------------------------Productos por departamento--------------------------");
            Console.WriteLine("\n¿Deseas buscar un producto por departamentos? Si/No");
            decisión = Console.ReadLine();
            if(decisión == "No" || decisión == "no")
            {
                Console.WriteLine("\nPresione Enter para salir del programa\n");
                Console.ReadKey();
            }          
            else if( decisión == "Si" || decisión == "si")
            {
            try
            {
                Console.WriteLine("\nIngresa el número de departamento para mostrar los productos disponibles: \nDepartamento [1]: Ropa de Mujer \nDepartamento [2]: Cremas \nDepartamento [3]: Electrónica \nDepartamento [4]: Botanas \nDepartamento [5]: Escolares ");
                List<Producto> numerodep = Producto.GetDepartamento(Int16.Parse(Console.ReadLine()), productos);
                //Console.WriteLine("Los productos dentro de ese departamento departamento son: \n");
                foreach(Producto p in numerodep)  
                Console.WriteLine("Código: |{0}| Descripción: |{1}| Departamento: |{2}| Likes: |{3} ♥| Fecha Inicial: |{4}| Precio Inicial: |{5} $| Fecha Final: |{6}| Precio Final: |{7} $| ", p.Codigo, p.Descripción, p.Departamento, p.Likes, p.FechaProducto, p.Precios, p.FechaFF, p.PrecioFF);
                //Console.WriteLine("\n**Nota: En caso de no mostrar productos es porque el departamento ingresado no existe.**\n");
            }
                catch (FormatException ErrorDepartamento )
                {
                Console.WriteLine("\t\t\t¡OJO! Te has equivocado al ingresar el dato debe ser número");
                Console.WriteLine(ErrorDepartamento.Message);
                }
            }
            
            //Console.ReadKey();
            Console.WriteLine("\n\t\t-------------------Likes♥---------------------");
            Console.WriteLine("\n¿Quieres ver nuestros productos ordenados por likes? Si/No");
            decision2 = Console.ReadLine();
            if(decision2 == "No" || decision2 == "no")
            {
                Console.WriteLine("\nPresione Enter para salir del programa\n");
                Console.ReadKey();
            }
            else if( decision2 == "Si" || decision2 == "si")
            {
            Console.WriteLine("\nTeclea Enter para ver todos los productos que se tienen en promoción ordenados por likes♥ (de menor a mayor)\n");
            Console.ReadKey();
            Producto.OrdenaLikes(productos);
            //ProductoDB.ReadCrearNuevoArchivo(@".\ProductosEnConsola.txt", productos); Intento por mostrar likes pero dando lectura a el archivo de la consola
            }
        }
    }
 }
