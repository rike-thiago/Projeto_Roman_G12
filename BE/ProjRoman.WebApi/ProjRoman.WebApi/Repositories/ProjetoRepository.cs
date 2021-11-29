using ProjRoman.WebApi.Contexts;
using ProjRoman.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjRoman.WebApi.Repositories
{
    public class ProjetoRepository
    {
        RomanContext ctx = new RomanContext();
        public void CadastrarProj(Projeto proj)
        {
            ctx.Projetos.Add(proj);

            ctx.SaveChanges();
        }

        public List<Projeto> listarProj()
        {
            return ctx.Projetos.Select(x => new Projeto
            {
                IdProfessorNavigation = new Professor
                {
                    NomeProfessor = x.IdProfessorNavigation.NomeProfessor
                },
                Descrição = x.Descrição,
                IdTemaNavigation = new Tema
                {
                    NomeTema = x.IdTemaNavigation.NomeTema
                },
                NomeProjeto = x.NomeProjeto
                
            }).ToList();
        }


    }
}
