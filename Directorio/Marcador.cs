using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Directorio
{
    public class Marcador
    {
        private string nombre { get; set; }
        private double costoHora { get; set; }
        private double horasTrabajadas { get; set; }
        private double salario { get; set; }

        public Marcador()
        {
            this.costoHora = 50;

        }
        public double getsalario(double p_horasTrabajadas)
        {
            this.horasTrabajadas = p_horasTrabajadas;
            this.salario = this.horasTrabajadas * this.costoHora;

            return this.salario;
        }
    }
}

