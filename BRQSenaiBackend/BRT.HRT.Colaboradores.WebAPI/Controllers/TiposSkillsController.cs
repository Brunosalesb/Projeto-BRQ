using System;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Infra.Data.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace BRT.HRT.Colaboradores.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiposSkillsController : ControllerBase
    {
        private ITipoSkillRepository _tipoSkillRepository { get; set; }
        public TiposSkillsController()
        {
            _tipoSkillRepository = new TipoSkillRepository();
        }
        
        [HttpGet]
        public IActionResult ListarTiposSkill()
        {
            try
            {
                return Ok(_tipoSkillRepository.ListarTipoSkill());
            }
            catch (Exception ex)
            {

                return BadRequest(new { Erro = ex.ToString() });
            }
        }
    }
}