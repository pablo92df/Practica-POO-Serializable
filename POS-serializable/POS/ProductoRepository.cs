using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
	[Serializable]

	class ProductoRepository
	{
		List<Marca> ListaDMarcas = new List<Marca>();
		List<Categorias> ListaDCategorias = new List<Categorias>();
		List<Producto> ProductosAlmacenados = new List<Producto>();

		public void setProducto(decimal precio, string modelo, int stock, string marca, string categoria) {
			ProductosAlmacenados.Add(new Producto(precio, modelo,  stock, ListaDMarcas[PosicionMarca(marca)], ListaDCategorias[PosicionCarga(categoria)]));
			this.setCodigo();
		}
		public void setMarcas(string marca) {
			ListaDMarcas.Add(new Marca(marca));
		}
		public Marca getMarca(string marca) {
			return ListaDMarcas[this.PosicionMarca(marca)];
		}
		public Categorias getCategoria(string categoria) {
			return ListaDCategorias[this.PosicionCarga(categoria)];
		}
		public void setCategorias(string categoria) {
			ListaDCategorias.Add(new Categorias(categoria));
		}
		private int PosicionMarca(string marca) {
			int i = 0;
			foreach (Marca M in ListaDMarcas) {
				if (M.nombre == marca) {
					return i;
				}
				i++;
			}
			return i;
		}
		private int PosicionCarga(string cate)
		{
			int i = 0;
			foreach (Categorias C in ListaDCategorias )
			{
				if (C.nombre == cate)
				{
					return i;
				}
				i++;
			}
			return i;
		}

		public  List<Producto> getProductos()
		{
			return ProductosAlmacenados;
		}
		public List<Marca> getMarcas()
		{
			return ListaDMarcas;
		}
		public List<Categorias> getCategorias()
		{
			return ListaDCategorias;
		}

		public bool Filtro(int posicion, string marca, string categoria) {

			if (ProductosAlmacenados[posicion].marc.nombre == marca && ProductosAlmacenados[posicion].cate.nombre == categoria)
			{
				return true;
			}
			return false;
		}
		public bool Filtro(int posicion, string categoria)
		{
			if (ProductosAlmacenados[posicion].cate.nombre == categoria)
			{
				return true;
			}
			return false;
		}
		public Producto ProductoAFacturar(int codigo) {
			foreach (Producto P in ProductosAlmacenados) {
				if (P.codigo == codigo) {
					return P;
				}
			}
			return null;
		}
		public Producto SeleccionarProducto(string codigo) {
			foreach (Producto P in ProductosAlmacenados) {
				if (P.codigo == Int32.Parse(codigo))
				{
					P.stock -= 1;
					return P;
				}
			}
			return null;
		}

		public bool RestarStock( int codigo, int cantidad)
		{
			foreach (Producto P in ProductosAlmacenados)
			{
				if (P.codigo == codigo)
				{
					if (P.stock >= cantidad)
					{
						P.stock -= cantidad;
						return true;
					}
					else
						return false;

				}
			}
			return false;
		
		}
		//public bool ComprobarStock(int codigo, int cantidad) {
		//	foreach (Producto P in ProductosAlmacenados)
		//	{
		//		if ((P.codigo == codigo) && )
		//		{
		//			return false;
		//		}
		//	}
		//	return true;
		//}
		public bool ProductoExistente(string modelo, string marca, string categoria)
        {
            foreach (Producto p in ProductosAlmacenados)
            {
                if ((p.modelo == modelo) && (p.marc.nombre == marca) && (p.cate.nombre == categoria))
                {
                    return false;
                }
            }
            return true;
        }
		public void RecuperarStock(int codigo, int cantidad) {
			foreach (Producto P in ProductosAlmacenados) {
				if (P.codigo == codigo)
					P.stock += cantidad;
			}
		}
		public void RecuperarStock(BufferFactura F)
		{
			foreach (Producto PF in F.getProductosEnFactura())
			{
				foreach (Producto P in ProductosAlmacenados)
				{
					if (P.codigo == PF.codigo)
						P.stock += PF.stock;
				}
			}
		}
		private void setCodigo() {
			int cod = ProductosAlmacenados.Count;
			ProductosAlmacenados[ProductosAlmacenados.Count-1].codigo = cod;
		}
		
	}
}
