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
    public partial class frmSalida : Form
    {
        public frmSalida()
        {
            InitializeComponent();
        }

        private void frmSalida_Load(object sender, EventArgs e)
        {
            //texto centrado
            lblS.TextAlign = ContentAlignment.MiddleCenter;
            lblS.Text = "ESTAS SEGURO QUE QUIERES SALIR?";
            lblS.ForeColor = Color.FromArgb(100, 60, 30);
            lblS.Font = new Font("UNISPACE", 12, FontStyle.Bold);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("GRACIAS POR VISITAR LA COPA FELIZ, VUELVE PRONTO!","AVISO");
            Application.Exit();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            FrmVistaUsuario regresar = new FrmVistaUsuario();
            regresar.ShowDialog();
        }
    }
}
