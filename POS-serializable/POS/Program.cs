using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
	

	static class Program
	{
		private static Sistema SistemaInicializador; 

		public static Sistema getSistema()
		{
			return SistemaInicializador;
		}
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{

			SistemaInicializador = new Sistema();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//SistemaInicializador.setMarcaSistema("Samsung");
			//SistemaInicializador.setMarcaSistema("Apple");
			//SistemaInicializador.setMarcaSistema("Acer");
			//SistemaInicializador.setMarcaSistema("HP");
			//SistemaInicializador.setMarcaSistema("Intel");
			//SistemaInicializador.setMarcaSistema("AMD");
			///////////////////////////////////////////////////////////////////////////////////////////////
			//SistemaInicializador.setCategoriasSistema("Procesadores");
			//SistemaInicializador.setCategoriasSistema("Notebook");
			//SistemaInicializador.setCategoriasSistema("Monitor");
			//SistemaInicializador.setCategoriasSistema("Celular");
			//SistemaInicializador.setCategoriasSistema("Tablet");
			//SistemaInicializador.setCategoriasSistema("TV");
			//SistemaInicializador.setCategoriasSistema("Impresora");
			///////////////////////////////////////////////////////////////////////////////////////////////
			//SistemaInicializador.setProductosSistema(50000m, "IPhone X", 4, "Apple", "Celular");
			//SistemaInicializador.setProductosSistema(10000m, "Ryzen3 2500", 5, "AMD", "Procesadores");
			//SistemaInicializador.setProductosSistema(32000m, "Pavilion 15", 2, "HP", "Notebook");
			//SistemaInicializador.setProductosSistema(55000m, "TV 4k Live", 10, "Samsung", "TV");
			//SistemaInicializador.setProductosSistema(8000m, "LaserJet 1120", 11, "HP", "Impresora");
			/////////////////////////////////////////////////////////////////////////////////////////////
			//SistemaInicializador.LlamaCargarClientes("Raul", "Benitez", "15032647", "Moron", "Calle 5", "raulbeni@gmail.com", "01145966523");
			//SistemaInicializador.LlamaCargarClientes("Miriam", "Rodriguez", "10942673", "Haedo", "Calle 48", "", "01157893256");

			//Stream flujo = File.Create("POS.bin");
			//BinaryFormatter serializer = new BinaryFormatter();
			//serializer.Serialize(flujo, SistemaInicializador);
			//flujo.Close();


			if (File.Exists("POS.bin"))
			{
				Stream flujo2 = File.OpenRead("POS.bin");
				BinaryFormatter deserializer = new BinaryFormatter();
				SistemaInicializador = (Sistema)deserializer.Deserialize(flujo2);


				flujo2.Close();
			}
			else
			{
				MessageBox.Show("Error");
			}

			Application.ApplicationExit += new System.EventHandler(SerializarAlSalir);
			Application.Run(new Menu());


		}

		public static void SerializarAlSalir(object sender, EventArgs e)
		{
			Stream flujo2 = File.Create("POS.bin");
			BinaryFormatter serializer = new BinaryFormatter();
			serializer.Serialize(flujo2, SistemaInicializador);
			flujo2.Close();

		}



	}
}
