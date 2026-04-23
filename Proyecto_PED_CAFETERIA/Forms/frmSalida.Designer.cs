namespace Proyecto_PED_CAFETERIA.Forms
{
    partial class frmSalida
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
            this.lblS = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.cup2 = new System.Windows.Forms.PictureBox();
            this.cpu1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(158, 43);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(0, 23);
            this.lblS.TabIndex = 0;
            this.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Green;
            this.btnSalir.Location = new System.Drawing.Point(219, 234);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 35);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SI";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNo
            // 
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.Red;
            this.btnNo.Location = new System.Drawing.Point(359, 234);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 35);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // cup2
            // 
            this.cup2.BackgroundImage = global::Proyecto_PED_CAFETERIA.Properties.Resources.Mugman;
            this.cup2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cup2.Location = new System.Drawing.Point(494, 127);
            this.cup2.Name = "cup2";
            this.cup2.Size = new System.Drawing.Size(126, 155);
            this.cup2.TabIndex = 4;
            this.cup2.TabStop = false;
            // 
            // cpu1
            // 
            this.cpu1.BackgroundImage = global::Proyecto_PED_CAFETERIA.Properties.Resources.Cuphead;
            this.cpu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cpu1.Location = new System.Drawing.Point(32, 127);
            this.cpu1.Name = "cpu1";
            this.cpu1.Size = new System.Drawing.Size(126, 155);
            this.cpu1.TabIndex = 3;
            this.cpu1.TabStop = false;
            // 
            // frmSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 317);
            this.Controls.Add(this.cup2);
            this.Controls.Add(this.cpu1);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalida";
            this.Load += new System.EventHandler(this.frmSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.PictureBox cpu1;
        private System.Windows.Forms.PictureBox cup2;
    }
}