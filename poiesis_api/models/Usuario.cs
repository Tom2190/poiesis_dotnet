using System;
using System.Collections.Generic;
using System.Text;

namespace poiesis_api.Models
{
    class Usuario
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
        //public void cambiarContrasenia(String contrasenia)
        //{

        //}
        //public void recuperarContrasenia()
        //{

        //}
        //public void darDeBajaTexto(int idTexto)
        //{

        //}
        //public void crearTexto(String titulo, String contenido, Enum genero)
        //{

        //}
        //public void editarTexto(int idTexto)
        //{

        //}
        //public Texto buscarTexto(int idTexto)
        //{
        //    return null;
        //}
        //public void editarPerfil(String nombre, String apellido, String dni, String celular, String experienciaDeEscritura, Enum FrecuenciaDeLectura, Enum GeneroDeEscrituraPredilecto)
        //{

        //}
    }
}
