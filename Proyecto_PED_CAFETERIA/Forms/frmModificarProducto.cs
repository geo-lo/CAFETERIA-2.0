using System;
using Proyecto_PED_CAFETERIA.Clases;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PED_CAFETERIA.Forms
{
    public partial class frmModificarProducto : Form
    {
        public frmModificarProducto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ConsultasDB repo = new ConsultasDB();

            // 1. Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // 2. Validación de formato numérico (Usando TryParse para evitar cierres inesperados)
            if (!int.TryParse(txtCantidad.Text, out int cantidad) ||
                !decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
                return;
            }

            if (precio < 0 || cantidad < 0)
            {
                MessageBox.Show("Por favor, ingrese valores positivos.");
                return;
            }

            try
            {
                // 3. Decidir si Insertar o Editar basándonos en si recibimos un ID
                if (string.IsNullOrEmpty(idRecibido))
                {
                    repo.Insertar(txtNombre.Text, cantidad, (double)precio);
                    MessageBox.Show("Producto agregado con éxito.");
                }
                else
                {
                    // Intentamos editar usando el ID que llegó desde el otro Form
                    if (int.TryParse(idRecibido, out int id))
                    {
                        repo.EditarProducto(id, txtNombre.Text, cantidad, 5, precio);
                        MessageBox.Show("Producto modificado con éxito.");
                    }
                }

                // 4. Avisar al formulario principal que refresque la tabla
                refrescar?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar: " + ex.Message);
            }
        }
        public event Action refrescar; //evento para refrescar el datagridview del inventario después de agregar un nuevo producto

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string idRecibido; // Variable para almacenar el ID recibido del formulario Inventario
    }
}
