using ProjRoman.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjRoman.WebApi.Interfaces
{
    interface IUsuarioRepository
    {
        public Usuario Login(string email, string senha);
    }
}
