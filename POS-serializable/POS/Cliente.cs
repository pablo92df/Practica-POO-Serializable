using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
	[Serializable]
	class Cliente
	{
		private string Nombre;
		private string Apellido;
		private string DNI;
		private string Localidad;
		private string Direccion;
		private string Mail;
		private string Tel;

		public Cliente(string Nombre, String Apellido, string DNI,string Localidad, string Direccion, string Mail, string Tel)  {
			this.Nombre = Nombre;
			this.Apellido = Apellido;
			this.DNI = DNI;
			this.Localidad = Localidad;
			this.Direccion = Direccion;
			this.Mail = Mail;
			this.Tel = Tel;

		}
		public Cliente() {
		}
		
		public string localidad {
			get=>Localidad;
			set=>Localidad=value;
		}
		public string direccion {
			get=>Direccion;
			set=>Direccion=value;
		}
		public string mail{
			get=>Mail;
			set=>Mail=value;
		}
		public string tel{
			get=>Tel;
			set=>Tel=value;
		}
	
		public string nombre
		{
			get => Nombre;
			set => Nombre = value;
		}
		public string apellido
		{
			get => Apellido;
			set => Apellido = value;
		}
		public string dni
		{
			get => DNI;
			set => DNI = value;
		}
	}
}
