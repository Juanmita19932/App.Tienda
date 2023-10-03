using System.Data;

namespace App.Tienda;

public class Presentacion
{
    public static void Main(string[] args)
    {
       Gestion gestion = new Gestion();
        gestion.AltaFabricante("");
        gestion.AltaArticulo("Pantalla", 12);

       DataTable dt = gestion.ListarFabricantes();
 
        {
         
            foreach (DataRow row in dt.Rows)
            {
                int id = (int)row[0];
                string nombre = (string)row[1];

                Console.WriteLine("ID: " + id + ", Nombre: " + nombre);
            }
        }

        DataTable dt2 = gestion.ListarArticulos();

        {

            foreach (DataRow row in dt2.Rows)
            {
                int id = (int)row[0];
                string nombre = (string)row[1];
                int Precio= (int)row[2]; 
                

                Console.WriteLine("ID: " + id + ", Nombre: " + nombre + "Precio:" + Precio);
            }
        }


    }
}
