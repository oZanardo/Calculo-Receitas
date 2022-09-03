using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_receitas
{
    internal class Funcoes
    {
        public static double PrecoHora(double hora, double real, double qtd)
        {
            return (real * qtd) / hora;
        }
        public static double Info(double ValorB, double ValorUsado, double Nutri)
        {
            double Nutricional = (ValorB * Nutri) / ValorUsado;
            return Nutricional;
        }
    }
}