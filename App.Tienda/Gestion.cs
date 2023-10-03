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
        public DataTable ListarFabricantes()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM fabricantes",
                connection.ObtenerConexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

    public DataTable ListarArticulos()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM articulos",
               connection.ObtenerConexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);

            return dt2;
        }



    }
}
