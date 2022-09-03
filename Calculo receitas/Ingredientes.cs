using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_receitas
{
    internal class Ingredientes
    {
        public string Ingrediente;
        public double Valor;
        public int Quantidade;
        public double Pacote;

        public double Preco()
        {
            double GastoNaReceita = (Valor * Quantidade) / Pacote;

            return GastoNaReceita;
        }

        public override string ToString()
        {
            return "R$" + Valor.ToString("F2",CultureInfo.InvariantCulture) + " Usado na receita de " + Ingrediente;
        }
    }
}
