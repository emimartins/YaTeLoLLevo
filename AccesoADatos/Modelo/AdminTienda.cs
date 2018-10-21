using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.Modelo
{
    public class AdminTienda : Usuario
    {
        [StringLength(100)]
        string Address { get; set; }
        DateTime Retraso { get; set; }

        ICollection<Tienda> Tiendas { get; set; }
        
        ICollection<Orden> Ordenes { get; set; }

        ICollection<Delivery> Deliveries { get; set; }


        public AdminTienda() { }
    }
}
