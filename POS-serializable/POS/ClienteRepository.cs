using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
	[Serializable]
	class ClienteRepository
	{
		
		
		List<Cliente> ListaClientes = new List<Cliente>();

		public List<Cliente> getClientes() {
			return ListaClientes;
		}		
	
		public void CargaCliente(string nombre, string apellido, string dni, string localidad, string direccion,string mail, string tel)
		{
			ListaClientes.Add(new Cliente(nombre, apellido, dni, localidad, direccion, mail, tel));
	
		}

		public Cliente Filtro(string dni) {
			foreach (Cliente C in ListaClientes) {
				if (dni == C.dni) {
					return C;
				}
			}
			return null;
		}
		

	}
}
