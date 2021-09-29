namespace POS
{
    partial class Caja
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
			this.btnConsultar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.gridFacturas = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 48);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Fecha Desde:";
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(622, 49);
			this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(92, 47);
			this.btnConsultar.TabIndex = 3;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click_1);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(51, 79);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Fecha Hasta:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(157, 48);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(125, 22);
			this.dateTimePicker1.TabIndex = 8;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(157, 79);
			this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(125, 22);
			this.dateTimePicker2.TabIndex = 9;
			// 
			// gridFacturas
			// 
			this.gridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridFacturas.Location = new System.Drawing.Point(53, 144);
			this.gridFacturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gridFacturas.Name = "gridFacturas";
			this.gridFacturas.RowHeadersWidth = 51;
			this.gridFacturas.RowTemplate.Height = 24;
			this.gridFacturas.Size = new System.Drawing.Size(661, 292);
			this.gridFacturas.TabIndex = 10;
			this.gridFacturas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridFacturas_CellDoubleClick);
			// 
			// Caja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(752, 462);
			this.Controls.Add(this.gridFacturas);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Caja";
			this.Text = "Facturacion";
			this.Load += new System.EventHandler(this.Caja_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DataGridView gridFacturas;
	}
}