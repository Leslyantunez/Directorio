using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Directorio.Clases
{
    public class Persona
    {
        private string nombres { set; get; }

        public string apellidos { set; get; }

        public string direccion { set; get; }
        public int edad { set; get; }
        public DateTime fechanacimiento { set; get; }
        public string telefono { set; get; }
        public string celular { set; get; }
        public string email { set; get; }

        public Persona()
        {
            this.nombres = "Veronica";
            this.apellidos = "Antunez";
        }
        
        public string getNombres()
            {
                return this.nombres;
            }
            public void setNombres(string p_nombres)
        {
            this.nombres = p_nombres;
       


        }



    }
}
