using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccesoADatos.Modelo
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        public int Precio { get; set; }

        [Required]
        public TipoMoneda Moneda { get; set; }

        public float Volumen { get; set; }

        public float Peso { get; set; }

        [StringLength(300)]
        public string Descripcion { get; set; }

        public IList<byte[]> Imagenes { get; set; }

        public int IdTienda { get; set; }
        public virtual Tienda Tienda { get; set; }

        public Producto() { }

    }
}