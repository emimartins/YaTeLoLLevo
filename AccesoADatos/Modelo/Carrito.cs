using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.Modelo
{
    public class Carrito
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdTienda { get; set; }
        public Tienda Tienda { get; set; }

        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }

        public ICollection<LineaVenta> LineasVenta { get; set; }


        //Constructores

        public Carrito()
        {

        }
    }
    

}
