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
    public partial class VerFactura : Form
    {
        private string factura;
        private Sistema SistemaFacturas;
        private DataTable data;

        //public VerFactura()
        //{
        //    InitializeComponent();
        //}

        public VerFactura(string facRecibida)
        {
            if (facRecibida != "")
            {
                factura = facRecibida;
            }

            InitializeComponent();
            SistemaFacturas = Program.getSistema();
        }

        private void VerFactura_Load(object sender, EventArgs e)
        {
            //columnas del grid
            data = new DataTable();
            data.Columns.Add("Codigo").ReadOnly = true;
            data.Columns.Add("Modelo").ReadOnly = true;
            data.Columns.Add("Cantidad").ReadOnly = true;
            data.Columns.Add("Precio").ReadOnly = true;
            gridArticulos.DataSource = data;

            //pasamos factura
            cargarDatosFactura(SistemaFacturas.getFacturaRepository().BuscarFactura(Int32.Parse(factura)));

            //hay que poner una excepcion para cuando factura sea NULL o ""
        }

        private void cargarDatosFactura(Factura F) 
        {
            txtFecha.Text = F.getFecha().ToShortDateString();
            txtNumFactura.Text = F.numeroFactura.ToString();
            txtDniCliente.Text = F.getCliente().dni.ToString();
            txtNomCliente.Text = F.getCliente().nombre.ToString();
            txtLegajo.Text = "sin datos";
            txtNomVendedor.Text = "sin datos";
            txtTotal.Text = F.MontoTotal.ToString();

            foreach(Producto P in F.getProductosEnFactura())
            {
                DataRow row = data.NewRow();
                row["Codigo"] = P.codigo;
                row["Modelo"] = P.modelo;
                row["Cantidad"] = P.stock;
                row["Precio"] = P.precio;
                data.Rows.Add(row);
            }
        }

		private void VerFactura_Activated(object sender, EventArgs e)
		{
			
		}
	}
}
