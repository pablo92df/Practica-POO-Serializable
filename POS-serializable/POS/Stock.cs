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

	public partial class Stock : Form
	{
		private Sistema SistemaProductos;
		private DataTable data; 
		public Stock()
		{
			InitializeComponent();
			SistemaProductos = Program.getSistema();
		}
		

		private void BtnConsultar_Click(object sender, EventArgs e)
		{
			this.CargarTodosProductos();
		}
		private void Stock_Load(object sender, EventArgs e)
		{
			data = new DataTable();
			data.Columns.Add("Codigo").ReadOnly = true;
			data.Columns.Add("Marca").ReadOnly = true;
			data.Columns.Add("Categoria").ReadOnly = true;
			data.Columns.Add("Modelo").ReadOnly = true;
			data.Columns.Add("Precio").ReadOnly = true;
			data.Columns.Add("Stock").ReadOnly = true;
			dataGridView1.DataSource = data;
			
			foreach (Producto P in SistemaProductos.getProductoRepository().getProductos())
			{
				this.CargarProductos(P);
			}
		}

		private void BtnFacturar_Click(object sender, EventArgs e)
		{
			
			string stock = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
			if (Int32.Parse(stock) > 0)
			{
				string codigo = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
				string marca = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
				string categoria = dataGridView1.CurrentRow.Cells["Categoria"].Value.ToString();
				SistemaProductos.setProductosFactura(codigo, marca,categoria);
				Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Ventas);
				if (frm != null)
				{
					frm.BringToFront();
				}
				else {
					Ventas frmVentas = new Ventas();
					frmVentas.Show();
				}
				this.CargarTodosProductos();

			}
			else
				MessageBox.Show("No hay stock, no ves?");
		}

		private void LisMarcas_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lisMarcas.SelectedIndex == 0)
			{
				
			}
			else
			{
				int indice = 0;
				foreach (Producto P in SistemaProductos.getProductoRepository().getProductos())
				{
					if (SistemaProductos.getProductoRepository().Filtro(indice, lisMarcas.Text, lisCategorias.Text))
					{
					}
				}
			}
		}
		private void LisCategorias_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			((DataTable)dataGridView1.DataSource).Rows.Clear();
			dataGridView1.Refresh();
			if (lisCategorias.ValueMember == null)
			{
				this.CargarTodosProductos();


			}
			else
			{
				int indice = 0;				
				foreach (Producto P in SistemaProductos.getProductoRepository().getProductos())
				{
					if (SistemaProductos.getProductoRepository().Filtro(indice, lisMarcas.Text, lisCategorias.Text))
					{
						this.CargarProductos(P);
					}
					else if (SistemaProductos.getProductoRepository().Filtro(indice, lisCategorias.Text) && lisMarcas.Text == "")
					{
						this.CargarProductos(P);
					}
					indice++;
				}
			}
		}
	

	
		
		private void CargarProductos(Producto P)
		{
			DataRow row = data.NewRow();
			row["Codigo"] = P.codigo.ToString();
			row["Marca"] = P.marc.nombre;
			row["Categoria"] = P.cate.nombre;
			row["Modelo"] = P.modelo;
			row["Precio"] = P.precio.ToString();
			row["Stock"] = P.stock.ToString();
			data.Rows.Add(row);	
		}
		private void CargarTodosProductos()
		{
			((DataTable)dataGridView1.DataSource).Rows.Clear();
			dataGridView1.Refresh();
			foreach (Producto P in SistemaProductos.getProductoRepository().getProductos())
			{
				DataRow row = data.NewRow();
				row["Codigo"] = P.codigo.ToString();
				row["Marca"] = P.marc.nombre;
				row["Categoria"] = P.cate.nombre;
				row["Modelo"] = P.modelo;
				row["Precio"] = P.precio.ToString();
				row["Stock"] = P.stock.ToString();
				data.Rows.Add(row);
			}
		}

		private void Stock_Activated(object sender, EventArgs e)
		{
			this.CargarTodosProductos();
		}

		
	}
	
}
