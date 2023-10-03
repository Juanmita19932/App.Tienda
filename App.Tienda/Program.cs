using System.Data;

namespace App.Tienda;

public class Presentacion
{
    public static void Main(string[] args)
    {
        Gestion gestion = new Gestion();
        int eleccion;

        do
        {
            Console.WriteLine("Bienvenido al menú de Tienda");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("¿Qué desea realizar?");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. Introducir nuevo Fabricante");
            Console.WriteLine("2. Introducir nuevo Articulo");
            Console.WriteLine("3. Lista de Fabricantes");
            Console.WriteLine("4. Lista de Articulos");
            Console.WriteLine("5. Salir");
            Console.WriteLine();

            eleccion = Convert.ToInt32(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    Console.WriteLine("Ingrese el nombre del fabricante: ");
                    string nombreFabricante = Console.ReadLine();
                    gestion.AltaFabricante(nombreFabricante);
                    Console.WriteLine("Fabricante agregado con éxito.");
                    break;

                case 2:
                    Console.WriteLine("Ingrese el nombre del artículo: ");
                    string nombreArticulo = Console.ReadLine();
                    Console.WriteLine("Ingrese el precio del artículo: ");
                    int precioArticulo = Convert.ToInt32(Console.ReadLine());
                    gestion.AltaArticulo(nombreArticulo, precioArticulo);
                    Console.WriteLine("Artículo agregado con éxito.");
                    break;

                case 3:
                    DataTable fabricantes = gestion.ListarFabricantes();
                    Console.WriteLine("Lista de fabricantes:");
                    foreach (DataRow row in fabricantes.Rows)
                    {
                        int id = (int)row[0];
                        string nombre = (string)row[1];
                        Console.WriteLine("ID: " + id + ", Nombre: " + nombre);
                    }
                    break;

                case 4:
                    DataTable articulos = gestion.ListarArticulos();
                    Console.WriteLine("Lista de artículos:");
                    foreach (DataRow row in articulos.Rows)
                    {
                        int id = (int)row[0];
                        string nombre = (string)row[1];
                        int precio = (int)row[2];
                        Console.WriteLine("ID: " + id + ", Nombre: " + nombre + ", Precio: " + precio);
                    }
                    break;

                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }

            Console.WriteLine();
        } while (eleccion != 5);
    }
}
//DataTable dt = gestion.ListarFabricantes();

// {

//     foreach (DataRow row in dt.Rows)
//     {
//         int id = (int)row[0];
//         string nombre = (string)row[1];

//         Console.WriteLine("ID: " + id + ", Nombre: " + nombre);
//     }
// }

// DataTable dt2 = gestion.ListarArticulos();

// {

//     foreach (DataRow row in dt2.Rows)
//     {
//         int id = (int)row[0];
//         string nombre = (string)row[1];
//         int Precio= (int)row[2]; 


//         Console.WriteLine("ID: " + id + ", Nombre: " + nombre + "Precio:" + Precio);
//     }
// }





