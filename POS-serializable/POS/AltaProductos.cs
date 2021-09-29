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
    public partial class AltaProductos : Form
    {
        private Sistema SistemaProductos;
        public AltaProductos()
        {
            InitializeComponent();
            SistemaProductos = Program.getSistema();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if ((( txtModelo.Text == "") && (txtPrecio.Text == "") && (txtStock.Text == ""))) {
                MessageBox.Show("Complete los campos para continuar.","Sin datos",MessageBoxButtons.OK,MessageBoxIcon.Information);
              
            }
           else if (SistemaProductos.getProductoRepository().ProductoExistente(txtModelo.Text, lisMarca.Text, lisCategoria.Text)) {
                SistemaProductos.setProductosSistema(Int32.Parse(txtPrecio.Text), txtModelo.Text, Int32.Parse(txtStock.Text), lisMarca.Text, lisCategoria.Text);
				MessageBox.Show("Producto cargado con exito");
				txtModelo.Clear();
				txtStock.Clear();
				txtPrecio.Clear();
			}
            else
            {
                MessageBox.Show("El producto ingresado ya existe. Verifique la informacion y vuelva a intentar.");
            }
          
        }

        private void AltaProductos_Load(object sender, EventArgs e)
        {
            this.CargarCategorias();
            this.CargarMarcas();
        }

        private void CargarMarcas()
        {
            foreach (Marca M in SistemaProductos.getProductoRepository().getMarcas())
            {
                lisMarca.Items.Add(M.nombre.ToString());
                
            }
        }
        private void CargarCategorias()
        {
            foreach (Categorias C in SistemaProductos.getProductoRepository().getCategorias())
            {
                lisCategoria.Items.Add(C.nombre.ToString());
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
