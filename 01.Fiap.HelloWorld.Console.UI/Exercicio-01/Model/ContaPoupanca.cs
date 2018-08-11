using Fiap.Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        //propriedades
        public decimal Taxa { get; set; }

        //Campos, fields (atributos)
        private readonly decimal _rendimento;

        //Construtor
        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }

        //Métodos
        public decimal Rendimento
        {
            get { return _rendimento; }
        }
        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (Saldo < valor + Taxa)
            {
                throw new Exception("Saldo insuficiente");
            
            }
            Saldo -= valor;
        }
    }
}
