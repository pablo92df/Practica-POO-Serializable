using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace POS
{	[Serializable]
	class Factura
	{
		private Cliente ClienteComprador;
		private List<Producto> ProductoFacturado;
		private decimal TotalACobrar;
		private decimal Iva;
		private decimal Neto;
		private DateTime fecha;
		private int NumeroFactura;
	
		public Factura(){
			ProductoFacturado = new List<Producto>();
			ClienteComprador = new Cliente();
			fecha = DateTime.Now;
		}

		public void setClienteComprador1(Cliente C) {
			ClienteComprador = C;
		}
	
		public void setProductosEnFactura(decimal Precio, string Modelo, int Stock, Marca MarcaDProducto, Categorias CategoriaDProducto, int Codigo)
		{
			ProductoFacturado.Add(new Producto( Precio,  Modelo, 1, MarcaDProducto,  CategoriaDProducto, Codigo));
		}
		public List<Producto> getProductosEnFactura()
		{
			return ProductoFacturado;
		}

		public Cliente getCliente() {
			return ClienteComprador;
		}
	
		
		public decimal iva{
			get =>Iva;
			set => Iva = value;
			
		}
		public decimal neto {
			get => Neto;
			set => Neto = value;
		}
		public decimal MontoTotal {
			get=> TotalACobrar;
			set => TotalACobrar = value;
		}
		public int numeroFactura
		{
			get => NumeroFactura;
			set => NumeroFactura = value;
		}
		public DateTime getFecha()
		{
			return fecha;
		}
		public void setFecha() {
			fecha = DateTime.Now;
		}
		
		

	}

	
}
