using CAFETERIA.ClasesNuevas;
using Proyecto_PED_CAFETERIA.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PED_CAFETERIA.Forms
{
    public partial class FrmPedirOrden : Form
    {
        string nombreProducto;
        double precio;
        ListaProductos lista = new ListaProductos();

        public FrmPedirOrden()
        {
            InitializeComponent();
        }

        public FrmPedirOrden(string nombreProducto, double precio)
        {
            InitializeComponent();
            this.nombreProducto = nombreProducto;
            this.precio = precio;
          
        }
        

        // MÉTODO PARA REDONDEAR
        private void RedondearControl(Control control, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            path.AddArc(new Rectangle(control.Width - radio, 0, radio, radio), 270, 90);
            path.AddArc(new Rectangle(control.Width - radio, control.Height - radio, radio, radio), 0, 90);
            path.AddArc(new Rectangle(0, control.Height - radio, radio, radio), 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }



        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            //
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //METODO PARA CREAR BOTONES DINAMICOS
        private void CrearBotonProducto(ListaProductos lista, TabPage pagina, string categoria)
        {
            pagina.Controls.Clear();
            pagina.AutoScroll = true;

            int columnas = 3;
            int anchoBtn = 230;
            int altoBtn = 275;
            int margen = 10;

            int i = 0;
            Nodo_ListaProductos actual = lista.Primero;

            while (actual != null)
            {
                Producto p = actual.ProductoGuardado;

                if (p.Categoria != categoria)
                {
                    actual = actual.siguiente;
                    continue;
                }

                Button btn = new Button();

                // --- ELIMINAMOS EL TEXTO PARA QUE NO TAPE LA IMAGEN ---
                btn.Text = "";

                // --- CONFIGURACIÓN DE IMAGEN ---
                btn.BackgroundImage = p.Imagen;
                btn.BackgroundImageLayout = ImageLayout.Zoom;

                // --- ESTILO DEL BOTÓN ---
                btn.Size = new Size(anchoBtn, altoBtn);
                btn.BackColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0; // Sin bordes para que resalte tu diseño
                btn.Cursor = Cursors.Hand;

                int fila = i / columnas;
                int columna = i % columnas;

                int x = margen + (columna * (anchoBtn + margen));
                int y = margen + (fila * (altoBtn + margen));

                btn.Location = new Point(x, y);

                // EVENTO CLICK
                btn.Click += (s, e) =>
                {
                    frmCantidad frm = new frmCantidad(
                        p.NombreProducto,
                        p.Precio,
                        p.Imagen,
                        p.Descripcion,
                        p.Categoria
                    );

                    estiloForm(frm);
                    frm.ShowDialog();
                };

                pagina.Controls.Add(btn);

                i++;
                actual = actual.siguiente;
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            //crea botones dinamicos con los productos de la lista

                                                         
           
            lista.AgregarProducto(new Producto("", 1, 1.00, null, "Comidas",Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__1_,"Deliciosas galleta de chispa de chocolate "));
            lista.AgregarProducto(new Producto("Pastel de Fruta", 1, 1.50, null, "Comidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__3_, "Deliciosa combinación de frutas de temporada sobre una base crujiente"));
            lista.AgregarProducto(new Producto("Croissant", 1, 1.75, null, "Comidas",Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__4_, "Bollería francesa hojaldrada, dorada y con sabor a mantequilla pura"));
            lista.AgregarProducto(new Producto("CupCake", 1, 1.75, null, "Comidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__5_, "Pequeño bizcocho esponjoso con cobertura de crema suave"));
            lista.AgregarProducto(new Producto("Sandwich", 1, 1.25, null, "Comidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__6_, "Sandwich clásico con ingredientes frescos del día"));
            lista.AgregarProducto(new Producto("Pancake", 1, 2.00, null, "Comidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__7_, "Torres de panqueques esponjosos servidos con jarabe de miel"));
            lista.AgregarProducto(new Producto("Dona Glaseada", 1, 1.25, null, "Comidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__10_, "Dona suave con una capa fina de glaseado dulce"));
            lista.AgregarProducto(new Producto("random", 1, 1.50, null, "Comidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__9_,"Delicioso gelado de frutas tradicional para tus antojos"));
            lista.AgregarProducto(new Producto("random2", 1, 1.50, null, "Comidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__8_,"Delicioso pan recien horneado"));
            CrearBotonProducto(lista, tabProductos.TabPages[0],"Comidas");
            lista.AgregarProducto(new Producto("Cafe Espresso", 1, 1.25, null, "Bebidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__29_, "Deliciosa combinación de frutas de temporada sobre una base crujiente"));
            lista.AgregarProducto(new Producto("Capuchino", 1, 2.25, null, "Bebidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__28_, "Equilibrio perfecto entre espresso, leche vaporizada y espuma densa"));
            lista.AgregarProducto(new Producto("Latte Caliente", 1, 2.25, null, "Bebidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__27_, "Café suave con una generosa cantidad de leche cremosa al vapor"));
            lista.AgregarProducto(new Producto("Cafe Americano", 1, 1.75, null, "Bebidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__25_, "Espresso diluido en agua caliente para un sabor más ligero"));
            lista.AgregarProducto(new Producto("Chocolate Caliente", 1, 1.25, null, "Bebidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__30_, "Bebida reconfortante de cacao fundido con leche espumosa"));
            lista.AgregarProducto(new Producto("Té Caliente", 1, 1.25, null, "Bebidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__31_, "Selección de hierbas e infusiones naturales servidas bien calientes"));
            lista.AgregarProducto(new Producto("Frappuccino", 1, 2.75, null, "Bebidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__23_, "Café helado batido con hielo y decorado con crema batida"));
            lista.AgregarProducto(new Producto("Iced Latte", 1, 1.75, null, "Bebidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__21_, "La versión fría de nuestro latte clásico sobre cubos de hielo"));
            lista.AgregarProducto(new Producto("Cold Brew", 1, 1.75, null, "Bebidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__22_, "Café de extracción lenta en frío para resaltar notas dulces y menos ácidas"));
            lista.AgregarProducto(new Producto("Té Helado", 1, 1.50, null, "Bebidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__20_, "Té refrescante servido frío con un toque cítrico de limón"));
            lista.AgregarProducto(new Producto("Ice Coffee", 1, 1.75, null, "Bebidas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__24_, "Café filtrado tradicional servido con hielo"));
            CrearBotonProducto(lista, tabProductos.TabPages[1],"Bebidas");
            lista.AgregarProducto(new Producto("Pastelito de Carne", 1, 0.50, null, "Antojitos", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__37_, "Masa frita rellena de carne guisada con especias tradicionales"));
            lista.AgregarProducto(new Producto("Pupusas de Frijol con Queso", 1, 0.75, null, "Antojitos", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__36_, "Tortilla de maíz rellena de frijoles refritos y queso fundido"));
            lista.AgregarProducto(new Producto("Nuegados de Yuca", 1, 0.50, null, "Antojitos", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__35_, "Bolitas de masa de yuca bañadas en miel de panela"));
            lista.AgregarProducto(new Producto("Tamales de Pollo", 1, 0.50, null, "Antojitos", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__34_, "Masa de maíz suave rellena de pollo, envuelta en hoja de plátano"));
            lista.AgregarProducto(new Producto("Empanadas de Frijol", 1, 0.50, null, "Antojitos", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__33_, "Masa de plátano maduro rellena de frijoles y leche"));
            lista.AgregarProducto(new Producto("Yuca Frita", 1, 0.50, null, "Antojitos", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__32_, "Trozos de yuca crujiente por fuera y suave por dentro"));
            lista.AgregarProducto(new Producto("Elote Loco", 1, 1.50, null, "Antojitos", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__40_, "elote loco con mayonesa, mostaza, salsa ketchup y queso rallado"));
            lista.AgregarProducto(new Producto("Tamales de Elote", 1, 0.50, null, "Antojitos", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__39_, "Masa dulce de maíz tierno cocida al vapor"));
            lista.AgregarProducto(new Producto("Papas Fritas", 1, 1.50, null, "Antojitos", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__38_, "Porción de papas clásicas cortadas y fritas al punto de sal"));
            CrearBotonProducto(lista, tabProductos.TabPages[2],"Antojitos");
            lista.AgregarProducto(new Producto("Leche Deslactosada", 1, 1.50, null, "Mas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__48_, "Opción de leche ligera para personas con intolerancia a la lactosa"));
            lista.AgregarProducto(new Producto("Extra Crema Batida", 1, 1.00, null, "Mas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__46_, "Porción adicional de crema chantilly para tus bebidas"));
            lista.AgregarProducto(new Producto("Galletas Oreo", 1, 0.50, null, "Mas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__44_, "Famosas galletas de chocolate rellenas de crema de vainilla"));
            lista.AgregarProducto(new Producto("Cafe en Grano", 1, 2.50, null, "Mas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__42_, "Bolsa de granos tostados para disfrutar de un aroma fresco en casa"));
            lista.AgregarProducto(new Producto("Leche de Almendra", 1, 1.50, null, "Mas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__41_, "Alternativa vegetal cremosa y con un toque a frutos secos"));
            lista.AgregarProducto(new Producto("Papas Pringles", 1, 1.00, null, "Mas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__47_, "Snack de papas crujientes en su presentación clásica de tubo"));
            lista.AgregarProducto(new Producto("Nutella", 1, 1.00, null, "Mas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__49_, "Crema untable de cacao y avellanas para acompañar tus postres"));
            lista.AgregarProducto(new Producto("Ensalada", 1, 2.00, null, "Mas", Properties.Resources.Documento_A4_Catálogo_Supermercado_Moderno_Blanco__50_, "descripcion"));
            CrearBotonProducto(lista, tabProductos.TabPages[3],"Mas");

            tabProductos.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabProductos.DrawItem += tabProductos_DrawItem;


            //  REDONDEAR CONTROLES REALES

            RedondearControl(btnConfirmar, 20);
            RedondearControl(btnCarrito, 20);
            RedondearControl(btnNombre, 20); // 👈 NUEVO

            //  COLORES BONITOS
            btnConfirmar.BackColor = Color.FromArgb(255, 240, 220);
            btnConfirmar.ForeColor = Color.SaddleBrown;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.FlatAppearance.BorderSize = 0;

            btnCarrito.BackColor = Color.FromArgb(255, 240, 220);
            btnCarrito.FlatStyle = FlatStyle.Flat;
            btnCarrito.FlatAppearance.BorderSize = 0;

            //  ESTILO PARA btnNombre
            btnNombre.BackColor = Color.FromArgb(255, 240, 220);
            btnNombre.ForeColor = Color.SaddleBrown;
            btnNombre.FlatStyle = FlatStyle.Flat;
            btnNombre.FlatAppearance.BorderSize = 0;

            //  INPUTS LIMPIOS

            






        }
        // Método para configurar el estilo del los formularios
        private void estiloForm(Form frm)
        {
            frm.BackColor = Color.FromArgb(255, 255, 255);
            frm.ForeColor = Color.FromArgb(0, 0, 0);
            frm.Font = new Font("Unispace", 8, FontStyle.Regular);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowInTaskbar = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;

            
        }
        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            // Validar que se haya ingresado un nombre de cliente, que haya productos en la lista temporal y
            // que se haya agregado al menos un producto antes de confirmar el pedido
            if (string.IsNullOrEmpty(lblNombre.Text))
            {
                MessageBox.Show("Ingrese un Nombre", "AVISO");
                return;

            }
            if (ClaseGlobal.listaTemporal == null)
            {
                MessageBox.Show("No hay Productos en el Pedido", "AVISO");
                return;
            }
            if (ClaseGlobal.listaTemporal.Primero == null)
            {
                MessageBox.Show("Agregue al menos un producto", "AVISO");
                return;
            }
            // Si todas las validaciones pasan, se crea un nuevo pedido con el nombre del cliente
            // y la lista de productos seleccionados,
            // luego se encola el pedido en la cola de pedidos y se muestra un mensaje de éxito
            // Finalmente, se limpia la lista temporal
            // y el campo de nombre para preparar el formulario para un nuevo pedido
            string nombreCliente = lblNombre.Text;
            Pedido pedido = new Pedido(ClaseGlobal.listaTemporal, nombreCliente);
            ClaseGlobal.colaPedidos.Encolar(pedido);
            MessageBox.Show("Pedido en la cola", "EXITO");
            ClaseGlobal.listaTemporal = new ListaProductos();
            lblNombre.Text = "";

        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el botón para ingresar el nombre del cliente
            // se abre el formulario de cliente

            frmCliente frm = new frmCliente();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                lblNombre.Text = frm.NombreCliente;
            }

        }

        private void FrmPedirOrden_Shown(object sender, EventArgs e)
        {
            // Al mostrar el formulario, se enfoca el campo de texto
            // para que el usuario pueda ingresar el nombre del cliente de inmediato
            lblNombre.Focus();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            if (tabProductos.SelectedTab == tabPage1)
            {
                tabPage1.Controls.Clear();

                FrmPedirOrden frm = new FrmPedirOrden();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;

                tabPage1.Controls.Add(frm);
                frm.Show();
                frm.BringToFront();
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            frmCarrito carrito = new frmCarrito();
            carrito.ShowDialog();
            estiloForm(carrito);
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            //si el carrito esta vacio muestra mensaje de error
            if (ClaseGlobal.listaTemporal.Primero==null)
            {
                MessageBox.Show("Agregue al menos un producto");
                return;
            }
            frmCarrito carrito = new frmCarrito();
            estiloForm(carrito);
            carrito.ShowDialog();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void tabProductos_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tab = sender as TabControl;
            Graphics g = e.Graphics;
            TabPage pagina = tab.TabPages[e.Index];
            Rectangle area = tab.GetTabRect(e.Index);

            bool seleccionado = (e.Index == tab.SelectedIndex);

            Color fondo = seleccionado ? Color.FromArgb(95, 45, 15) : Color.White;
            Color texto = seleccionado ? Color.White : Color.SaddleBrown;

            using (SolidBrush brush = new SolidBrush(fondo))
            {
                g.FillRectangle(brush, area);
            }

            TextRenderer.DrawText(g, pagina.Text, tab.Font, area, texto,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
