using System;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Infra.Data.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace BRT.HRT.Colaboradores.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TiposExperienciasController : ControllerBase
    {
        private ITipoExperienciaRepository _tipoExperienciaRepository { get; set; }
        public TiposExperienciasController()
        {
            _tipoExperienciaRepository = new TipoExperienciaRepository();
        }
        [HttpGet]
        public IActionResult ListarTiposXP()
        {
            try
            {
                return Ok(_tipoExperienciaRepository.ListarTodosTiposExperiencia());
            }
            catch (Exception ex)
            {

                return BadRequest(new { Erro = ex.ToString() });
            }
        }
    }
}