using System.Collections.Generic;
using System.Drawing;


namespace Compartido.Datatypes
{
    public class DataTienda
    {

        public int Id { get; set; }

        public string Nombre { get; set; }
        
        public TipoTienda TipoTienda { get; set; }

        public string URL { get; set; }

        public string Direccion { get; set; }
       // public DbGeography Ubicacion { get; set; }

        public byte[] Logo { get; set; }

        public Color? ColorPrincipal { get; set; }

        public Color? ColorSecundario { get; set; }

        public virtual ICollection<DataProducto> Productos { get; set; }

        public virtual ICollection<int> IdClientes { get; set; }


        public DataTienda() { }
    }
}