using System;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Infra.Data.Repositorios;
using BRQ.HRT.Colaboradores.Servicos.ViewModel;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BRT.HRT.Colaboradores.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienciasController : ControllerBase
    {
        private IExperienciaRepository _ExperienciaRepository { get; set; }
        private IPessoaRepository _PessoaRepository { get; set; }

        public ExperienciasController()
        {
            _ExperienciaRepository = new ExperienciaRepository();
            _PessoaRepository = new PessoaRepository();

        }
        [Authorize]
        [HttpPost("Cadastrar")]
        public IActionResult CadastrarExp(ExperienciaViewModel exp)
        {
            try
            {
                _ExperienciaRepository.CadastrarExperiencia(exp);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }
        [Authorize]
        [EnableQuery()]
        [HttpGet]
        public IActionResult ListarTodasExp()
        {
            try
            {
                return Ok(_ExperienciaRepository.ListarTodasExperiencias());
            }
            catch (Exception ex)
            {
                return BadRequest(new { Errp = ex.ToString() });
            }
        }
        [EnableQuery()]
        [HttpGet("{id}")]
        public IActionResult BuscarPorID(int id)
        {
            try
            {
                Experiencia ExpBuscada = _ExperienciaRepository.BuscarExperienciaPorID(id);
                if (ExpBuscada == null)
                {
                    return NotFound(new { Mensagem = $"Experiencia que possui id: {id}, nao foi encontrada" });
                }
                return Ok(ExpBuscada);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }
        [EnableQuery()]
        [Authorize]
        [HttpGet("Usuario/{id}")]
        public IActionResult BuscarTodasPeloIdPessoa(int id)
        {
            try
            {
                Pessoa PessoaBuscada = _PessoaRepository.BuscarPessoaPorID(id);
                if (PessoaBuscada == null)
                {
                    return NotFound(new { Mensagem = $"Pessoa do ID: {id}, nao foi encontrado" });
                }
                return Ok(_ExperienciaRepository.ListarExperienciasPorIdPessoa(id));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult AtualizarExperiencia(int id, Experiencia xp)
        {
            try
            {
                Experiencia expBuscada = _ExperienciaRepository.BuscarExperienciaPorID(id);
                if (expBuscada == null)
                {
                    NotFound(new { Mensagem = $"Experiencia de ID: {id}, nao foi encontrado" });
                }
                
                _ExperienciaRepository.AtualizarExperiencia(id,xp);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }
        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult DeletarExp (int id)
        {
            try
            {
                Experiencia ExperienciaBuscada = _ExperienciaRepository.BuscarExperienciaPorID(id);
                if(ExperienciaBuscada == null)
                {
                    return NotFound(new { Mensagem = $"Experiência não encontrada!" });
                }

                _ExperienciaRepository.DeletarExperiencia(id);
                return Ok(new { Mensagem = $"Experiência deletada com sucesso!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }
    }
}