using System.Collections.Generic;
using Modelos;
using System.Linq;

namespace Controllers
{
    public  class AtividadesController 
    {
        private static List<Atividade> ListaAtividade { get; set; }

        private static int uUtimoIdUtilizado = 1;
        static AtividadesController()
        {
            ListaAtividade = new List<Atividade>();
        }

        //salvar
        public void Salvar(Atividade atividade)
        {
            atividade.AtividadeID = uUtimoIdUtilizado++;
            ListaAtividade.Add(atividade);
        }
        //Listar

        public List<Atividade> Listar()
        {
            return ListaAtividade;
        }

        //BsucarPorId

        public Atividade BuscarPorId(int id)
        { 
            foreach (Atividade a in ListaAtividade)
            {
                if (a.AtividadeID == id)
                {
                    return a;
                }
            }

            return null;

        }

        //BuscarPorNome

        public List<Atividade>  BuscarPorNome(string nome)
        {
            IEnumerable<Atividade> AtividadeSelecionada = new List<Atividade>();
            AtividadeSelecionada = from x in ListaAtividade
                                   where x.Nome.ToLower().Contains(nome.ToLower())
                                   select x;
            return AtividadeSelecionada.ToList();

        }
        //BuscarAtivoInativo

        public List<Atividade> BuscaAtivoInativo (bool ativo)
        {

        }






    }
}
