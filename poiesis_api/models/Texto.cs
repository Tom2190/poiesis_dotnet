using System;
using System.Collections.Generic;
using System.Text;

namespace poiesis_api.Models
{
    public partial class Texto
    {

        public int idTexto { get; set;}
        public int idUsuario { get; set; }
        public DateTime fechaPublicacion { get; set; }
        public String titulo { get; set; }
        public String contenido { get; set; }

        public virtual Usuario Usuario { get; set; }

    }
}
