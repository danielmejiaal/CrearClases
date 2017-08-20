using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConociendoCSharp
{
    public class Persona
    {
        public string NombreCompleto { get; set; }

        public int Edad { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public bool? Casado { get; set; }

        public Genero GeneroPersona { get; set; }

        public Persona()
        {
        }

        public Persona(string nombre, int edad)
        {
            NombreCompleto = nombre;
            Edad = edad;

            FechaNacimiento = DateTime.Now;
            Casado = true;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine(NombreCompleto + " tiene " + Edad + " años");
        }

        public void MostrarTodaLaInformacion()
        {
            Console.WriteLine(NombreCompleto + " tiene " + Edad + " año, nació el " + FechaNacimiento.ToString("yyyy-MM-dd") + " y " + (Casado.Value ? "está casado" : "no está casado"));
        }

        public void UsandoStringFormat()
        {
            Console.WriteLine(String.Format("{0} tiene {1} años{100}", NombreCompleto, Edad, Environment.NewLine));
        }

        public bool EsMayorEdad()
        {
            return Edad >= 18;
        }
    }
}
