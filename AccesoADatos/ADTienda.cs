using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos.Modelo;
using Compartido.Datatypes;

namespace AccesoADatos
{
    public class ADTienda
    {
        public ADTienda() { }
        public void AltaTienda(DataTienda dataTienda)
        {
            YaTeLoLLevoContext.ProvisionTenant(dataTienda.Nombre);
            
            using (var ctx = YaTeLoLLevoContext.Create(dataTienda.Nombre))
            {
                Tienda t = new Tienda();
                t.Nombre = dataTienda.Nombre;
                t.Logo = dataTienda.Logo;
                t.TipoTienda = dataTienda.TipoTienda;
                t.URL = dataTienda.URL;
                t.ColorPrincipal = dataTienda.ColorPrincipal;
                t.ColorSecundario = dataTienda.ColorSecundario;
                t.Direccion = dataTienda.Direccion;
                ctx.Tiendas.Add(t);
                ctx.SaveChanges();
            }
        }
    }
}
