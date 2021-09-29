using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
	[Serializable]
	class Marca
	{
		private string Nombre;

		public Marca(string Nombre)
		{
			this.Nombre = Nombre;
		}

		
		public string nombre {
			get => Nombre;
			set=>Nombre = nombre;
		}
	}
}
