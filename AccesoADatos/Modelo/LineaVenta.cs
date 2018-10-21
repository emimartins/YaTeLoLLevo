using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccesoADatos.Modelo
{
    public class LineaVenta
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdProducto { get; set; }
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }


        public LineaVenta() { }
    }
}