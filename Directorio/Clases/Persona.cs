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
        private string numeroid { get; set; }
        private string nombres { set; get; }

        private string apellidos { set; get; }

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

        public Persona(string p_nombres)
        {
            this.nombres = p_nombres; ;
        }
        public string getNombres()
        {
            return this.nombres;
        }
        public void setNombres( string p_nombres)
        {
            this.nombres = p_nombres;
        }
        public string getApellidos()
        {
            return this.apellidos;
        }
        public void setApellidos(string p_apellidos)
        {
            this.apellidos = p_apellidos;
        }
        public string getNombreCompleto()
        {
            return this.nombres + " " + this.apellidos;
        }
        public string getNombreCompleto(string p_nombres, string p_apellidos)
        {
            this.nombres = p_nombres;
            this.apellidos = p_apellidos;

            return this.nombres + " " + this.apellidos;

        }
     
       
       
        
    }
}
