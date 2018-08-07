using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.Console.UI.Model
{
    //classe abstrata: não pode ser instanciado 
    //e pode conter métodos abstratos, sem implementação
    abstract class Veiculo
    {
        private double _potencia;


        public int Ano { get; set; }
        public double Potencia
        {
            get { return _potencia; }
            set
            {
                if (value > 0)
                {
                    _potencia = value;
                }

            }
        }

        public Veiculo(int ano, double potencia)
        {
            Ano = ano;
            Potencia = potencia; 
        }

        //virtual permite a sobrescrita de método
        public virtual void Acelerar()
        {
            System.Console.WriteLine("Veiculo acelerando");
        }

        public abstract void Desligar();
    }
}
