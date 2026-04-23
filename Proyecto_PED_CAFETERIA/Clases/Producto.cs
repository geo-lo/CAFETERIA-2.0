using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFETERIA.ClasesNuevas
{
    public class Producto
    {

        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }

        public Double Precio { get; set; }
        public Button Boton { get; set; }
        public string Categoria { get; set; }
        public Image Imagen { get; set; }

        public double Total
        {
            get { return Cantidad * Precio; }
        }
        public Producto(string nombreProducto, int cantidad, double precio,Button boton, string categoria,Image imagen)
        {
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
            Precio = precio;
            Boton = boton;
            Categoria = categoria;
            Imagen = imagen;
        }
    }
}
