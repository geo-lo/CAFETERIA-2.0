using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_PED_CAFETERIA.Clases
{
    internal class ConexionDB
    {
        // Cadena de conexión para SQL Server Express
        private readonly string connectionString =
            "Server=.\\SQLEXPRESS; Database=CafeteriaDB; Integrated Security=True; TrustServerCertificate=True;";

        // Objeto de conexión
        protected SqlConnection connection;

        // Método para abrir la conexión a la base de datos
        public SqlConnection AbrirConexion()
        {
            try
            {
                connection = new SqlConnection(connectionString);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                return connection;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "No se pudo conectar con la base de datos.\n\n" +
                    "Verifique lo siguiente:\n" +
                    "1. Que SQL Server esté iniciado.\n" +
                    "2. Que exista la base de datos CafeteriaDB.\n" +
                    "3. Que el servidor sea .\\SQLEXPRESS.\n\n" +
                    "Detalle del error:\n" + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return null;
            }
        }

        // Método para cerrar la conexión a la base de datos
        public void CerrarConexion()
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cerrar la conexión:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}