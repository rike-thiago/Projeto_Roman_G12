using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using ProjRoman.WebApi.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjRoman.WebApi.Interfaces;

namespace ProjRoman.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private IProjetoRepository _projetoRepository { get; set; }

        public ProjetosController()
        {
            _projetoRepository = new ProjetoRepository();
        }

        [HttpPost]
        public IActionResult CadastrarProj(Projeto projetin)
        {
            _projetoRepository.CadastrarProj(projetin);

            return StatusCode(201);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_projetoRepository.listarProj());
        }
    }
}
