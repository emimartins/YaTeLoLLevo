using Compartido.Datatypes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccesoADatos.Modelo
{
    public class Pedido
    {
        [Key]
        [ForeignKey("Orden")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public MetodoPago Pago { get; set; }
        public virtual Orden Orden { get; set; }
        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<LineaVenta> LineasVenta { get; set; }

        public Pedido() { }
    }
}