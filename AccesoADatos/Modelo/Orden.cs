using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.Modelo
{
    public class Orden
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public int IdEstadoOrden { get; set; }
        public virtual EstadoOrden EstadoOrden { get; set; }

        public virtual Pedido Pedido { get; set; }

        public int IdAdminTienda { get; set; }
        public virtual AdminTienda AdminTienda { get; set; }

        public int IdDelivery { get; set; }
        public virtual Delivery Delivery { get; set; }

        public virtual ICollection<Comentario> Comentarios { get; set; }

        public Orden() { }
    }
}
