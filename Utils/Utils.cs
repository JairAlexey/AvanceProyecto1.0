using app1Clases.Models;

namespace app1Clases.Utils
{
    public class Utils
    {
        static public List<Producto> ListaProductos = new List<Producto>()
        {
            new Producto(1,"Leche", "Marca Andina", 1),
            new Producto(2,"Arroz", "Arroz viejo", 2),
            new Producto(3,"Huevos", "Gallina", 3),
            new Producto(4,"Pan", "Blanco", 4),

        };
    }
    
}
