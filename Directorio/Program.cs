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
            Persona persona = new Persona();

            persona.setNombres("Lesly");
            
            Console.WriteLine(persona.getNombres());

            Marcador marcador = new Marcador();
            Console.WriteLine(marcador.getsalario(8));

            Console.ReadLine();

           


        
        }
    }
}
