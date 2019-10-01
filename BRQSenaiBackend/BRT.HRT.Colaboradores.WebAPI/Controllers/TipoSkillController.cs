using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BRQ.HRT.Colaboradores.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoSkillController : ControllerBase
    {
        private readonly ITipoSkillRepository _tipoSkillRepository;

        public TipoSkillController(ITipoSkillRepository tipoSkillRepository)
        {
            _tipoSkillRepository = tipoSkillRepository;
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                return Ok(_tipoSkillRepository.GetAll());

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public IActionResult ListarPorId(string id)
        {
            try
            {
                TipoSkill tipoSkillBuscada = _tipoSkillRepository.GetById(id);

                if (tipoSkillBuscada == null)
                {
                    return NotFound(new { Mensagem = $"O tipo da skill {id} não foi encontrada" });
                }

                return Ok(tipoSkillBuscada);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(string id)
        {
            try
            {
                TipoSkill tipoSkillBuscada = _tipoSkillRepository.GetById(id);
                if (tipoSkillBuscada == null)
                {
                    return NotFound(new { Mensagem = $"O tipo da skill {id} não foi encontrada" });
                }
                _tipoSkillRepository.Remove(id);

                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

    }
}