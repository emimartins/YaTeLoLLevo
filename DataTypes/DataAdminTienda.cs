using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    public class DataAdminTienda : DataUsuario
    {
        string Address { get; set; }
        DateTime Retraso { get; set; }

        ICollection<DataTienda> Tiendas { get; set; }

        ICollection<DataOrden> Ordenes { get; set; }

        ICollection<DataDelivery> Deliveries { get; set; }

        public DataAdminTienda() { }
    }
}
