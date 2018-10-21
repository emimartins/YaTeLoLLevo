using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    public class ADTienda
    {
        public ADTienda() { }
        public void crearTenant(string nombre)
        {
            YaTeLoLLevoContext.ProvisionTenant(nombre);

            using (var ctx = YaTeLoLLevoContext.Create(nombre))
            {

            }
        }
    }
}
