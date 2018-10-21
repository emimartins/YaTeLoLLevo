using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.Modelo
{
    public class Cliente : Usuario
    {
        [StringLength(100)]
        public string Direccion { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

        public ICollection<Carrito> Carritos { get; set; }

        public ICollection<Tienda> Tiendas { get; set; }


        public Cliente()
        {

        }
    }
}
