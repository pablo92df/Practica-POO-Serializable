using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
	[Serializable]
	class Categorias
	{

		private string Nombre;
		public Categorias(string Nombre)
		{
			this.Nombre = Nombre;
		}

		public string nombre{
			get=>Nombre;
			set=>Nombre=value;
		}
	}
}
