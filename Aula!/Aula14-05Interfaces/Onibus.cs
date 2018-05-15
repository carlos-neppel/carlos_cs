using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14_05Interfaces
{
    class Onibus : IMeioTransporte
    {
        public int Velocidade { get; set; }

        public string Modelo { get; set; }


        // chave para objeto Marca
        public int MarcaID { get; set; }

        // Propriedade de navegacao
        public virtual Marca _Marca { get; set; }


        public void Acelerar()
        {
            Velocidade += 6;
        }

        public void Desacelerar()
        {
            Velocidade -= 3;
        }

        public string ImprimirInfo()
        {
            return "Ônibus, velocidade atual: " + Velocidade;
        }
    }

    internal interface IMeioTransporte
    {
        void Acelerar();
    }
}
