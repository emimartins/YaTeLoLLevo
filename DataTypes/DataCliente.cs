using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    public class DataCliente : DataUsuario
    {
        public string Direccion { get; set; }

        public ICollection<DataPedido> Pedidos { get; set; }

        public ICollection<DataCarrito> Carritos { get; set; }

        public ICollection<DataTienda> Tiendas { get; set; }


        public DataCliente()
        {

        }
    }
}
