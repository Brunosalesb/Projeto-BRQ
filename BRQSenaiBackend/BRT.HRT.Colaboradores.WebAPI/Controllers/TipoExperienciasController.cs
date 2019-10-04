using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.ITipoExperiencia;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMTipoExperiencia;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BRQ.HRT.Colaboradores.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TipoExperienciasController : ControllerBase
    {
        private readonly ITipoExperienciaService _mapperTipoExp;
        private readonly ICadastroTipoExperienciaService _mapperCadTipoExp;

        public TipoExperienciasController(ITipoExperienciaService mapperTipoExp, ICadastroTipoExperienciaService mapperCadTipoExp)
        {
            _mapperTipoExp = mapperTipoExp;
            _mapperCadTipoExp = mapperCadTipoExp;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                return Ok(_mapperTipoExp.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastroTipoExperienciaViewModel tipoExp)
        {
            try
            {
                _mapperCadTipoExp.Add(tipoExp);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }
    }
}