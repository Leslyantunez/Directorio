using Directorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejemploclasspersona();


        void ejemploclasspersona()
            {
                Persona persona = new Persona();
                string nombrecompleto = string.Empty;
                Marcador marcador = new Marcador();

                persona.setNombres(" Rosa ");
                persona.setApellidos("Montero ");

                nombrecompleto = persona.getNombreCompleto();

                Console.WriteLine(" persona 1 " + nombrecompleto + " salario: " + marcador.getSalario(44 * 4));

                nombrecompleto = persona.getNombreCompleto(" Luis fernando ","Torres ");

                Console.WriteLine(" persona 2 " + nombrecompleto + " salario: " + marcador.getSalario(35 * 4));

                Console.ReadLine();
            }
        
        
        }
    }
}
