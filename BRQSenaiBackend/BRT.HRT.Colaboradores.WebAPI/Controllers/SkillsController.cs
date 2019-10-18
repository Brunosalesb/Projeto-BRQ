using System;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Skill;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace BRQ.HRT.Colaboradores.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillService _mapperSkill;
        private readonly ISkillRepository _skillRepository;
        private readonly IPessoaRepository _pessoaRepository;


        public SkillsController(ISkillService mapperSkill, ISkillRepository skillRepository, IPessoaRepository pessoaRepository)
        {
            _mapperSkill = mapperSkill;
            _skillRepository = skillRepository;
            _pessoaRepository = pessoaRepository;
        }

        //metodo para listar as skills existentes
        [EnableQuery]
        [HttpGet]
        public IActionResult ListarSkills()
        {
            try
            {
                return Ok(_mapperSkill.GetAll());
            }
            catch (Exception ex)
            {

                return BadRequest(new{ Erro = ex.ToString()});
            }
        }

        //metodo para listar uma skill pelo id
        [EnableQuery]
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                //busca a skill pelo id e verifica se ela é encontrada
                Skill skillBuscada = _skillRepository.GetById(id);
                if (skillBuscada == null)
                {
                    return NotFound(new { Mensagem = $"Não foi possível encontrar a skill {id}" });
                }

                return Ok(_mapperSkill.GetById(id));
            }
            catch (Exception ex)
            {

                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        //metodo para listar todas as skill de um usuario passando o id do usuario
        [EnableQuery]
        [HttpGet("usuario/{id}")]
        public IActionResult ListarTodasPorIdPessoa(int id)
        {
            try
            {
                //busca a pessoa pelo id e verifica se ela é encontrada
                Pessoa pessoaBuscada = _pessoaRepository.GetById(id);
                if (pessoaBuscada == null)
                {
                    return NotFound(new { Mensagem = $"A pessoa com id: {id} não foi encontrada!" });
                }
                return Ok(_mapperSkill.GetAll(id));
            }
            catch (Exception ex)
            {

                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        //metodo para cadastrar uma skill
        [EnableQuery]
        [HttpPost]
        public IActionResult CadastrarSkill(CadastroSkillViewModel skill)
        {
            try
            {
                _mapperSkill.Add(skill);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        //metodo para editar uma skill existente
        [EnableQuery]
        [HttpPut("{id}")]
        public IActionResult EditarSkill(int id, CadastroSkillViewModel skill)
        {
            try
            {
                //busca a skill pelo id e verifica se ela é encontrada
                Skill skillBuscada = _skillRepository.GetById(id);
                if (skillBuscada == null)
                {
                    return NotFound(new { Mensagem = $"Não foi possível encontrar a skill {id}" });
                }
                _mapperSkill.Update(skill, skillBuscada.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        //metodo para deletar uma skill existente
        [EnableQuery]
        [HttpDelete]
        public IActionResult DeletarSkill(int id)
        {
            try
            {
                _skillRepository.Remove(id);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(new { Erro = ex.ToString() });
            }
        }
    }
}