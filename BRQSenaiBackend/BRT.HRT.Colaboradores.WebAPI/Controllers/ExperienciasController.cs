﻿using BRQ.HRT.Colaboradores.Aplicacao.Interfaces;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Experiencia;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BRQ.HRT.Colaboradores.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienciasController : ControllerBase
    {
        private readonly ITipoExperienciaRepository _tipoExpRepository;
        private readonly IExperienciaRepository _experienciaRepository;
        private readonly IPessoaRepository _pessoaRepository;

        private readonly IExperienciaService _mapperExp;

        public ExperienciasController(IExperienciaRepository experienciaRepository, IPessoaRepository pessoaRepository, IExperienciaService mapperExp, ITipoExperienciaRepository tipoExpRepository)
        {
            _tipoExpRepository = tipoExpRepository;
            _experienciaRepository = experienciaRepository;
            _pessoaRepository = pessoaRepository;
            _mapperExp = mapperExp;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult ListarTodas()
        {
            try
            {
                return Ok(_mapperExp.ListarTodasExperiencias());
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
                Experiencia expBuscada = _experienciaRepository.GetById(id);

                if (expBuscada == null)
                {
                    return NotFound(new { Mensagem = $"Experiência não encontrada!" });
                }
                return Ok(_mapperExp.BuscarExperienciaPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        [EnableQuery()]
        [HttpGet("usuario/{id}")]
        public IActionResult BuscarTodasPorIDPessoa(int id)
        {
            try
            {
                Pessoa pessoaBuscada = _pessoaRepository.GetById(id);

                if (pessoaBuscada == null)
                {
                    return NotFound(new { Mensagem = $"Pessoa não encontrada!" });
                }
                return Ok(_mapperExp.GetAll(id));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        [HttpPost]
        public IActionResult CadastrarExp(CadastroExperienciaViewModel exp)
        {

            try
            {
                TipoExperiencia tipoExpValidacao = _tipoExpRepository.GetById(exp.FkIdTipoExperiencia);
                Pessoa pessoaValidacao = _pessoaRepository.GetById(exp.FkIdPessoa);

                if (tipoExpValidacao == null || pessoaValidacao == null)
                {
                    return NotFound(new { Mensagem = $"Pessoa e/ou tipo de experiência não existe!" });
                }
                _mapperExp.Add(exp);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarExp(int id, CadastroExperienciaViewModel xp)
        {
            try
            {
                TipoExperiencia tipoExpValidacao = _tipoExpRepository.GetById(xp.FkIdTipoExperiencia);
                Pessoa pessoaValidacao = _pessoaRepository.GetById(xp.FkIdPessoa);
                Experiencia expBuscada = _experienciaRepository.GetById(id);


                if (expBuscada == null)
                {
                    return NotFound(new { Mensagem = $"Experiência não encontrada!" });
                }

                if (tipoExpValidacao == null || pessoaValidacao == null)
                {
                    return NotFound(new { Mensagem = $"Pessoa e/ou tipo de experiência não existe!" });
                }
                _mapperExp.Update(xp, expBuscada.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarExp(int id)
        {
            try
            {
                Experiencia ExpBuscada = _experienciaRepository.GetById(id);
                if (ExpBuscada == null)
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
