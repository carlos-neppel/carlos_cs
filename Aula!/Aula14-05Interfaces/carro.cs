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
        //cheve para objetos MArca
        public int MarcaId { get; set; }

        //Propriedade de navegação
        public virtual Marca _Marca { get; set; }

        public List<Roda> Rodas { get; set; }


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
            Velocidade -= 5;
        }

       public string ImprimirInfo()
        {
            return "carro, velicidade atual " + Velocidade;
        }
    }
}
