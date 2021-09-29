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
	public partial class Buscar_Clientes : Form
	{
		private Sistema SistemaClientes;
		public Buscar_Clientes()
		{
			InitializeComponent();
			SistemaClientes = Program.getSistema();
		}

		private void Buscar_Clientes_Load(object sender, EventArgs e)
		{
			int i = 0;
			foreach (Cliente C in SistemaClientes.getListaClientes().getClientes()) {
				listViewClientes.Items.Add(C.apellido);
				listViewClientes.Items[i].SubItems.Add(C.nombre);
				listViewClientes.Items[i].SubItems.Add(C.dni);
				listViewClientes.Items[i].SubItems.Add(C.localidad);
				listViewClientes.Items[i].SubItems.Add(C.direccion);
				listViewClientes.Items[i].SubItems.Add(C.mail);
				listViewClientes.Items[i].SubItems.Add(C.tel);
				i++;
				
			}

		}

		private void BtnBuscar_Click(object sender, EventArgs e)
		{
			
			listViewClientes.Items.Clear();
			//foreach (Cliente C in SistemaClientes.getListaClientes().getClientes())
			//{
			//	listViewClientes.Items.Add(C.apellido);
			//	listViewClientes.Items[i].SubItems.Add(C.nombre);
			//	listViewClientes.Items[i].SubItems.Add(C.dni);
			//	listViewClientes.Items[i].SubItems.Add(C.localidad);
			//	listViewClientes.Items[i].SubItems.Add(C.direccion);
			//	listViewClientes.Items[i].SubItems.Add(C.mail);
			//	listViewClientes.Items[i].SubItems.Add(C.tel);
			//	i++;
			//}
		}

		private void BtnConfirmar_Click(object sender, EventArgs e)
		{
			ListViewItem lisdni = listViewClientes.SelectedItems[0];
			SistemaClientes.CargarComprador(lisdni.SubItems[2].Text);
			this.Close();

		}
	}
}
