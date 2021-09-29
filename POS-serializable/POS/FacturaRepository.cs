using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
	[Serializable]
	class FacturaRepository
	{
		List<Factura> FacturasExpedidas = new List<Factura>();
		
		public List<Factura> getListaFacturas() {
			return FacturasExpedidas;
		}
		public Factura getFactura() {
			return FacturasExpedidas[this.getUltimoIndice()];
		}

		public List<Producto> getListaProductoFactura()
		{
			return FacturasExpedidas[this.getUltimoIndice()].getProductosEnFactura();
		}
		public Factura BuscarFactura(int numFactura) //agregado el 28/07/2019
		{
			//Factura Encontrada = new Factura();

			foreach (Factura F in FacturasExpedidas)
			{
				if (F.numeroFactura == numFactura)
				{
					return F;
				}
			}

			return null;
		}

		public int getUltimoIndice() {
			int i = FacturasExpedidas.Count-1;
			return i;
		}
	
		public void setNumeroDFactura()
		{
			int numero = FacturasExpedidas.Count;
			FacturasExpedidas[this.getUltimoIndice()].numeroFactura= numero; 
		}

		public void setDatosFactura(BufferFactura F) {
			FacturasExpedidas.Add(new Factura());
			FacturasExpedidas[this.getUltimoIndice()].MontoTotal = F.getMontoTotal();
			FacturasExpedidas[this.getUltimoIndice()].iva = F.getIva();
			FacturasExpedidas[this.getUltimoIndice()].neto = F.getNeto();
			this.setNumeroDFactura();
			FacturasExpedidas[this.getUltimoIndice()].setFecha();
			FacturasExpedidas[this.getUltimoIndice()].setClienteComprador1(F.getCliente());
			foreach (Producto P in F.getProductosEnFactura())
			{
				FacturasExpedidas[this.getUltimoIndice()].setProductosEnFactura(P.precio, P.modelo, P.stock, P.marc, P.cate, P.codigo);
			}
		}
		
	}
}

	

