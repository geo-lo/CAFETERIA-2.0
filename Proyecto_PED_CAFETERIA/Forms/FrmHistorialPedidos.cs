using CAFETERIA.ClasesNuevas;
using Proyecto_PED_CAFETERIA.Clases;
using System;
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
    public partial class FrmHistorialPedidos : Form
    {
        public static FrmHistorialPedidos instancia;

        public FrmHistorialPedidos()
        {
            InitializeComponent();
            instancia = this;
        }

        public void AgregarHistorial(string cliente, string productos, string total)
        {
           
        }

        private void FrmHistorialPedidos_Load(object sender, EventArgs e)
        {

            ConfigurarGridHistorial();
           // CargarHistorial();
            estiloDataGrid(dgvHistorial);
            dgvHistorial.MultiSelect = false;
            dgvHistorial.ReadOnly = true;

            MostrarPedidos();
            estiloDataGrid(dgvHistorial);
            foreach (DataGridViewColumn col in dgvHistorial.Columns)
            {
                col.Frozen = false;
            }
        }

        private void ConfigurarGridHistorial()
        {
            dgvHistorial.Columns.Clear();
            dgvHistorial.Rows.Clear();
            dgvHistorial.AutoGenerateColumns = false;

            dgvHistorial.Columns.Add("Cliente", "Cliente");
            dgvHistorial.Columns.Add("Productos", "Productos");
            dgvHistorial.Columns.Add("Total", "Total");

            foreach (DataGridViewColumn col in dgvHistorial.Columns)
            {
                col.Frozen = false;
            }
        }
        public void MostrarPedidos()
        {
            dgvHistorial.Rows.Clear();

            NodoHistorial actual = ClaseGlobal.historial.Primero;

            while (actual != null)
            {
                dgvHistorial.Rows.Add(
                    actual.Cliente,
                    actual.Productos,
                    actual.Total
                );

                actual = actual.siguiente;
            }

        }

        private void estiloDataGrid(DataGridView dataHistorial)
        {
            if (dataHistorial == null || dataHistorial.IsDisposed)
                return;

            foreach (DataGridViewColumn col in dataHistorial.Columns)
            {
                col.Frozen = false;
            }

            dataHistorial.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataHistorial.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataHistorial.BorderStyle = BorderStyle.None;
            dataHistorial.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataHistorial.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(236, 228, 217);
            dataHistorial.BackgroundColor = Color.FromArgb(230, 220, 205);
            dataHistorial.GridColor = Color.FromArgb(210, 190, 170);

            dataHistorial.DefaultCellStyle.SelectionBackColor = Color.FromArgb(141, 102, 77);
            dataHistorial.DefaultCellStyle.SelectionForeColor = Color.White;

            dataHistorial.EnableHeadersVisualStyles = false;
            dataHistorial.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataHistorial.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(92, 64, 51);
            dataHistorial.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataHistorial.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataHistorial.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataHistorial.ColumnHeadersHeight = 38;

            dataHistorial.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataHistorial.DefaultCellStyle.ForeColor = Color.FromArgb(70, 45, 30);

            dataHistorial.RowHeadersVisible = false;
            dataHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataHistorial.MultiSelect = false;
            dataHistorial.ReadOnly = true;
        }

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // ESTE BOTON MANDA EL PEDIDO A PREPARADOS
        private void btnPreparar_Click(object sender, EventArgs e)
        {
            
        }
    }
}