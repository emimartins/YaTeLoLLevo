using AccesoADatos.Modelo;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    public class DataDelivery
    {

        public int Id { get; set; }
        
        public TipoVehiculo Vehiculo { get; set; }

        public float MaxVolumen { get; set; }

        public float MaxPeso { get; set; }

        public int IdAdminTienda { get; set; }

        public virtual ICollection<DataOrden> Ordenes { get; set; }



        public DataDelivery() { }

    }
}
