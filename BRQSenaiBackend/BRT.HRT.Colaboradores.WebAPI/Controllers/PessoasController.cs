using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Infra.Data.Repositorios;
using BRQ.HRT.Colaboradores.Servicos.ViewModel;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace BRT.HRT.Colaboradores.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private IPessoaRepository _PessoaRepository { get; set; }

        public PessoasController()
        {
            _PessoaRepository = new PessoaRepository();
        }

        /// <summary>
        /// Endpoint responsavel por Gerar um token que deve ser utilizado 
        /// para identificar qual usuario esta realizando as acoes no sistema
        /// </summary>
        /// <param name="matricula">Matricula da pessoa que estara utilizando o sistema</param>
        /// <returns>Token jwt com informacoes do matriculado </returns>
        [HttpPost("Matricula/{matricula}")]
        public IActionResult TrazerDados(int matricula)
        {
            try
            {
                Pessoa PessoaBuscada = _PessoaRepository.BuscarPessoaPorMatricula(matricula);
                if (PessoaBuscada == null)
                {
                    return NotFound();
                }
                var claims = new List<Claim>()
                {
                    new Claim(JwtRegisteredClaimNames.Jti, PessoaBuscada.Id.ToString()),
                    new Claim("Matricula", PessoaBuscada.Matricula.ToString())
                };
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("LrKP-xFl7-NayO-Xd9b"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "Colaboradores.WebApi",
                    audience: "Colaboradores.WebApi",
                    claims: claims,
                    expires: DateTime.Now.AddHours(5),
                    signingCredentials: creds);

                return Ok(new
                { token = "bearer " + new JwtSecurityTokenHandler().WriteToken(token) }
                );
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Endpoint Responsavel por requisitar uma lista de dados 
        /// com todas as pessoas do sistema.
        /// </summary>
        /// <returns>Lista com todas pessoas.</returns>
        [HttpGet]
        [EnableQuery()]

        public IActionResult GetAll()
        {
            try
            {
                return Ok(_PessoaRepository.ListarTodasPessoas());
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }
        /// <summary>
        /// Endpoint responsavel por Requistar dados uma Pessoa em especifica no sistema.
        /// </summary>
        /// <param name="id">Id da Pessoa</param>
        /// <returns>Dados da pessoa</returns>
        [HttpGet("{id}")]
        [EnableQuery()]
        public IActionResult GetByid(int id)
        {
            try
            {
                Pessoa PessoaBuscada = _PessoaRepository.BuscarPessoaPorID(id);
                if (PessoaBuscada == null)
                {
                    return NotFound( new { Mensagem = $"Pessoa que possui id: {id}, nao pode ser encontrada"});
                }

                return Ok(PessoaBuscada);
            }
            catch (Exception ex)
            {

                return BadRequest(new { Erro = ex.ToString() });
            }
        }
        /// <summary>
        ///  Endpoint responsavel por gerar uma pessoa no sistema.
        /// </summary>
        /// <param name="dadosPessoa">Dados Da pessoa a ser Cadastrada</param>
        /// <returns>Codigo de Resposta Http</returns>
        [HttpPost("Cadastrar")]
        public IActionResult Cadastrar(PessoaViewModel dadosPessoa)
        {
            try
            {
                _PessoaRepository.CadastrarPessoa(dadosPessoa);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }
        /// <summary>
        /// Endpoint responsavel por Alterar dados uma Pessoa em especifica no sistema.
        /// </summary>
        /// <param name="dadosPessoa">Dados da pessoa</param>
        /// <param name="id">id que deve ser editado</param>
        /// <returns>Codigo de Resposta Http</returns>
        [HttpPut("{id}")]
        public IActionResult Editar(Pessoa dadosPessoa, int id)
        {
            try
            {
                Pessoa PessoaBuscada = _PessoaRepository.BuscarPessoaPorID(id);
                if (PessoaBuscada == null)
                {
                    return NotFound(new { Mensagem = $"Pessoa que possui id: {id}, nao pode ser encontrada" });
                }
                _PessoaRepository.EditarPessoa(PessoaBuscada);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }
        /// <summary>
        /// Endpoint responsavel por Deletar dados uma Pessoa em especifica no sistema.
        /// </summary>
        /// <param name="id">id que deve ser Deletado</param>
        ///<returns>Codigo de Resposta Http</returns>
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                Pessoa PessoaBuscada = _PessoaRepository.BuscarPessoaPorID(id);
                if (PessoaBuscada == null)
                {
                    return NotFound(new { Mensagem = $"Pessoa que possui id: {id}, nao pode ser encontrada" });
                }

                _PessoaRepository.ExcluirPessoa(id);
                return Ok(new { Mensagem = $"Pessoa que possui id: {id} foi deletada com sucesso!" });

            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }
        /// <summary>
        /// Endpoint responsavel por Atribuir uma Skill a determinada Pessoa no sistema.
        /// </summary>
        /// <param name="dadosSkill">Dados como id do skill a ser atribuido e id do usuario</param>
        /// <returns>Codigo de Resposta Http</returns>
        [Authorize]
        [HttpPost("Skills/Atribuir")]
        public IActionResult AdicionarSkill(SkillPessoaViewModel dadosSkill)
        {
            try
            {
                _PessoaRepository.AtribuirSKill(dadosSkill);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }
        /// <summary>
        /// Endpoint responsavel por Desatribuir uma Skill a determinada Pessoa no sistema.
        /// </summary>
        /// <param name="dadosSkill">Dados como id do skill a ser desatribuido e id do usuario</param>
        /// <returns>Codigo de Resposta Http</returns>
        [Authorize]
        [HttpDelete("Skills/Desatribuir")]
        public IActionResult RemoverSkill(SkillsPessoa dadosSkill)
        {
            try
            {
                _PessoaRepository.DesAtribuirSkill(dadosSkill);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(new { Erro = ex.ToString() });
            }
        }
    }
}