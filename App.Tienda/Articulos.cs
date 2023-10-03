using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Tienda
{
    public class Articulos
    {
       public int ClaveArticulo { get; set; }
        public string Nombre { get; set; }
        public int Precio {  get; set; }
        public int ClaveFabricante {  get; set; }

        public Articulos(string nombre, int precio) 
        { 
            Nombre =nombre;
            Precio =precio;
        }
        public Articulos(int claveArticulo, string nombre, int precio, int claveFabricante)
        {
            ClaveArticulo = claveArticulo;
            Nombre = nombre;
            Precio = precio;
            ClaveFabricante = claveFabricante;
        }
    }
}
