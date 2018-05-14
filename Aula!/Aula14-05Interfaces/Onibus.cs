﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14_05Interfaces


{
    class Onibus : IMeioTrasporte

    {

        public int Velocidade { get; set; }

        //cheve para objetos MArca
        public int MarcaId { get; set; }

        //Propriedade de navegação
        public virtual  Marca _Marca{ get; set; }

        public Onibus()
        {

            Velocidade = 0;

        }
        public void acelerar()
        {
            Velocidade += 10;
        }

        public void desacelerar()
        {
            Velocidade -= 10;
        }
        public string ImprimirInfo()
        {
            return "Onibus, velicidade atual " + Velocidade;
        }
    }
}
