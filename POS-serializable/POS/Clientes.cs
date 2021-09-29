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
	[Serializable]

	public partial class Clientes : Form
    {
		private Sistema SistemaClientes;
		public Clientes()
        {
            InitializeComponent();
			SistemaClientes = Program.getSistema();
        }


		private void BtCargar_Click(object sender, EventArgs e)
		{
			SistemaClientes.LlamaCargarClientes(txtNombre.Text, txtApellido.Text, txtDNI.Text,txtLocalidad.Text, txtDomicilio.Text+" "+txtAltura.Text, txtMail.Text, txtTel.Text);
			txtApellido.Clear();
			txtDNI.Clear();
			txtDomicilio.Clear();
			txtLocalidad.Clear();
			txtMail.Clear();
			txtNombre.Clear();
			txtTel.Clear();
		}
	}
}
