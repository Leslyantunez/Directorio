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
        static void Main(string[ ] args)
        {
            Persona persona = new Persona();
            string nombrecompleto = string.Empty;

            persona.setNombres("Veronica");
            persona.setApellidos("Antunez");

            nombrecompleto = persona.getNombreCompleto();

            Console.WriteLine("persona 1" + nombrecompleto);

            nombrecompleto = persona.getNombreCompleto("Lesly Maria Antunez Oliva");

            Console.WriteLine("persona 2" + nombrecompleto);

            Console.ReadLine();
            
            Console.WriteLine(persona.getNombres());

            Marcador marcador = new Marcador();
            Console.WriteLine(marcador.getsalario(8));

            Console.ReadLine();

           


        
        }
    }
}
