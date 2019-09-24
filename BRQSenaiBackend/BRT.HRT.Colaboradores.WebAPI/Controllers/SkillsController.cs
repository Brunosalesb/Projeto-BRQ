using System;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Infra.Data.Repositorios;
using BRQ.HRT.Colaboradores.Servicos.ViewModel;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace BRT.HRT.Colaboradores.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private ISkillRepository _skillRepository;

        public SkillsController()
        {
            _skillRepository = new SkillRepository();
        }


        //Skill

        [EnableQuery()]
        [HttpGet("Listar")]
        public IActionResult ListarTodasSkills()
        {
            try
            {
                return Ok(_skillRepository.ListarTodasSkills());
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        [EnableQuery()]
        [HttpGet("BuscarPorId/{id}")]
        public IActionResult BuscarSkillPorID(int id)
        {
            try
            {
                Skill skillBuscada = _skillRepository.BuscarSkillPorID(id);

                if (skillBuscada == null)
                    return NotFound(new { Mensagem = $"A skill {id} não foi encontrada" });

                return Ok(skillBuscada);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        [HttpPut("Editar/{id}")]
        public IActionResult EditarSkill(int id, Skill skill)
        {
            try
            {
                Skill skillBuscada = _skillRepository.BuscarSkillPorID(id);
                if (skillBuscada == null)
                    return NotFound(new { mensagem = $"A skill {id} não foi encontrada" });
                skillBuscada = skill;
                _skillRepository.EditarSkill(skillBuscada);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        [HttpDelete("Deletar/{id}")]
        public IActionResult DeletarSkill(int id)
        {
            try
            {
                Skill skillBuscada = _skillRepository.BuscarSkillPorID(id);

                if (skillBuscada == null)
                    return NotFound(new { mensagem = $"A skill {id} não foi encontrada" });

                _skillRepository.DeletarSkill(id);

                return Ok(new { mensagem = "A skill foi deletada" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        [HttpPost("Cadastrar")]
        public IActionResult CadastrarSkill(SkillViewModel skill)
        {
            try
            {
                _skillRepository.CadastrarSkill(skill);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }
    }
}