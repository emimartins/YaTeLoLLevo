using System.Collections.Generic;


namespace Compartido.Datatypes
{
    public class DataProducto
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public int Precio { get; set; }

        public TipoMoneda Moneda { get; set; }

        public float Volumen { get; set; }

        public float Peso { get; set; }

        public string Descripcion { get; set; }

        public IList<byte[]> Imagenes { get; set; }

        public int IdTienda { get; set; }

        public DataProducto() { }

    }
}