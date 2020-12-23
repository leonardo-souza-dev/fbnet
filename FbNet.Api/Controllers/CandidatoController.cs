using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FbNet.Dominio.Entidades;
using FbNet.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FbNet.Api2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CandidatoController : ControllerBase
    {
        private readonly ITudoService _tudoService;

        public CandidatoController(ITudoService tudoService)
        {
            _tudoService = tudoService;
        }

        [HttpGet]
        public List<ProcessoSeletivo> GetProcessosSeletivos()
        {
            var candidato = _tudoService.ObterProcessosHome(6);

            return candidato;
        }
    }
}
