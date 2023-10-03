using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App.Tienda
{
    internal class Gestion
    {
        Conexion connection;
        public Gestion()
        {
            connection = new Conexion();
            connection.AbrirConexion();
        }

        public void AltaFabricante(string Nombre)
        {

            Fabricantes Fabricante = new Fabricantes(Nombre);
       
            String Insert = "INSERT INTO fabricantes (Nombre) VALUES (@valor1)";
            MySqlCommand insertCommand = new MySqlCommand(Insert, connection.ObtenerConexion());

            insertCommand.Parameters.AddWithValue("@valor1" , Fabricante.Nombre);

            insertCommand.ExecuteNonQuery();
       

        }
        public void AltaArticulo(string Nombre, int Precio)
        {
            Articulos Articulo = new Articulos (Nombre, Precio);
            
                String Insert = "INSERT INTO articulos (Nombre, Precio) VALUES (@valor2, @valor3)";
                MySqlCommand insertCommand = new MySqlCommand(Insert, connection.ObtenerConexion());
                insertCommand.Parameters.AddWithValue("@valor2", Articulo.Nombre);
                insertCommand.Parameters.AddWithValue("@valor3", Articulo.Precio);
               
                insertCommand.ExecuteNonQuery();
            
        }
         

        public List<Fabricantes> ListaFabricantes()
        {
            return new List<Fabricantes>();
        } 
       public List <Articulos> ListaArticulos()
        {
            return new List<Articulos>();   
        }
    }
}
