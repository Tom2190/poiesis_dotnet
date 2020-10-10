using System;
using System.Collections.Generic;
using System.Text;

namespace poiesis_api
{
    class Texto
    {

        private int idTexto { get; set;}
        private Usuario autor { get; set; }
        private DateTime fechaPublicacion { get; set; }
        private String titulo { get; set; }
        private String contenido { get; set; }
    }
}
