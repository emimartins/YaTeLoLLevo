using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Datatypes
{
    public class DataCarrito
    {
      
        public int Id { get; set; }

        public int IdTienda { get; set; }
        public DataTienda Tienda { get; set; }

        public int IdCliente { get; set; }

        public ICollection<DataLineaVenta> LineasVenta { get; set; }


        //Constructores

        public DataCarrito()
        {

        }
    }
    

}
