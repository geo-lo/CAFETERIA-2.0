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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
            Diseño();
        }

        private void Diseño()
        {
            // FORM
            this.BackColor = Color.White;
            this.Size = new Size(1200, 700);

        }

    }

}
