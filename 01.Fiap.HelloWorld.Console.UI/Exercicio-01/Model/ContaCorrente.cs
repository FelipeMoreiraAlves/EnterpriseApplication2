using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaCorrente : Conta
    {
        public TipoConta Tipo { get; set; }

        public double Depositar(decimal valor)
        {
            valor += valor;
        }
    }
}
