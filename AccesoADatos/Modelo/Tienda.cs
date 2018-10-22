using Compartido.Datatypes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Drawing;

namespace AccesoADatos.Modelo
{
    public class Tienda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }
        
        [Required]
        public TipoTienda TipoTienda { get; set; }

        [StringLength(100)]
        public string URL { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }
       // public DbGeography Ubicacion { get; set; }

        public byte[] Logo { get; set; }

        public Color? ColorPrincipal { get; set; }

        public Color? ColorSecundario { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }


        public Tienda() { }
    }
}