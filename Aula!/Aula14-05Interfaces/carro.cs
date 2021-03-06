﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14_05Interfaces
{
    class Carro : IMeioTransporte
    {
        public int Velocidade { get; set; }

        public string Modelo { get; set; }

        // chave para objeto Marca
        public int MarcaID { get; set; }

        // Propriedade de navegacao
        public virtual Marca _Marca { get; set; }


        public List<Roda> Rodas { get; set; }


        public Carro()
        {
            Velocidade = 0;
        }

        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Desacelerar()
        {
            Velocidade -= 5;
        }

        public string ImprimirInfo()
        {
            return "Carro, velocidade atual: " + Velocidade;
        }
    }
}
