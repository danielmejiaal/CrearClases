using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConociendoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1era forma de instancias
            Persona persona1 = new Persona();
            persona1.NombreCompleto = "Jairo";
            persona1.Edad = 37;
            persona1.FechaNacimiento = new DateTime(1980, 8, 13);
            persona1.Casado = true;
            persona1.GeneroPersona = Genero.Masculino;

            //2da forma de instanciar
            Persona persona2 = new Persona
            {
                NombreCompleto = "Lina",
                Edad = 37,
                FechaNacimiento = new DateTime(1979, 12, 29),
                Casado = true,
                GeneroPersona = Genero.Femenino
            };

            // 3re forma de instanciar usando el constructor que tiene los 2 parametros de entrada
            Persona persona3 = new Persona("Mariana", 7);
            persona3.Casado = false;
            persona3.GeneroPersona = Genero.Femenino;

            Console.WriteLine(persona3.GeneroPersona);

            //Console.WriteLine(persona1.NombreCompleto);
            //Console.WriteLine(persona2.NombreCompleto);
            //Console.WriteLine(persona3.NombreCompleto);

            //persona1.MostrarInformacion();
            //persona2.MostrarInformacion();
            //persona3.MostrarInformacion();

            persona1.MostrarTodaLaInformacion();
            persona2.MostrarTodaLaInformacion();
            persona3.MostrarTodaLaInformacion();



            int? valor = null;

            if (!valor.HasValue)
            {
                valor = 10;
            }

            Console.ReadLine();
        }
    }
}
