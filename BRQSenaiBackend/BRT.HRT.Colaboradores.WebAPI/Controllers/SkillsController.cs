using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BRQ.HRT.Colaboradores.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillRepository _skillRepository;

        public SkillsController(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
            return Ok(_skillRepository.GetAll());

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
                Skill skillBuscada = _skillRepository.GetById(id);

                if (skillBuscada == null)
                {
                    return NotFound(new { Mensagem = $"A skill {id} não foi encontrada" });
                }

                return Ok(skillBuscada);
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
                Skill skillBuscada = _skillRepository.GetById(id);
                if (skillBuscada == null)
                {
                    return NotFound(new { Mensagem = $"A skill {id} não foi encontrada" });
                }
                _skillRepository.Remove(id);

                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
      
    }
}