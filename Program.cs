using System;
using System.Linq;

namespace poiesis_api
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PoiesisDBContext())
            {
                var u = new Usuario()
                {
                    nombre = "puri",
                    apellido = "bey",
                    dni = "12345678",
                    celular = "1511112222",
                    email = "email@test.com",
                    experienciaDeEscritura = "mucha",
                    contrasenia = "password",
                };
                context.Usuarios.Add(u);
                context.SaveChanges();
            }
            Console.WriteLine("Estudiante agregado!");
            Console.ReadKey();

        }
                
    }
}
