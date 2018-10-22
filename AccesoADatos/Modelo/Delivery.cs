using Compartido.Datatypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.Modelo
{
    public class Delivery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public TipoVehiculo Vehiculo { get; set; }

        public float MaxVolumen { get; set; }

        public float MaxPeso { get; set; }

        public int IdAdminTienda { get; set; }
        public AdminTienda AdminTienda{ get; set; }

        public virtual ICollection<Orden> Ordenes { get; set; }



        public Delivery() { }

    }
}
