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
    public class ExperienciasController : ControllerBase
    {
        private readonly IExperienciaRepository _experienciaRepository;
        private readonly IPessoaRepository _pessoaRepository;

        public ExperienciasController(IExperienciaRepository experienciaRepository, IPessoaRepository pessoaRepository)
        {
            _experienciaRepository = experienciaRepository;
            _pessoaRepository = pessoaRepository;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult ListarTodasExp()
        {
            try
            {
                return Ok(_experienciaRepository.GetAll());
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
                Experiencia ExpBuscada = _experienciaRepository.GetById(id.ToString());
                if (ExpBuscada == null)
                {
                    return NotFound(new { Mensagem = $"Experiência não encontrada!" });
                }

                return Ok(ExpBuscada);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        //[EnableQuery()]
        //[HttpGet("usuario/{id}")]
        //public IActionResult BuscarTodasPorIdPessoa(int id)
        //{
        //    try
        //    {
        //        Pessoa PessoaBuscada = _pessoaRepository.GetById(id.ToString());
        //        if (PessoaBuscada == null)
        //        {
        //            return NotFound(new { Mensagem = $"Pessoa do ID: {id}, não foi encontrada!" });
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}



    }
}
