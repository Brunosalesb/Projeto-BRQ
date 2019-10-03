using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.Skill;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BRQ.HRT.Colaboradores.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ICadastroSkillService _mapperCadSkill;
        private readonly ISkillService _mapperSkill;

        public SkillsController(ICadastroSkillService mapperCadSkill, ISkillService mapperSkill)
        {
            _mapperCadSkill = mapperCadSkill;
            _mapperSkill = mapperSkill;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult ListarSkill()
        {
            try
            {
                return Ok(_mapperSkill.GetAll());
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}