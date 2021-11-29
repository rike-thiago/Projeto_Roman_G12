﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ProjRoman.WebApi
{
    public partial class Projeto
    {
        public int IdProjeto { get; set; }
        public int IdTema { get; set; }
        public int IdProfessor { get; set; }
        public string NomeProjeto { get; set; }
        public string Descrição { get; set; }

        public virtual Professor IdProfessorNavigation { get; set; }
        public virtual Tema IdTemaNavigation { get; set; }
    }
}
