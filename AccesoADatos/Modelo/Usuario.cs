using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos.Modelo
{
    public abstract class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50)]
        string Nombre { get; set; }

        [StringLength(50)]
        string Email { get; set; }

        [StringLength(50)]
        string Password { get; set; }

        [StringLength(50)]
        string Username { get; set; }

    }
}
