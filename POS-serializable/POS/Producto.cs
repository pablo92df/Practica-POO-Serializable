using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{	[Serializable]
	class Producto
	{
		private decimal Precio;
		private string Modelo;
		//private DateTime FechaIngreso;
		private int Stock;
		//private string Caracteristicas;
		private Marca MarcaDProducto;
		private Categorias CategoriaDProducto;
		private int Codigo;
		private static int generadorCodigo=0;

		public Producto(decimal Precio, string Modelo, int Stock, Marca MarcaDProducto, Categorias CategoriaDProducto)
		{
			Codigo = ++generadorCodigo;
			this.Precio = Precio;
			this.Modelo = Modelo;
			//this.Caracteristicas = Caracteristicas;
			//this.FechaIngreso = FechaIngreso;
			this.Stock = Stock;
			this.MarcaDProducto = MarcaDProducto;
			this.CategoriaDProducto = CategoriaDProducto;
		}
		public Producto() { }
		public Producto(decimal Precio, string Modelo, int Stock, Marca MarcaDProducto, Categorias CategoriaDProducto, int Codigo)
		{
			this.Codigo = Codigo;
			this.Precio = Precio;
			this.Modelo = Modelo;
			//this.Caracteristicas = Caracteristicas;
			//this.FechaIngreso = FechaIngreso;
			this.Stock = Stock;
			this.MarcaDProducto = MarcaDProducto;
			this.CategoriaDProducto = CategoriaDProducto;
		}
		public int codigo {
			get => Codigo;
			set => Codigo = value;
		}
		public string modelo {
			get=>Modelo;
			set=>Modelo=value;
		}
		public decimal precio {
			get=>Precio;
			set=>Precio=value;
		}
		public int stock{
			get=>Stock;
			set=>Stock=value;
		}
		public Marca marc{
			get=>MarcaDProducto;
			set=>MarcaDProducto=value;
		}
		public Categorias cate{
			get=>CategoriaDProducto;
			set=>CategoriaDProducto=value;
		}
		public bool RestarStock(int cantidad) {
			if (cantidad <= stock)
			{
				stock -= cantidad;
				return true;
			}
			return false;
		}
		
	}
}
