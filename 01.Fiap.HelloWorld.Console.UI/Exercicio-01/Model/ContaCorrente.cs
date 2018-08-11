using Exercicio_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    //sealed : classe não pode ser herdada
    sealed class ContaCorrente : Conta
    {
        //Propriedades
        public TipoConta Tipo { get; set; }

        //Métodos
        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (Saldo < valor && Tipo == TipoConta.Comum)
            {
                throw new Exception("Saldo insuficiente");
            }
            Saldo -= valor;
        }
    }
}
