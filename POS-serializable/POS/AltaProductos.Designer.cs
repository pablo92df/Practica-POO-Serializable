namespace POS
{
    partial class AltaProductos
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
			this.label2 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.lisMarca = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lisCategoria = new System.Windows.Forms.ComboBox();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.lblModelo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(67, 59);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Precio:";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(91, 224);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(100, 28);
			this.btnGuardar.TabIndex = 6;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(268, 223);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(100, 28);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(143, 59);
			this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(132, 22);
			this.txtPrecio.TabIndex = 2;
			// 
			// lisMarca
			// 
			this.lisMarca.FormattingEnabled = true;
			this.lisMarca.Location = new System.Drawing.Point(143, 91);
			this.lisMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lisMarca.Name = "lisMarca";
			this.lisMarca.Size = new System.Drawing.Size(132, 24);
			this.lisMarca.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(67, 91);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Marca:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(47, 123);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Categoria:";
			// 
			// lisCategoria
			// 
			this.lisCategoria.FormattingEnabled = true;
			this.lisCategoria.Location = new System.Drawing.Point(143, 123);
			this.lisCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lisCategoria.Name = "lisCategoria";
			this.lisCategoria.Size = new System.Drawing.Size(132, 24);
			this.lisCategoria.TabIndex = 4;
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(143, 156);
			this.txtStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(75, 22);
			this.txtStock.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(67, 156);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 17);
			this.label5.TabIndex = 11;
			this.label5.Text = "Stock:";
			// 
			// txtModelo
			// 
			this.txtModelo.Location = new System.Drawing.Point(143, 27);
			this.txtModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(195, 22);
			this.txtModelo.TabIndex = 1;
			// 
			// lblModelo
			// 
			this.lblModelo.AutoSize = true;
			this.lblModelo.Location = new System.Drawing.Point(67, 27);
			this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(58, 17);
			this.lblModelo.TabIndex = 13;
			this.lblModelo.Text = "Modelo:";
			// 
			// AltaProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 276);
			this.Controls.Add(this.txtModelo);
			this.Controls.Add(this.lblModelo);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lisCategoria);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lisMarca);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label2);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "AltaProductos";
			this.Text = "Alta de Productos";
			this.Load += new System.EventHandler(this.AltaProductos_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox lisMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lisCategoria;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
    }
}