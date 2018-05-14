using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14_05Interfaces
{
    class Carro : IMeioTrasporte
    {
        public int Velocidade { get; set; }
        public Carro()
        {
            Velocidade = 0;
        }

        public void acelerar()
        {
            Velocidade += 10;
        }

        public void desacelerar()
        {
            throw new NotImplementedException();
        }
    }
}
