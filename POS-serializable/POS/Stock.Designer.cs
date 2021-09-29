namespace POS
{
    partial class Stock
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
			this.lisMarcas = new System.Windows.Forms.ComboBox();
			this.lblMarca = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lisCategorias = new System.Windows.Forms.ComboBox();
			this.btnFacturar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(423, 273);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 17);
			this.label1.TabIndex = 4;
			// 
			// lisMarcas
			// 
			this.lisMarcas.FormattingEnabled = true;
			this.lisMarcas.Location = new System.Drawing.Point(121, 26);
			this.lisMarcas.Margin = new System.Windows.Forms.Padding(4);
			this.lisMarcas.Name = "lisMarcas";
			this.lisMarcas.Size = new System.Drawing.Size(160, 24);
			this.lisMarcas.TabIndex = 5;
			this.lisMarcas.SelectedIndexChanged += new System.EventHandler(this.LisMarcas_SelectedIndexChanged);
			// 
			// lblMarca
			// 
			this.lblMarca.AutoSize = true;
			this.lblMarca.Location = new System.Drawing.Point(59, 29);
			this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(51, 17);
			this.lblMarca.TabIndex = 6;
			this.lblMarca.Text = "Marca:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 70);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Categorias:";
			// 
			// lisCategorias
			// 
			this.lisCategorias.FormattingEnabled = true;
			this.lisCategorias.Items.AddRange(new object[] {
            "Elegir"});
			this.lisCategorias.Location = new System.Drawing.Point(121, 70);
			this.lisCategorias.Margin = new System.Windows.Forms.Padding(4);
			this.lisCategorias.Name = "lisCategorias";
			this.lisCategorias.Size = new System.Drawing.Size(160, 24);
			this.lisCategorias.TabIndex = 7;
			this.lisCategorias.SelectedIndexChanged += new System.EventHandler(this.LisCategorias_SelectedIndexChanged);
			// 
			// btnFacturar
			// 
			this.btnFacturar.Location = new System.Drawing.Point(743, 70);
			this.btnFacturar.Name = "btnFacturar";
			this.btnFacturar.Size = new System.Drawing.Size(100, 35);
			this.btnFacturar.TabIndex = 13;
			this.btnFacturar.Text = "Facturar";
			this.btnFacturar.UseVisualStyleBackColor = true;
			this.btnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowDrop = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 129);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(853, 319);
			this.dataGridView1.TabIndex = 18;
			// 
			// Stock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(877, 484);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnFacturar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lisCategorias);
			this.Controls.Add(this.lblMarca);
			this.Controls.Add(this.lisMarcas);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Stock";
			this.Text = "Stock";
			this.Activated += new System.EventHandler(this.Stock_Activated);
			this.Load += new System.EventHandler(this.Stock_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lisMarcas;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lisCategorias;
		private System.Windows.Forms.Button btnFacturar;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}