using System;
using System.Collections.Generic;
using System.Text;

namespace poiesis_api.Models
{
    public partial class Usuario
    {

        public Usuario()
        {
            Texto = new HashSet<Texto>();
        }

        private int idUsuario { get; set; }
        private String nombre { get; set; }
        private String apellido { get; set; }
        private String dni { get; set; }
        private String celular { get; set; }
        private String email { get; set; }
        private String experienciaDeEscritura { get; set; }
        private String contrasenia { get; set; }
        private ICollection<Texto> Texto { get; set; }
    }
}
