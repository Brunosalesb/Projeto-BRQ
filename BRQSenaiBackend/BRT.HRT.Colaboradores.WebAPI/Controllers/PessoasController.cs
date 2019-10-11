using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.IPessoa;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.Pessoa;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Pessoa;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace BRQ.HRT.Colaboradores.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private ICadastroPessoaService _CadastroPessoaMapper;
        private IPessoaContatoService _pessoaContatoMapper;
        private IPessoaRepository _pessoaRepository;
        private IPessoaService _pessoaMapper;

        public PessoasController(ICadastroPessoaService CadastroPessoaMapper, IPessoaContatoService pessoaMapper, IPessoaRepository pessoaRepository, IPessoaService pessoaService)
        {
            _CadastroPessoaMapper = CadastroPessoaMapper;
            _pessoaContatoMapper = pessoaMapper;
            _pessoaRepository = pessoaRepository;
            _pessoaMapper = pessoaService;
        }

        [HttpPost]
        public IActionResult Post(CadastroPessoaViewModel pessoa)
        {
            try
            {
                _CadastroPessoaMapper.Add(pessoa);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
        [EnableQuery]
        [HttpGet("todosDados")]
        public IActionResult GetallContato()
        {
            try
            {
                return Ok(_pessoaContatoMapper.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
        [EnableQuery]
        [HttpGet]
        public IActionResult Getall()
        {
            try
            {
                return Ok(_pessoaMapper.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
        [EnableQuery]
        [HttpGet("todosDados/{id}")]
        public IActionResult GetAllById(int id)
        {
            try
            {
                Dominio.Entidades.Pessoa p = _pessoaRepository.GetById(id);
                if (p == null)
                {
                    return NotFound(new { Mensagem = $"Pessoa que possui id: {id}, nao pode ser encontrada" });
                }
                return Ok(_pessoaContatoMapper.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.Message });
            }
        }
        [EnableQuery]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                Dominio.Entidades.Pessoa p = _pessoaRepository.GetById(id);
                if (p == null)
                {
                    return NotFound(new { Mensagem = $"Pessoa que possui id: {id}, nao pode ser encontrada" });
                }
                return Ok(_pessoaMapper.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.Message });
            }
        }
        [HttpPut]
        public IActionResult Edit(CadastroPessoaViewModel p)
        {
            try
            {
                int id = Int32.Parse(HttpContext.User.Claims.First(x => x.Type == JwtRegisteredClaimNames.Jti).Value);

                Dominio.Entidades.Pessoa PessoaBuscada = _pessoaRepository.GetById(id);
                if (PessoaBuscada == null)
                {
                    return NotFound(new { Mensagem = $"Pessoa que possui id: {id}, nao pode ser encontrada" });
                }
                _CadastroPessoaMapper.Update(p);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.Message });
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Del(int id)
        {
            try
            {
                _pessoaRepository.Remove(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

    }
}