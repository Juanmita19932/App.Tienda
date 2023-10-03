using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Tienda
{
    public class Conexion
    {
            private MySqlConnection conexion;
        public Conexion()
        {
            try
            {
                string connectionString = "server=127.0.0.1;database=tienda;user=root;password=;";
                conexion = new MySqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
            public void AbrirConexion()
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
            public void CerrarConexion()
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            public MySqlConnection ObtenerConexion()
            {
                return conexion;
            }
    }
}
