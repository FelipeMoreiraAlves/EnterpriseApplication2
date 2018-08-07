using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.Console.UI.Model
{
    class Lancha : Veiculo, IAquatico
    {
        public bool BoiaSalvaVidas { get; set; }

        public Lancha(int ano, double potencia) : base(ano, potencia)
        {
            
        }

        //Sobrescrever o método abstrato da classe herdade
        public override void Desligar()
        {
            System.Console.WriteLine("Pressionando o botão");
        }

        
        public override void Acelerar()
        {
            System.Console.WriteLine("Empurrar o manete");
        }

        public void Flutuar()
        {
            System.Console.WriteLine("Flutuando");
        }
    }
}
