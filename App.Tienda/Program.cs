namespace App.Tienda;

public class Presentacion
{
    public static void Main(string[] args)
    {
       Gestion gestion = new Gestion();
        gestion.AltaFabricante("");
        gestion.AltaArticulo("Pantalla", 12);

    }
}
