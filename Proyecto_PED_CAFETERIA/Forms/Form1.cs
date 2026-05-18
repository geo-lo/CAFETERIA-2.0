using Proyecto_PED_CAFETERIA.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PED_CAFETERIA
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // 1. AMPLIAR EL FORMULARIO (Fundamental para que quepa el logo a la derecha)
            this.Size = new Size(720, 420);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(250, 244, 236);
            this.FormBorderStyle = FormBorderStyle.None;

            // 2. AJUSTAR EL LOGO (PictureBox) PARA QUE NO TAPE NADA
            // Lo movemos bien a la derecha y un poco hacia arriba
            if (pictureBox1 != null)
            {
                pictureBox1.Size = new Size(240, 240); // Tamaño moderado
                                                       // Posición X: 420 (lejos de los campos de texto), Posición Y: 40
                pictureBox1.Location = new Point(420, 40);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Transparent;
            }

            // 3. POSICIÓN DE LOS BOTONES (En la parte inferior)
            int botonesY = 320; // Bajamos los botones para que el logo no los alcance

            // button2 (SALIR) y button3 (REGRESAR) con tus nombres originales
            button2.Location = new Point(190, botonesY);
            button3.Location = new Point(330, botonesY);

            // Si tienes el botón de ENTRAR (ejemplo button1)
            if (button1 != null)
            {
                button1.Location = new Point(50, botonesY);
                DiseñarBotonLogin(button1, Color.FromArgb(107, 142, 85), "ENTRAR");
            }

            // 4. APLICAR ESTILOS RESTANTES
            DiseñarBotonLogin(button2, Color.FromArgb(170, 68, 68), "SALIR");
            DiseñarBotonLogin(button3, Color.FromArgb(120, 72, 40), "REGRESAR");

            // Redondear el formulario
            RedondearControl(this, 40);
        }
        private void EstiloLabel(Label lbl)
        {
            lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(92, 64, 51);
        }
        private void DiseñarBotonLogin(Button btn, Color color, string texto)
        {
            btn.Text = texto;
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.Size = new Size(110, 40);
            RedondearControl(btn, 12);
        }
        private void RedondearControl(Control control, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(control.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(control.Width - radio, control.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, control.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();
            control.Region = new Region(path);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmVistaUsuario regresar = new FrmVistaUsuario();
            this.Hide();
            regresar.Show();
        }
    }
}
