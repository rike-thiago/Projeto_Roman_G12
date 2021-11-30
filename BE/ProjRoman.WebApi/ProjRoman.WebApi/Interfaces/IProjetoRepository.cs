using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjRoman.WebApi.Interfaces
{
    interface IProjetoRepository
    {
        public void CadastrarProj(Projeto proj);

        public List<Projeto> listarProj();
    }
}
