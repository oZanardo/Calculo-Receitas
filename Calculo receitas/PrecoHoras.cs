using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_receitas
{
    internal class PrecoHoras
    {
        public static double Valor(double hora, double real, double qtd)
        {
            return (real * qtd) / hora;
        }
    }
}