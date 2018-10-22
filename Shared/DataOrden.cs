using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    public class DataOrden
    {

        public int Id { get; set; }
        
        public DataEstadoOrden EstadoOrden { get; set; }

        public  int IdPedido { get; set; }

        public virtual ICollection<DataComentario> Comentarios { get; set; }

        public int IdAdminTienda { get; set; }

        public int IdDelivery { get; set; }


        public DataOrden() { }
    }
}
