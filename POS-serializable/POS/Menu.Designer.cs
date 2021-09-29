namespace POS
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();			
			this.btnAltaProductos = new System.Windows.Forms.Button();
			this.btnCaja = new System.Windows.Forms.Button();
			this.btnClientes = new System.Windows.Forms.Button();
			this.btnStock = new System.Windows.Forms.Button();
			this.btnVentas = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(45, 36);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 24);
			this.label1.TabIndex = 7;
			this.label1.Text = "Facturacion";
		
			// 
			// btnAltaProductos
			// 
			this.btnAltaProductos.Image = global::POS.Properties.Resources.ingreso_64px;
			this.btnAltaProductos.Location = new System.Drawing.Point(364, 218);
			this.btnAltaProductos.Margin = new System.Windows.Forms.Padding(4);
			this.btnAltaProductos.Name = "btnAltaProductos";
			this.btnAltaProductos.Size = new System.Drawing.Size(147, 124);
			this.btnAltaProductos.TabIndex = 9;
			this.btnAltaProductos.Text = "Alta Productos";
			this.btnAltaProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAltaProductos.UseVisualStyleBackColor = true;
			this.btnAltaProductos.Click += new System.EventHandler(this.BtnAltaProductos_Click);
			// 
			// btnCaja
			// 
			this.btnCaja.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCaja.Image = global::POS.Properties.Resources.caja_64px;
			this.btnCaja.Location = new System.Drawing.Point(251, 63);
			this.btnCaja.Margin = new System.Windows.Forms.Padding(4);
			this.btnCaja.Name = "btnCaja";
			this.btnCaja.Size = new System.Drawing.Size(147, 124);
			this.btnCaja.TabIndex = 4;
			this.btnCaja.Text = "Caja";
			this.btnCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCaja.UseVisualStyleBackColor = true;
			this.btnCaja.Click += new System.EventHandler(this.BtnCaja_Click);
			// 
			// btnClientes
			// 
			this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClientes.Image = global::POS.Properties.Resources.cliente_64px;
			this.btnClientes.Location = new System.Drawing.Point(448, 63);
			this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
			this.btnClientes.Name = "btnClientes";
			this.btnClientes.Size = new System.Drawing.Size(147, 124);
			this.btnClientes.TabIndex = 2;
			this.btnClientes.Text = "Clientes";
			this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnClientes.UseVisualStyleBackColor = true;
			this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
			// 
			// btnStock
			// 
			this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnStock.Image = global::POS.Properties.Resources.stock_64px;
			this.btnStock.Location = new System.Drawing.Point(149, 218);
			this.btnStock.Margin = new System.Windows.Forms.Padding(4);
			this.btnStock.Name = "btnStock";
			this.btnStock.Size = new System.Drawing.Size(147, 124);
			this.btnStock.TabIndex = 1;
			this.btnStock.Text = "Stock";
			this.btnStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnStock.UseVisualStyleBackColor = true;
			this.btnStock.Click += new System.EventHandler(this.BtnStock_Click);
			// 
			// btnVentas
			// 
			this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVentas.Image = global::POS.Properties.Resources.venta_64px;
			this.btnVentas.Location = new System.Drawing.Point(51, 63);
			this.btnVentas.Margin = new System.Windows.Forms.Padding(4);
			this.btnVentas.Name = "btnVentas";
			this.btnVentas.Size = new System.Drawing.Size(147, 124);
			this.btnVentas.TabIndex = 0;
			this.btnVentas.Text = "Ventas";
			this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnVentas.UseVisualStyleBackColor = true;
			this.btnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(713, 389);
			this.Controls.Add(this.btnAltaProductos);
			
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCaja);
			this.Controls.Add(this.btnClientes);
			this.Controls.Add(this.btnStock);
			this.Controls.Add(this.btnVentas);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Menu";
			this.Text = "POS - Menu";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Label label1;
   
        private System.Windows.Forms.Button btnAltaProductos;
      
    }
}

