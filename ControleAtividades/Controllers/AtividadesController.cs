using System.Collections.Generic;
using Modelos;
using System.Linq;
using Controllers.DAL;
using Controllers.Base;

namespace Controllers
{
    public class AtividadesController : IBaseController<Atividade>       
    {
        private Contexto contexto = new Contexto();


        public void Adicionar(Atividade entity)
        {
            contexto.Atividades.Add(entity);
            contexto.SaveChanges();
        }

        public Atividade BuscarPorId(int id)
        {
            return contexto.atividades.Find(id)
        }

        public IList<Atividade> ListarPorNome(string nome)
        {
            /*var atividadeComNome = from a in contexto.Atividades
                        where a.Nome == nome
                        select a;
            return atividadeComNome.ToList;*/

            //lamba
            return contexto.Atividades.Where(a => a.Nome.ToLower() == nome.ToLower()).ToList();

        }

        public void Atualizar(Atividade entity)
        {

            contexto.Entry(entity).State = 
                System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();

        }




     }
}
