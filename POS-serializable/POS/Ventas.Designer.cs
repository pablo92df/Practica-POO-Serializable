namespace POS
{
    partial class Ventas
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtIva = new System.Windows.Forms.TextBox();
			this.txtNeto = new System.Windows.Forms.TextBox();
			this.btnConfirmar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnBuscarCliente = new System.Windows.Forms.Button();
			this.btnProducto = new System.Windows.Forms.Button();
			this.dataGridViewPro = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPro)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(757, 330);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Total Neto:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(769, 362);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "Total IVA:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(804, 399);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Total:";
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(876, 394);
			this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(132, 22);
			this.txtTotal.TabIndex = 13;
			// 
			// txtIva
			// 
			this.txtIva.Location = new System.Drawing.Point(876, 357);
			this.txtIva.Margin = new System.Windows.Forms.Padding(4);
			this.txtIva.Name = "txtIva";
			this.txtIva.ReadOnly = true;
			this.txtIva.Size = new System.Drawing.Size(132, 22);
			this.txtIva.TabIndex = 14;
			// 
			// txtNeto
			// 
			this.txtNeto.Location = new System.Drawing.Point(876, 325);
			this.txtNeto.Margin = new System.Windows.Forms.Padding(4);
			this.txtNeto.Name = "txtNeto";
			this.txtNeto.ReadOnly = true;
			this.txtNeto.Size = new System.Drawing.Size(132, 22);
			this.txtNeto.TabIndex = 15;
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.Location = new System.Drawing.Point(395, 394);
			this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(89, 38);
			this.btnConfirmar.TabIndex = 16;
			this.btnConfirmar.Text = "Confirmar";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(549, 394);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(89, 38);
			this.btnCancelar.TabIndex = 17;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// btnBuscarCliente
			// 
			this.btnBuscarCliente.Location = new System.Drawing.Point(13, 14);
			this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
			this.btnBuscarCliente.Name = "btnBuscarCliente";
			this.btnBuscarCliente.Size = new System.Drawing.Size(89, 45);
			this.btnBuscarCliente.TabIndex = 5;
			this.btnBuscarCliente.Text = "Buscar Cliente";
			this.btnBuscarCliente.UseVisualStyleBackColor = true;
			this.btnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
			// 
			// btnProducto
			// 
			this.btnProducto.Location = new System.Drawing.Point(121, 14);
			this.btnProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnProducto.Name = "btnProducto";
			this.btnProducto.Size = new System.Drawing.Size(91, 45);
			this.btnProducto.TabIndex = 19;
			this.btnProducto.Text = "Agregar Producto";
			this.btnProducto.UseVisualStyleBackColor = true;
			this.btnProducto.Click += new System.EventHandler(this.BtnProducto_Click_1);
			// 
			// dataGridViewPro
			// 
			this.dataGridViewPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPro.Location = new System.Drawing.Point(252, 14);
			this.dataGridViewPro.Name = "dataGridViewPro";
			this.dataGridViewPro.RowTemplate.Height = 24;
			this.dataGridViewPro.Size = new System.Drawing.Size(756, 282);
			this.dataGridViewPro.TabIndex = 20;
			this.dataGridViewPro.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPro_CellValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(26, 178);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 17);
			this.label5.TabIndex = 21;
			this.label5.Text = "Apellido";
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(102, 178);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.ReadOnly = true;
			this.txtApellido.Size = new System.Drawing.Size(131, 22);
			this.txtApellido.TabIndex = 22;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(102, 224);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.ReadOnly = true;
			this.txtNombre.Size = new System.Drawing.Size(131, 22);
			this.txtNombre.TabIndex = 23;
			// 
			// txtDNI
			// 
			this.txtDNI.Location = new System.Drawing.Point(102, 263);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(131, 22);
			this.txtDNI.TabIndex = 24;
			this.txtDNI.TextChanged += new System.EventHandler(this.TxtDNI_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(27, 224);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 17);
			this.label6.TabIndex = 25;
			this.label6.Text = "Nombre";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(30, 267);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 17);
			this.label7.TabIndex = 26;
			this.label7.Text = "DNI";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(10, 135);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(79, 25);
			this.label8.TabIndex = 27;
			this.label8.Text = "Cliente:";
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(121, 139);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(93, 23);
			this.btnActualizar.TabIndex = 28;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
			// 
			// btnBorrar
			// 
			this.btnBorrar.Location = new System.Drawing.Point(123, 63);
			this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(91, 45);
			this.btnBorrar.TabIndex = 19;
			this.btnBorrar.Text = "Quitar Producto";
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
			// 
			// Ventas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1029, 478);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtDNI);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dataGridViewPro);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnProducto);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnConfirmar);
			this.Controls.Add(this.txtNeto);
			this.Controls.Add(this.txtIva);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBuscarCliente);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Ventas";
			this.Text = "Ventas";
			this.Activated += new System.EventHandler(this.Ventas_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ventas_FormClosed);
			this.Load += new System.EventHandler(this.Ventas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPro)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnBuscarCliente;
		private System.Windows.Forms.Button btnProducto;
		private System.Windows.Forms.DataGridView dataGridViewPro;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtDNI;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnBorrar;
	}
}