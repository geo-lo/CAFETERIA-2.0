using CAFETERIA.ClasesNuevas;
using Proyecto_PED_CAFETERIA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Proyecto_PED_CAFETERIA.Forms
{
    public partial class FrmPedirOrden : Form
    {
        string nombreProducto;
        double precio;

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

        // 🔹 MÉTODO PARA REDONDEAR
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

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            tablaC.DrawMode = TabDrawMode.OwnerDrawFixed;
            tablaC.DrawItem += tablaC_DrawItem;

            //  REDONDEAR CONTROLES REALES
          
            RedondearControl(nombreP, 15);
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
        
            nombreP.BorderStyle = BorderStyle.None;

            //llenamos el buscador de productos con los productos disponibles
            // Cada producto se agrega al buscador con su nombre, precio, imagen y descripción

           




        }
        //metodo para agregar productos al buscador
        private void AgregarProducto(string nombre,int cantidad, Double precio,Button button,string categoria,Image image)
        {
        }
        private void panel1_Scroll_1(object sender, ScrollEventArgs e)
        {
            //
        }

        private void btnPan_Click(object sender, EventArgs e)
        {


        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnPan_Click_1(object sender, EventArgs e)
        {
            // Al hacer clic en el botón "Pan", se abre el formulario
            // de cantidad para ese producto específico
            // Se pasan el nombre del producto, el precio,
            // la imagen y la descripción al formulario de cantidad

            frmCantidad frm = new frmCantidad("Pan", 1.50,
                btnPan.BackgroundImage, "Pan  recien horneado," +
                " \ncrujiente por fuera y suave por dentro");
            estiloForm(frm);
            frm.ShowDialog();

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

        private void btnJugo_Click(object sender, EventArgs e)
        {

           
        }

        private void btnPapas_Click(object sender, EventArgs e)
        {
          
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

        private void btnPastel_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Pastel", 1.50,
                btnPastel.BackgroundImage,
                "Pastel de Chocolate,\nhecho con ingredientes de alta calidad," +
                "\ncon una textura suave y un sabor intenso a chocolate," +
                "\nperfecto para los amantes del chocolate.");
            estiloForm(frm);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Dona Glaseada", 1.25,
                button1.BackgroundImage, "Dona Glaseada," +
                "\nhecha con masa suave y esponjosa," +
                "\ncubierta con un glaseado dulce y brillante," +
                "\nideal para disfrutar en cualquier momento del día como un delicioso snack o postre.");
            estiloForm(frm);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Galletas de Chocolate", 1.00,
                button2.BackgroundImage, "Galletas de Chocolate," +
                "\nhechas con ingredientes de alta calidad," +
                "\ncon una textura crujiente por fuera y suave por dentro," +
                "\ncon un sabor intenso a chocolate,\nperfectas para disfrutar como un delicioso snack o postre.");
            estiloForm(frm);
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //boton sandwich agregar sandwich al form cantidad y mostrar la descripcion del producto
                frmCantidad frm = new frmCantidad("Sandwich", 2.50,
                    button3.BackgroundImage, "Sandwich de Pollo,\nhecho con ingredientes frescos y de alta calidad," +
                    "\ncon una combinación perfecta de sabores y texturas," +
                    "\nideal para disfrutar como un delicioso almuerzo o cena.");
            estiloForm(frm);
            frm.ShowDialog();
        }

        private void FrmPedirOrden_Shown(object sender, EventArgs e)
        {
            // Al mostrar el formulario, se enfoca el campo de texto
            // para que el usuario pueda ingresar el nombre del cliente de inmediato
            nombreP.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            if (tablaC.SelectedTab == tabPage1)
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

        private void button13_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Café Espresso", 1.25,
    btnCafeespresso.BackgroundImage, "Café espresso intenso,\ncon sabor fuerte y aroma profundo," +
    "\nperfecto para empezar el día o recargar energía rápidamente.");
            estiloForm(frm);
            frm.ShowDialog();


        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmCarrito carrito = new frmCarrito();
            carrito.ShowDialog();
            estiloForm(carrito);
        }

        private void button4_Click(object sender, EventArgs e)
        {
          

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //bton para cupcakes agregar cupcakes al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Cupcakes", 1.75,
                button8.BackgroundImage, "Cupcakes de Vainilla,\nhechos con ingredientes de alta calidad," +
                "\ncon una textura suave y esponjosa,\ncon un sabor delicioso a vainilla," +
                "\nperfectos para disfrutar como un delicioso snack o postre.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
       

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //boton para helado agregar helado al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Helado", 1.50,
                button6.BackgroundImage, "Helado de Vainilla,\nhecho con ingredientes de alta calidad," +
                "\ncon una textura suave y cremosa,\ncon un sabor delicioso a vainilla," +
                "\nperfecto para disfrutar como un delicioso snack o postre.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
          

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //boton croasant agregar croasant al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Croissant", 1.75,
                button12.BackgroundImage, "Croissant de Mantequilla,\nhecho con ingredientes de alta calidad," +
                "\ncon una textura suave y hojaldrada,\ncon un sabor delicioso a mantequilla," +
                "\nperfecto para disfrutar en el desayuno o como un delicioso snack.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //boton para wafles agregar wafles al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Pancakes", 2.00,
                button11.BackgroundImage, "Pancakes esponjosos,\nhechos con ingredientes de alta calidad," +
                "\ncon una textura crujiente por fuera y suave por dentro,\nperfectos para disfrutar en el desayuno o como un delicioso postre.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Capuchino", 2.25,
    button19.BackgroundImage, "Capuchino cremoso,\ncon mezcla perfecta de café y leche espumada," +
    "\nligero, suave y con un toque delicioso para disfrutar.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //bton te agregar te al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Té Helado", 1.25,
                button15.BackgroundImage, "Té Verde,\nrefrescante y saludable,\ncon un sabor suave y delicado," +
                "\nperfecto para disfrutar en cualquier momento del día como una bebida relajante o como un acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Café Americano", 1.75,
    button20.BackgroundImage, "Café americano suave,\npreparado con espresso y agua caliente," +
    "\nde sabor ligero pero aromático,\nideal para disfrutar a cualquier hora del día.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            //bton fanta agregar fanta al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Iced Coffee", 1.75,
     button23.BackgroundImage, "Iced coffee refrescante,\npreparado con café y hielo," +
     "\nde sabor ligero y revitalizante,\nperfecto para disfrutar en cualquier momento.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //bton cafe caliente agregar cafe caliente al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Café Frappé", 2.75,
    button18.BackgroundImage, "Café frappé frío,\nmezclado con hielo y crema," +
    "\ndulce, refrescante y perfecto para días calurosos.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            //bton cafe frio agregar cafe frio al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Iced Latte", 2.25,
     button17.BackgroundImage, "Iced latte refrescante,\ncon espresso y leche fría sobre hielo," +
     "\nsuave, cremoso y perfecto para días calurosos.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button24_Click(object sender, EventArgs e)
        {
          

        }

        private void button27_Click(object sender, EventArgs e)
        {
          

        }

        private void button22_Click(object sender, EventArgs e)
        {
         

        }

        private void button21_Click(object sender, EventArgs e)
        {
       
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //bton yogur agregar yogur al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Cold Brew", 2.50,
    button28.BackgroundImage, "Cold brew suave,\npreparado en frío por varias horas," +
    "\nde sabor menos ácido y más intenso,\nperfecto para disfrutar bien frío.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button26_Click(object sender, EventArgs e)
        {
           

        }

        private void button25_Click(object sender, EventArgs e)
        {
            //bton leche agregar leche al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Té Frío", 1.50,
      button25.BackgroundImage, "Té frío refrescante,\nelaborado con hojas naturales," +
      "\nligero, delicioso y perfecto para calmar la sed en días calurosos.");
            estiloForm(frm);
            frm.ShowDialog();

        }
        //todos los productos por ingresar se iran a la categoria de "Mas"
        //porque son productos que no se venden con tanta frecuencia pero que
        //igual queremos tener disponibles para nuestros clientes
        private void button60_Click(object sender, EventArgs e)
        {
            //bton sushi
            frmCantidad frm = new frmCantidad("Leche Deslactosada", 1.50,
    button60.BackgroundImage, "Leche deslactosada suave,\nfácil de digerir y nutritiva," +
    "\nperfecta para quienes buscan una opción ligera y saludable.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button59_Click(object sender, EventArgs e)
        {
            //bton cereal
            frmCantidad frm = new frmCantidad("Extra Crema Batida", 1.50,
    button59.BackgroundImage, "Crema batida extra,\nsuave, dulce y esponjosa," +
    "\nperfecta para acompañar tus bebidas y postres.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button58_Click(object sender, EventArgs e)
        {
            //bton queso
            frmCantidad frm = new frmCantidad("Galleta Oreo", 0.50,
     button58.BackgroundImage, "Galleta Oreo crujiente,\ncon relleno cremoso de vainilla," +
     "\ndulce y perfecta para acompañar tu bebida.");
            estiloForm(frm);
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button57_Click(object sender, EventArgs e)
        {
            


        }

        private void button56_Click(object sender, EventArgs e)
        {
            //bton aceite agregar aceite al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Café Espresso", 2.50,
      button56.BackgroundImage, "Empaque para café espresso,\npráctico y seguro para llevar," +
      "\nideal para disfrutar tu bebida en cualquier lugar.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button55_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Leche de Almendras", 1.50,
     button55.BackgroundImage, "Leche de almendras suave,\nde sabor ligero y natural," +
     "\nideal como alternativa sin lactosa para tus bebidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button54_Click(object sender, EventArgs e)
        {
            //boton atun agregar atun al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Atún", 2.00,
                button54.BackgroundImage, "Atún enlatado,\nhecho con ingredientes de alta calidad," +
                "\nperfecto para cocinar diferentes tipos de comida o como un snack saludable.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button53_Click(object sender, EventArgs e)
        {
            //boton azucar agregar azucar al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Papas Pringles", 1.00,
     button53.BackgroundImage, "Papas Pringles crujientes,\ncon sabor intenso y uniforme," +
     "\nperfectas para disfrutar como snack en cualquier momento."); 
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button52_Click(object sender, EventArgs e)
        {
          

        }

        private void button51_Click(object sender, EventArgs e)
        {
          

        }

        private void button50_Click(object sender, EventArgs e)
        {
            

        }

        private void button49_Click(object sender, EventArgs e)
        {
            //boton nutella agregar nutella al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Nutella", 2.00,
                button49.BackgroundImage, "Nutella,\nhecha con ingredientes de alta calidad," +
                "\nperfecta para untar en pan o como un acompañante para tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button48_Click(object sender, EventArgs e)
        {
           

        }

        private void button47_Click(object sender, EventArgs e)
        {
            

        }

        private void button46_Click(object sender, EventArgs e)
        {
           

        }

        private void button45_Click(object sender, EventArgs e)
        {
            //boton sal agregar sal al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Ensalada", 2.00,
    button45.BackgroundImage, "Ensalada fresca,\npreparada con vegetales seleccionados," +
    "\nligera, saludable y perfecta para acompañar tus comidas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button44_Click(object sender, EventArgs e)
        {
            //boton pescado agregar pescado al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Pastelito de Carne", 0.50,
    button44.BackgroundImage, "Pastelito de carne crujiente,\nrelleno jugoso y bien sazonado," +
    "\nacompañado de curtido y salsa,\nperfecto para un antojito delicioso.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button43_Click(object sender, EventArgs e)
        {
         

        }

        private void button42_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Nuégados de Yuca", 0.50,
     button42.BackgroundImage, "Nuégados de yuca dulces,\nsuaves por dentro y dorados por fuera," +
     "\nbañados en miel deliciosa,\nperfectos para disfrutar como postre tradicional.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button41_Click(object sender, EventArgs e)
        {
         

        }

        private void button40_Click(object sender, EventArgs e)
        {
          

        }

        private void button39_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Tamal de Pollo", 0.50,
     button39.BackgroundImage, "Tamal de pollo tradicional,\nrelleno jugoso y bien sazonado," +
     "\nenvuelto en hoja y cocido al vapor,\nperfecto para un antojito delicioso.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button38_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Empanada de frijol y leche", 0.50,
     button38.BackgroundImage, "Empanada de plátano dulce,\nrellena de frijoles y leche," +
     "\nsuave, deliciosa y con un toque tradicional,\nperfecta para disfrutar en cualquier momento.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button37_Click(object sender, EventArgs e)
        {
           

        }

        private void button36_Click(object sender, EventArgs e)
        {
            //boton quesadilla agregar quesadilla al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Elote Loco", 1.50,
     button36.BackgroundImage, "Elote loco delicioso,\nbañado con mayonesa, queso y salsa," +
     "\ncon un toque crujiente y lleno de sabor,\nperfecto para disfrutar como antojito.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button35_Click(object sender, EventArgs e)
        {
            //boton yuca frita agregar al form cantidad
            frmCantidad frm = new frmCantidad("Yuca Frita", 1.25,
                button35.BackgroundImage, "Yuca frita dorada,\ncrujiente por fuera y suave por dentro," +
                "\nsabrosa y perfecta para acompañar con salsas.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button34_Click(object sender, EventArgs e)
        {
            //boton palomitas de maiz agregar palomitas de maiz al form cantidad y mostrar la descripcion del producto
            frmCantidad frm = new frmCantidad("Pupusas de Frijol con Queso", 0.50,
    button34.BackgroundImage, "Pupusas rellenas de frijol y queso,\ncalientitas y bien doradas," +
    "\ncon sabor tradicional salvadoreño,\nperfectas para disfrutar en cualquier momento.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button33_Click(object sender, EventArgs e)
        {
        

        }

        private void button32_Click(object sender, EventArgs e)
        {
         

        }

        private void button31_Click(object sender, EventArgs e)
        {
            //boton tamales agregar tamales al form cantidad y mostrar la descripcion del producto
                frmCantidad frm = new frmCantidad("Tamal de elote", 0.50,
                    button31.BackgroundImage, "Tamales,\nhechos con ingredientes frescos y de alta calidad," +
                    "\ncon una combinación perfecta de sabores y texturas,\nideal para disfrutar como un delicioso almuerzo o cena.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button30_Click(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Papas Fritas", 1.50,
    button30.BackgroundImage, "Papas fritas crujientes,\ndoradas al punto perfecto," +
    "\nsabrosas y ideales para acompañar cualquier comida.");
            estiloForm(frm);
            frm.ShowDialog();

        }

        private void button29_Click(object sender, EventArgs e)
        {
          

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

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

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Chocolate Caliente", 1.25,
       btnChocolate.BackgroundImage,
       "Chocolate caliente cremoso,\npreparado con cacao de alta calidad," +
       "\ncon un sabor dulce e intenso,\nperfecto para disfrutar en cualquier momento," +
       "\nideal para acompañar tus postres favoritos.");

            estiloForm(frm);
            frm.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmCantidad frm = new frmCantidad("Té Caliente", 1.25,
       btnTeCaliente.BackgroundImage,
       "Té caliente relajante,\npreparado con hojas naturales," +
       "\ncon un aroma suave y agradable,\nperfecto para calmar y disfrutar," +
       "\npuedes elegir entre varios sabores.");

            estiloForm(frm);
            frm.ShowDialog();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void tablaC_DrawItem(object sender, DrawItemEventArgs e)
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


    }
}
