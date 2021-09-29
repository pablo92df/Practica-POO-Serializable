using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Ventas : Form
    {
		private Sistema SistemaFacturas;
		private DataTable data;
		public Ventas()
        {
            InitializeComponent();
			SistemaFacturas = Program.getSistema();
		}
		private void Ventas_Load(object sender, EventArgs e)
		{
			data = new DataTable();
			data.Columns.Add("Codigo").ReadOnly=true;
			data.Columns.Add("Marca").ReadOnly = true;
			data.Columns.Add("Modelo").ReadOnly = true;
			data.Columns.Add("Cantidad");
			data.Columns.Add("Precio Unitario").ReadOnly = true;
			data.Columns.Add("Precio Total").ReadOnly = true;
			dataGridViewPro.DataSource = data;

		}
		private void BtnBuscarCliente_Click(object sender, EventArgs e)
		{
			Buscar_Clientes frmMenu = new Buscar_Clientes();
			frmMenu.Show();	
		}		

		private void BtnProducto_Click_1(object sender, EventArgs e)
		{
			Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Stock);
			if (frm != null)
			{
				frm.BringToFront();
			}
			else
			{
				Stock frmMenu = new Stock();
				frmMenu.Show();
			}
			
		}

		private void BtnConfirmar_Click(object sender, EventArgs e)
		{
			if (SistemaFacturas.getFacturaTemporal().getProductosEnFactura().Count == 0)
			{
				MessageBox.Show("Que carajo queres facturar, no hay nada pibe");
			}
			else
			{
				SistemaFacturas.setFacturaFinal();
				SistemaFacturas.getFacturaTemporal().VaciarProductos();
				SistemaFacturas.getFacturaTemporal().BorrarComprador();
				((DataTable)dataGridViewPro.DataSource).Rows.Clear();
				txtApellido.Clear();
				txtNombre.Clear();
				txtDNI.Clear();
				this.ImprimirMontoTotal();
			}
		}
		private void ImprimirProductos() {

			((DataTable)dataGridViewPro.DataSource).Rows.Clear();
			dataGridViewPro.Refresh();
			foreach (Producto P in SistemaFacturas.getFacturaTemporal().getProductosEnFactura())
			{
				DataRow row = data.NewRow();
				row["Codigo"] = P.codigo;
				row["Marca"] = P.marc.nombre;
				row["Modelo"] = P.modelo;
				row["Cantidad"] = P.stock.ToString();
				row["Precio Unitario"] = P.precio.ToString();
				row["Precio Total"] = (P.stock*P.precio).ToString();
				data.Rows.Add(row);
				
			}
			
		}

		private void BtnCancelar_Click(object sender, EventArgs e)
		{
			this.QuitarProductosView();

		}

		private void TxtDNI_TextChanged(object sender, EventArgs e)
		{
			//SistemaFacturas.CargarComprador(txtDNI.Text);
		}

		private void BtnActualizar_Click(object sender, EventArgs e)
		{
		}

		private void BtnBorrar_Click(object sender, EventArgs e)
		{
			if (SistemaFacturas.getFacturaTemporal().getProductosEnFactura().Count > 0) {
				string codigo = dataGridViewPro.CurrentRow.Cells["Codigo"].Value.ToString();
				string cantidad = dataGridViewPro.CurrentRow.Cells["Cantidad"].Value.ToString();
				string precio = dataGridViewPro.CurrentRow.Cells["Precio Unitario"].Value.ToString();
				this.EliminarProducto(cantidad, precio, codigo);
			}
			else
				MessageBox.Show("No hay productos cargados que borrar");
		}

		private void Ventas_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.QuitarProductosView();
			SistemaFacturas.getFacturaTemporal().BorrarComprador();


		}

		private void DataGridViewPro_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			string cantidad = dataGridViewPro.CurrentRow.Cells["Cantidad"].Value.ToString();
			string precio = dataGridViewPro.CurrentRow.Cells["Precio Unitario"].Value.ToString();

			string codigo = dataGridViewPro.CurrentRow.Cells["Codigo"].Value.ToString();
			if (Int32.Parse(cantidad) > 0) {
				if (SistemaFacturas.LlamarRestarStock(Int32.Parse(codigo), Int32.Parse(cantidad)))
				{
					this.ImprimirMontoTotal();
					this.ImprimirProductos();
				}
				else
					MessageBox.Show("El producto no cuenta con stock suficiente");
			}
			else
				MessageBox.Show("No puede haber cantidades negativas");

		}

		private void Ventas_Activated(object sender, EventArgs e)
		{
		
			this.ImprimirProductos();
			this.imprimirCliente();
			this.ImprimirMontoTotal();

		}
		private void ImprimirMontoTotal() {
			txtTotal.Clear();
			txtNeto.Clear();
			txtIva.Clear();
			txtTotal.Text = SistemaFacturas.getFacturaTemporal().getMontoTotal().ToString();
			txtNeto.Text = SistemaFacturas.getFacturaTemporal().getNeto().ToString();
			txtIva.Text = SistemaFacturas.getFacturaTemporal().getIva().ToString();
		}
		private void QuitarProductosView() {
			SistemaFacturas.MandarAStock();
			SistemaFacturas.getFacturaTemporal().VaciarProductos();
			((DataTable)dataGridViewPro.DataSource).Rows.Clear();
			dataGridViewPro.Refresh();
			this.imprimirCliente();
			this.ImprimirMontoTotal();
		}
		private void imprimirCliente() {
			try
			{
				txtApellido.Text = SistemaFacturas.getFacturaTemporal().getCliente().apellido;
				txtNombre.Text = SistemaFacturas.getFacturaTemporal().getCliente().nombre;
				txtDNI.Text = SistemaFacturas.getFacturaTemporal().getCliente().dni;
			}
			catch (System.NullReferenceException)
			{
				txtApellido.Text = "";
				txtNombre.Text = "";
				txtDNI.Text = "";
			}
		}
		private void EliminarProducto(string cantidad, string precio, string codigo) {
			
			SistemaFacturas.MandarAStock(Int32.Parse(codigo), Int32.Parse(cantidad));
			SistemaFacturas.getFacturaTemporal().BorrarProducto(codigo);
			SistemaFacturas.getFacturaTemporal().RestarProductoEliminado(Decimal.Parse(precio), Int32.Parse(cantidad));
			this.ImprimirMontoTotal();
			this.ImprimirProductos();
		}
	}
}
