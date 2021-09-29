namespace POS
{
	partial class Buscar_Clientes
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
			this.listViewClientes = new System.Windows.Forms.ListView();
			this.colApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colLocalidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDireccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnConfirmar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listViewClientes
			// 
			this.listViewClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colApellido,
            this.colNombre,
            this.colDNI,
            this.colLocalidad,
            this.colDireccion,
            this.colMail,
            this.colTel});
			this.listViewClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listViewClientes.Location = new System.Drawing.Point(33, 141);
			this.listViewClientes.Name = "listViewClientes";
			this.listViewClientes.Size = new System.Drawing.Size(709, 275);
			this.listViewClientes.TabIndex = 0;
			this.listViewClientes.UseCompatibleStateImageBehavior = false;
			this.listViewClientes.View = System.Windows.Forms.View.Details;
			// 
			// colApellido
			// 
			this.colApellido.Text = "Apellido";
			this.colApellido.Width = 108;
			// 
			// colNombre
			// 
			this.colNombre.Text = "Nombre";
			this.colNombre.Width = 86;
			// 
			// colDNI
			// 
			this.colDNI.Text = "DNI";
			this.colDNI.Width = 104;
			// 
			// colLocalidad
			// 
			this.colLocalidad.Text = "Localidad";
			this.colLocalidad.Width = 84;
			// 
			// colDireccion
			// 
			this.colDireccion.Text = "Direccion";
			this.colDireccion.Width = 111;
			// 
			// colMail
			// 
			this.colMail.Text = "Mail";
			this.colMail.Width = 106;
			// 
			// colTel
			// 
			this.colTel.Text = "Teléfono";
			this.colTel.Width = 121;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.Location = new System.Drawing.Point(324, 60);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(84, 40);
			this.btnBuscar.TabIndex = 1;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
			// 
			// txtDNI
			// 
			this.txtDNI.Location = new System.Drawing.Point(85, 60);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(176, 24);
			this.txtDNI.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "DNI:";
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfirmar.Location = new System.Drawing.Point(480, 59);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(101, 41);
			this.btnConfirmar.TabIndex = 4;
			this.btnConfirmar.Text = "Confirmar";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
			// 
			// Buscar_Clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(754, 450);
			this.Controls.Add(this.btnConfirmar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtDNI);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.listViewClientes);
			this.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Buscar_Clientes";
			this.Text = "Buscar_Clientes";
			this.Load += new System.EventHandler(this.Buscar_Clientes_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listViewClientes;
		private System.Windows.Forms.ColumnHeader colApellido;
		private System.Windows.Forms.ColumnHeader colNombre;
		private System.Windows.Forms.ColumnHeader colDNI;
		private System.Windows.Forms.ColumnHeader colLocalidad;
		private System.Windows.Forms.ColumnHeader colDireccion;
		private System.Windows.Forms.ColumnHeader colMail;
		private System.Windows.Forms.ColumnHeader colTel;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtDNI;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnConfirmar;
	}
}