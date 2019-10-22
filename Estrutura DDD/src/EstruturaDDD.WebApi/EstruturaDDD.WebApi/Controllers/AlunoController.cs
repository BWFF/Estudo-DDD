using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstruturaDDD.Domain.Entities;
using EstruturaDDD.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstruturaDDD.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;
        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpGet]
        public IEnumerable<Aluno> ObterTodos()
        {
            return _alunoService.ObterTodos();
        }
    }
}
