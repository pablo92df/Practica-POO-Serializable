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
    public partial class Caja : Form
    {
		private Sistema SistemaFacturas;
		private DataTable data;
		public Caja()
		{
			InitializeComponent();
			SistemaFacturas = Program.getSistema();
		}


		private void Caja_FormClosed(object sender, FormClosedEventArgs e)
		{
			Menu frmMenu = new Menu();
			frmMenu.Show();
		}
	
		private void CargarFactura(Factura F)
		{
			DataRow row = data.NewRow();
			row["Fecha"] = F.getFecha().ToShortDateString();
			row["Factura"] = F.numeroFactura;
			row["Cliente"] = F.getCliente().nombre;
			row["Total"] = F.MontoTotal;
			data.Rows.Add(row);
		}

		private void Caja_Load_1(object sender, EventArgs e)
		{
			data = new DataTable();
			data.Columns.Add("Fecha").ReadOnly = true;
			data.Columns.Add("Factura").ReadOnly = true;
			data.Columns.Add("Cliente").ReadOnly = true;
			data.Columns.Add("Total").ReadOnly = true;
			gridFacturas.DataSource = data;

			foreach (Factura F in SistemaFacturas.getFacturaRepository().getListaFacturas())
			{
				this.CargarFactura(F);
			}
		}

        private void GridFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridFacturas.SelectedCells[0].ColumnIndex == 1)
            {
                

            }
            
        }

		private void BtnConsultar_Click_1(object sender, EventArgs e)
		{
			string stock = gridFacturas.CurrentRow.Cells["Factura"].Value.ToString();
			Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VerFactura);
			if (frm != null)
			{
				frm.BringToFront();
			}
			else
			{
				VerFactura frmAltaProductos = new VerFactura(gridFacturas.CurrentCell.Value.ToString());
				frmAltaProductos.Show();
			}

		}
	}
}
