using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace POS
{
	[Serializable]

	class Sistema
	{
		ProductoRepository PRO = new ProductoRepository();
		ClienteRepository PERSON = new ClienteRepository();
		FacturaRepository FACT = new FacturaRepository();
		BufferFactura FACTTEMPORAL = new BufferFactura();
		//---------------------------------------------------METODOS DE PRODUCTOREPOSITORY-------------------------------------

		public void setMarcaSistema(string marca) {
			PRO.setMarcas(marca);
		}
		public void setCategoriasSistema(string categoria) {
			PRO.setCategorias(categoria);
		}
		public void setProductosSistema(decimal precio, string modelo, int stock, string marca, string categoria) {
			PRO.setProducto(precio, modelo, stock, marca, categoria);
		}

		public ProductoRepository getProductoRepository()
		{
			return PRO;
		}

		//----------------------------------METODOS DE CLIENTEREPOSITORY------------------------------------------------
		public ClienteRepository getListaClientes()
		{
			return PERSON;
		}
		public void LlamaCargarClientes(string nombre, string apellido, string dni, string localidad, string direccion, string mail, string tel)
		{
			PERSON.CargaCliente(nombre, apellido, dni, localidad, direccion, mail, tel);
		}

		//-------------------------------METODOS DE FACTURAREPOSITORY------------------------------------------------------
		public FacturaRepository getFacturaRepository() {
			return FACT;
		}

		public void setFacturaFinal() {
			FACT.setDatosFactura(FACTTEMPORAL);
		}
		//--------------------------------------METODOS BUFFER FACTURA -----------------------------------------------
		public void MandarAStock(int codigo, int cantidad)
		{
			PRO.RecuperarStock(codigo, cantidad);
		}
		public BufferFactura getFacturaTemporal() {
			return FACTTEMPORAL;
		}
		public void setProductosFactura(string codigo, string marca, string categoria)
		{
			FACTTEMPORAL.ProductosEnFactura(PRO.SeleccionarProducto(codigo), PRO.getMarca(marca), PRO.getCategoria(categoria));
		}
		public void MandarAStock()
		{
			PRO.RecuperarStock(FACTTEMPORAL);
		}
		public void CargarComprador(string dni)
		{
			FACTTEMPORAL.setClienteComprador(PERSON.Filtro(dni));
		}
		public bool LlamarRestarStock(int codigo, int cantidad) {
			int resto = FACTTEMPORAL.CantidadAConsultar(codigo, cantidad);
			if (PRO.RestarStock(codigo, resto)) {
				FACTTEMPORAL.ProductosEnFactura(codigo, resto);
				return true;
			}
			return false;
		}
	}
}
