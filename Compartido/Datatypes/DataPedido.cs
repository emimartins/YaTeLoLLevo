using System.Collections.Generic;

namespace Compartido.Datatypes
{
    public class DataPedido
    {

        public int Id { get; set; }
        public MetodoPago Pago { get; set; }
        public  DataOrden Orden { get; set; }
        public int IdCliente { get; set; }

        public virtual ICollection<DataLineaVenta> LineasVenta { get; set; }

        public DataPedido() { }
    }
}