using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Servicos.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BRT.HRT.Colaboradores.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        public SkillsController()
        {
        }

        private ISkillRepository _skillRepository;

        
        [HttpGet]
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

        [HttpGet]
       public IActionResult BuscarSkillPorID(int id)
        {
            try
            {
                var skillExiste = _skillRepository.BuscarSkillPorID(id);

                if (skillExiste == null)
                    return NotFound(new { mensagem = "A skill não foi encontrada" });

                return Ok(_skillRepository.BuscarSkillPorID(id));
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult EditarSkill(Skill skill)
        {
            try
            {
                Skill alterarSkill = new Skill()
                {
                    IdSkill = skill.IdSkill,
                    IdTipoSkill = skill.IdTipoSkill,
                    NomeSkill = skill.NomeSkill
                };

                _skillRepository.EditarSkill(alterarSkill);

                return Ok(alterarSkill);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarSkill(int id)
        {
            try
            {
                var skillExiste = _skillRepository.BuscarSkillPorID(id);

                if (skillExiste == null)
                    return NotFound(new { mensagem = "A skill não foi encontrada" });

                _skillRepository.DeletarSkill(id);

                return Ok(new { mensagem = "A skill foi deletada"});
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult CadastrarSkill(Skill skill)
        {
            Skill skillNova = new Skill()
            {
                IdTipoSkill = skill.IdTipoSkill,
                NomeSkill = skill.NomeSkill
            };

            _skillRepository.CadastrarSkill(skillNova);

            return Ok(skillNova);
        }





        private ITipoSkillRepository _tipoSkillRepository;

        [HttpGet]
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

        [HttpPut]
        public IActionResult EditarTipoSKill(TipoSkill tipoSkill)
        {
            try
            {
                TipoSkill alterarSkill = new TipoSkill()
                {
                    IdTipoSkill = tipoSkill.IdTipoSkill,
                    NomeTipoSkill = tipoSkill.NomeTipoSkill
                };

                _tipoSkillRepository.EditarTipoSKill(alterarSkill);

                return Ok(alterarSkill);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPost("aaa")]
        public IActionResult CadastrarTipoSKill(TipoSkill tipoSkill)
        {
            try
            {
                TipoSkill tipoSkillNova = new TipoSkill()
                {
                    NomeTipoSkill = tipoSkill.NomeTipoSkill
                };

                _tipoSkillRepository.CadastrarTipoSKill(tipoSkillNova);

                return Ok(tipoSkill);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}