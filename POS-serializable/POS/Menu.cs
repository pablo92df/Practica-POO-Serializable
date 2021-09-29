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
    public partial class Menu : Form
    {
	
        public Menu()
        {
            InitializeComponent();
        }

     
        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Clientes);
            if (frm != null)
            {
                frm.BringToFront();
            }
            else
            {
                Clientes frmClientes = new Clientes();
                frmClientes.Show();
            }
        }

        private void BtnCaja_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Caja);
            if (frm != null)
            {
                frm.BringToFront();
            }
            else
            {
                Caja frmCaja = new Caja();
                frmCaja.Show();
            }
        }
    
        private void BtnStock_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Stock);
            if (frm != null)
            {
                frm.BringToFront();
            }
            else
            {
                Stock frmStrock = new Stock();
                frmStrock.Show();
            }
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Ventas);
            if (frm != null)
            {
                frm.BringToFront();
            }
            else
            {
                Ventas frmVentas = new Ventas();
                frmVentas.Show();
            }
        }

        private void BtnAltaProductos_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is AltaProductos);
            if (frm != null)
            {
                frm.BringToFront();
            }
            else
            {
                AltaProductos frmAltaProductos = new AltaProductos();
                frmAltaProductos.Show();
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



	}
}
