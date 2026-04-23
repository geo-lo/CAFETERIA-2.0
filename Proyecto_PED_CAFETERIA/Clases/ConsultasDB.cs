using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PED_CAFETERIA.Clases
{
    internal class ConsultasDB : ConexionDB
    {

        //Obtener datos (Select) de la tabla Inventario
        public DataTable MostrarInventario()
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();

            comando.Connection = AbrirConexion();
            comando.CommandText = "SELECT IdProducto, NombreProducto, CantidadActual, PrecioUnitario FROM Inventario"; //Consulta SQL para obtener todos los productos

            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer); //Cargar los datos en la tabla

            leer.Close();
            CerrarConexion();
            return tabla;
        }

        //Insertar datos (Insert) en la tabla Inventario
        public void Insertar(string nombre, int cantidad, double precio )

        {
            if (ExisteProducto(nombre))
            {
                MessageBox.Show("El producto ya existe en el inventario.");
                // Si existe, salimos de la función devolviendo 'false'
                return ;
            }

            SqlCommand comando = new SqlCommand();
            comando.Connection = AbrirConexion();
            comando.CommandText = "INSERT INTO Inventario (NombreProducto, CantidadActual, PrecioUnitario) VALUES (@nombre, @cantidad, @precio)"; //Consulta SQL para insertar un nuevo producto
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@precio", precio);
            
            comando.ExecuteNonQuery();
            CerrarConexion();
        }

        //Actualizar datos (Update) en la tabla Inventario
        public void EditarProducto(string nombre, int cantidad, double precio)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = AbrirConexion();

            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@precio", precio);

            comando.ExecuteNonQuery();
            CerrarConexion() ;
        }

        //Eliminar datos (Delete) de la tabla Inventario
        public void EliminarProducto(int id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = AbrirConexion();
            comando.CommandText = "DELETE FROM Inventario WHERE IdProducto = @id"; //Consulta SQL para eliminar un producto por su ID
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            CerrarConexion();
        }
        //Buscar producto por nombre en la tabla Inventario
        public DataTable BuscarPorId(int id)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();

            comando.Connection = AbrirConexion();

            // Usamos el parámetro @id para filtrar la búsqueda
            comando.CommandText = "SELECT * FROM Inventario WHERE IdProducto = @id";
            comando.Parameters.AddWithValue("@id", id);

            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);

            leer.Close();
            CerrarConexion();

            return tabla;
        }

        // Función auxiliar privada para validar existencia de un producto por su nombre
        private bool ExisteProducto(string nombre)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = AbrirConexion();
            comando.CommandText = "SELECT COUNT(*) FROM Inventario WHERE NombreProducto = @nombre";
            comando.Parameters.AddWithValue("@nombre", nombre);

            int conteo = Convert.ToInt32(comando.ExecuteScalar());
            CerrarConexion();

            return conteo > 0;
        }
    }
}
