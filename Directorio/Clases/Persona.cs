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

        public Persona(string p_nombres)
        {
            this.nombres = p_nombres; ;
        }
        public string getNombres()
        {
            return this.nombres;
        }
        public void setNombreCompleto(string p_nombres)
        {
            this.nombres = p_nombres;
        }
        public void setApellidos(string p_apellidos)
        {
            this.apellidos = p_apellidos;
        } 

        public string getNombreCompleto(string v)
        {
            return this.nombres + " " + this.apellidos;

        }
        public string setNombreCompleto(string nombre, string apellidos)
        {
            return this.nombres + " " + this.apellidos;
        }

        internal string getNombreCompleto()
        {
            throw new NotImplementedException();
        }

        internal void setNombres(string v)
        {
            throw new NotImplementedException();
        }
    }
}
