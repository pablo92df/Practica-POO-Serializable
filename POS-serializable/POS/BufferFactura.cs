using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace POS
{
	[Serializable]
	class BufferFactura
	{
		private Cliente ClienteComprador;
		private List<Producto> ProductoFacturado;
		private decimal TotalACobrar = 0;
		private decimal Iva = 0;
		private decimal Neto = 0;

		public BufferFactura()
		{
			ProductoFacturado = new List<Producto>();
			ClienteComprador = new Cliente();
		}

		public void setClienteComprador(Cliente C)
		{
			ClienteComprador = C;
		}
		//public void setVendedor(Vendedor V)
		//{
		//	Vendedor = V;
		//}
		public bool ExixteProducto(int codigo)
		{
			foreach (Producto P in ProductoFacturado)
			{
				if (P.codigo == codigo)
				{
					P.stock++;
					this.SumaDePrecios(P.precio);
					return true;
				}
			}
			return false;
		}
		public void ProductosEnFactura(Producto P, Marca MarcaDProducto, Categorias CategoriaDProducto)
		{
			if (!this.ExixteProducto(P.codigo)) { 
				ProductoFacturado.Add(new Producto(P.precio, P.modelo, 1, MarcaDProducto, CategoriaDProducto, P.codigo));
			this.SumaDePrecios(P.precio);
			}
		}
		public void ProductosEnFactura(int codigo, int cantidad)
		{
			foreach(Producto P in ProductoFacturado)
			{
				if (P.codigo == codigo) {
					P.stock += cantidad;
					this.SumaDePrecios(P.precio*cantidad);
				}
			}
		}
		public List<Producto> getProductosEnFactura()
		{
			return ProductoFacturado;
		}
		public void SumaDePrecios(decimal precio)
		{
			TotalACobrar += precio;
			this.setIva();
			this.setNeto();
		}
		public void RestarProductoEliminado(decimal precio, int cantidad)
		{
			TotalACobrar -= precio * cantidad;
			this.setIva();
			this.setNeto();
		}

		public Cliente getCliente()
		{
			return ClienteComprador;
		}
	
		public void setIva()
		{
			Iva = TotalACobrar * 0.21m;
		}
		public decimal getIva()
		{
			return Iva;
		}
		public void setNeto()
		{
			Neto = TotalACobrar * 0.79m;
		}
		public decimal getNeto()
		{
			return Neto;
		}
		public decimal getMontoTotal()
		{
			return TotalACobrar;
		}
		public void BorrarProducto(string codigo)
		{
			foreach (Producto P in ProductoFacturado)
			{
				if (P.codigo == Int32.Parse(codigo))
				{
					ProductoFacturado.Remove(P);
					break;
				}
			}
		}
		public void VaciarProductos() {
			foreach (Producto P in ProductoFacturado) {
				this.RestarProductoEliminado(P.precio,P.stock);
			}
				ProductoFacturado.Clear();			
		}
		public void BorrarComprador() {
			ClienteComprador = null;
		}
		public int CantidadAConsultar(int codigo, int cantidad) {
			int resto = 0;
			foreach (Producto P in ProductoFacturado) {
				if (P.codigo == codigo) {
					resto=Math.Abs(P.stock - cantidad);
					if (resto == 0)
						return cantidad;
					else
						return resto;
				}
			}
			return 0;
		}
	}
}
