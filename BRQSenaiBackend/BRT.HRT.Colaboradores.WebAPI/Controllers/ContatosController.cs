using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMContato;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BRQ.HRT.Colaboradores.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ContatosController : ControllerBase
    {
        private readonly IContatoRepository _contatoRepository;
        private readonly IContatoService _mapper;

        public ContatosController(IContatoRepository contatoRepository, IContatoService mapper)
        {
            _contatoRepository = contatoRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult InserirContato(ContatoCadastroViewModel obj)
        {
            try
            {
                _mapper.Add(obj);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { erro = ex.Message});
            }
        }
        

        [HttpGet]
        public IActionResult Getall()
        {
            try
            {
                return Ok(_contatoRepository.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(new { erro = ex.Message});
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                Contato contBuscado = _contatoRepository.GetById(id);
                if (contBuscado == null)
                {
                    return NotFound(new { Mensagem = $"Contato não encontrado!" });
                }
                _contatoRepository.Remove(id);
                return Ok(new { Mensagem = $"Contato deletado com sucesso!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ContatoCadastroViewModel ct)
        {
            try
            {
                Contato ctBuscado = _contatoRepository.GetById(id);

                if (ctBuscado == null)
                {
                    return NotFound(new { Mensagem = $"Contato não encontrado!" });
                }
                _mapper.Update(ct, ctBuscado.Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }
    }
}