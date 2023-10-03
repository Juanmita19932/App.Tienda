using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Tienda
{
    public class Fabricantes
    {
        public int ClaveFabricante {  get; set; }
        public string Nombre { get; set; }

        public Fabricantes(string nombre)
        {
            
            Nombre = nombre;
        }

        
    }
}
