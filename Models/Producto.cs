namespace app1Clases.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set;}
        public string Descipcion { get; set; }
        public int Cantidad { get; set; }

        public Producto(int idProducto, string nombre, string descipcion, int cantidad)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Descipcion = descipcion;
            Cantidad = cantidad;
        }
       
    }
}
