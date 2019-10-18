using System;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.ISkill;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.TipoSkill;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace BRQ.HRT.Colaboradores.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoSkillsController : ControllerBase
    {
        private readonly ITipoSkillService _mapperTipoSkill;

        public TipoSkillsController(ITipoSkillService mapperTipoSkill)
        {
            _mapperTipoSkill = mapperTipoSkill;
        }

        //metodo para listar os tipos de skill existentes
        [EnableQuery]
        [HttpGet]
        public IActionResult ListarTipoSkills()
        {
            try
            {
                return Ok(_mapperTipoSkill.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }
        
        //metodo para cadastrar o tipo da skill
        [EnableQuery]
        [HttpPost]
        public IActionResult CadastrarTipoSkill(CadastroTipoSkillViewModel tipoSkill)
        {
            try
            {
                _mapperTipoSkill.Add(tipoSkill);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(new { Erro = ex.ToString() });
            }
        }


    }
}
