

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccesoADatos.Modelo
{
    public class Comentario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(300)]
        public string Texto { get; set; }

        public int IdOrden { get; set; }
        public virtual Orden Orden { get; set; }


        public Comentario() { }
    }
}