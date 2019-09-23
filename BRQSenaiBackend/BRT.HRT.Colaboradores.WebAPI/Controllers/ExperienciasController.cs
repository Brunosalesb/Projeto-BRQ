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
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienciasController : ControllerBase
    {
        private IExperienciaRepository _ExperienciaRepository { get; set; }
        private IPessoaRepository _PessoaRepository { get; set; }

        public ExperienciasController()
        { }
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
    }
}