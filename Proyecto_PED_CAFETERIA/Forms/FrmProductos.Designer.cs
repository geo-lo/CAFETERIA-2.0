namespace Proyecto_PED_CAFETERIA.Forms
{
    partial class FrmPedirOrden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNombre = new System.Windows.Forms.Button();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabProductos = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.White;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.Sienna;
            this.btnConfirmar.Location = new System.Drawing.Point(190, 479);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(153, 35);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar Orden";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pedido para:";
            // 
            // btnNombre
            // 
            this.btnNombre.BackColor = System.Drawing.Color.White;
            this.btnNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNombre.ForeColor = System.Drawing.Color.Sienna;
            this.btnNombre.Location = new System.Drawing.Point(20, 479);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(153, 35);
            this.btnNombre.TabIndex = 7;
            this.btnNombre.Text = "Agregar Nombre";
            this.btnNombre.UseVisualStyleBackColor = false;
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // btnCarrito
            // 
            this.btnCarrito.BackColor = System.Drawing.Color.White;
            this.btnCarrito.BackgroundImage = global::Proyecto_PED_CAFETERIA.Properties.Resources.Diseño_sin_título__1_;
            this.btnCarrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCarrito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrito.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnCarrito.Location = new System.Drawing.Point(562, 432);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(78, 66);
            this.btnCarrito.TabIndex = 10;
            this.btnCarrito.UseVisualStyleBackColor = false;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Sienna;
            this.lblNombre.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(102, 432);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 14);
            this.lblNombre.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(704, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bebidas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(704, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Comidas";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // tabProductos
            // 
            this.tabProductos.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabProductos.Controls.Add(this.tabPage1);
            this.tabProductos.Controls.Add(this.tabPage2);
            this.tabProductos.Controls.Add(this.tabPage3);
            this.tabProductos.Controls.Add(this.tabPage4);
            this.tabProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabProductos.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabProductos.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.tabProductos.ItemSize = new System.Drawing.Size(120, 40);
            this.tabProductos.Location = new System.Drawing.Point(0, 0);
            this.tabProductos.Multiline = true;
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.SelectedIndex = 0;
            this.tabProductos.Size = new System.Drawing.Size(712, 391);
            this.tabProductos.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabProductos.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(704, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Antojitos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(704, 343);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // FrmPedirOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::Proyecto_PED_CAFETERIA.Properties.Resources.Presentación_Historia_del_Café_Ilustrado_Café_y_Beige4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 527);
            this.Controls.Add(this.tabProductos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnNombre);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPedirOrden";
            this.Text = "FrmIniciarOrden";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.Shown += new System.EventHandler(this.FrmPedirOrden_Shown);
            this.tabProductos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNombre;
        private System.Windows.Forms.Button btnCarrito;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabProductos;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}