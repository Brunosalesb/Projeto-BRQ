using BRQ.HRT.Colaboradores.Aplicacao.Interfaces;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.Experiencia;
using BRQ.HRT.Colaboradores.Aplicacao.Services;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Experiencia;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRQ.HRT.Colaboradores.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienciasController : ControllerBase
    {
        private readonly IExperienciaRepository _experienciaRepository;
        private readonly IPessoaRepository _pessoaRepository;

        private readonly ICadastroExperienciaService _mapperCadExp;
        private readonly IExperienciaService _mapperExp;

        public ExperienciasController(IExperienciaRepository experienciaRepository, IPessoaRepository pessoaRepository, ICadastroExperienciaService mapperCadExp, IExperienciaService mapperExp)
        {
            _experienciaRepository = experienciaRepository;
            _pessoaRepository = pessoaRepository;
            _mapperCadExp = mapperCadExp;
            _mapperExp = mapperExp;
        }

        [EnableQuery]
        [HttpGet("")]
        public IActionResult ListarTodasExp()
        {
            try
            {
                return Ok(_mapperExp.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        [EnableQuery]
        [HttpGet("{id}")]
        public IActionResult BuscarPorID(int id)
        {
            try
            {
                Experiencia ExpBuscada = _experienciaRepository.GetById(id);
                if (ExpBuscada == null)
                {
                    return NotFound(new { Mensagem = $"Experiência não encontrada!" });
                }

                return Ok(_mapperExp.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        [EnableQuery()]
        [HttpGet("usuario/{id}")]
        public IActionResult BuscarTodasPorIdPessoa(int id)
        {
            try
            {
                Pessoa PessoaBuscada = _pessoaRepository.GetById(id);
                if (PessoaBuscada == null)
                {
                    return NotFound(new { Mensagem = $"Pessoa do ID: {id}, não foi encontrada!" });
                }
                return Ok(_mapperExp.GetAll(id));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        [HttpPost("cadastrar")]
        public IActionResult CadastrarExp(CadastroExperienciaViewModel exp)
        {
            try
            {
                _mapperCadExp.Add(exp);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        [HttpPut ("{id}")]
        public IActionResult AtualizarExp(int id, ExperienciaViewModel xp)
        {
            try
            {
                Experiencia expBuscada = _experienciaRepository.GetById(id);
                if (expBuscada == null)
                {
                    NotFound(new { Mensagem = $"Experiência não encontrada!" });
                }
                _mapperExp.Update(id.ToString(), xp);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarExp (int id)
        {
            try
            {
                Experiencia ExpBuscada = _experienciaRepository.GetById(id);
                if(ExpBuscada == null)
                {
                    return NotFound(new { Mensagem = $"Experiência não encontrada!" });
                }

                _experienciaRepository.Remove(id);
                return Ok(new { Mensagem = $"Experiência deletada com sucesso!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }
    }
}
