using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Infra.Data.Repositorios;
using BRQ.HRT.Colaboradores.Servicos.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BRT.HRT.Colaboradores.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {

        private ISkillRepository _skillRepository;
        private ITipoSkillRepository _tipoSkillRepository;

        public SkillsController()
        {
            _skillRepository = new SkillRepository();
            _tipoSkillRepository = new TipoSkillRepository();
        }


        //Skill


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

        [HttpGet("BuscarPorId/{id}")]
       public IActionResult BuscarSkillPorID(int id)
        {
            try
            {
                Skill skillBuscada = _skillRepository.BuscarSkillPorID(id);

                if (skillBuscada == null)
                    return NotFound(new { mensagem = "A skill não foi encontrada" });

                return Ok(skillBuscada);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPut("Editar")]
        public IActionResult EditarSkill(int id,Skill skill)
        {
            try
            {
                Skill skillBuscada = _skillRepository.BuscarSkillPorID(id);
                if (skillBuscada == null)
                    return NotFound(new { mensagem = "A skill não foi encontrada" });

                _skillRepository.EditarSkill(skill);

                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpDelete("Deletar{id}")]
        public IActionResult DeletarSkill(int id)
        {
            try
            {
                Skill skillBuscada = _skillRepository.BuscarSkillPorID(id);

                if (skillBuscada == null)
                    return NotFound(new { mensagem = "A skill não foi encontrada" });

                _skillRepository.DeletarSkill(id);

                return Ok(new { mensagem = "A skill foi deletada"});
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPost("Cadastrar")]
        public IActionResult CadastrarSkill(Skill skill)
        {
            try
            {
                _skillRepository.CadastrarSkill(skill);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }


        //TipoSkill


        [HttpGet("BuscarTipoSkillPorId/{id}")]
        public IActionResult BuscarTipoSkillPorID(int id)
        {
            try
            {
                TipoSkill tipoSkillBuscada = _tipoSkillRepository.BuscarTipoSkillPorID(id);

                if (tipoSkillBuscada == null)
                    return NotFound(new { mensagem = "A skill não foi encontrada" });

                return Ok(tipoSkillBuscada);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpGet("ListarTipoSkill")]
        public IActionResult ListarTipoSkill()
        {
            try
            {
                return Ok(_tipoSkillRepository.ListarTipoSkill());
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPut("EditarTipoSkill")]
        public IActionResult EditarTipoSKill(int id,TipoSkill tipoSkill)
        {
            try
            {
                TipoSkill tipoSkillBuscada = _tipoSkillRepository.BuscarTipoSkillPorID(id);
                if (tipoSkillBuscada == null)
                    return NotFound(new { mensagem = "A skill não foi encontrada" });

                _tipoSkillRepository.EditarTipoSKill(tipoSkill);

                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPost("CadastrarTipoSkill")]
        public IActionResult CadastrarTipoSKill(TipoSkill tipoSkill)
        {
            try
            {
                _tipoSkillRepository.CadastrarTipoSKill(tipoSkill);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}