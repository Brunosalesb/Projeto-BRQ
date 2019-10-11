using System;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.ISkill;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.TipoSkill;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace BRQ.HRT.Colaboradores.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoSkillsController : ControllerBase
    {
        private readonly ITipoSkillService _mapperTipoSkill;


        public TipoSkillsController(ITipoSkillService mapperTipoSkill)
        {
            _mapperTipoSkill = mapperTipoSkill;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult ListarTipoSkills()
        {
            try
            {
                return Ok(_mapperTipoSkill.GetAll());
            }
            catch (Exception ex)
            {

                return BadRequest(new { Erro = ex.ToString() });
            }
        }
                  
        [EnableQuery]
        [HttpPost]
        public IActionResult CadastrarTipoSkill(CadastroTipoSkillViewModel tipoSkill)
        {
            try
            {
                _mapperTipoSkill.Add(tipoSkill);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(new { Erro = ex.ToString() });
            }
        }

        //[EnableQuery]
        //[HttpGet("{id}")]
        //public IActionResult BuscarPorId(int id)
        //{
        //    try
        //    {
        //        TipoSkill tipoSkillBuscada = _tipoSkillRepository.GetById(id);
        //        if (tipoSkillBuscada == null)
        //        {
        //            return NotFound(new { Mensagem = $"O tipo skill com id {id} não foi encontrada" });
        //        }

        //        return Ok(_tipoSkillRepository.GetById(id));
        //    }
        //    catch (Exception)
        //    {

        //        return BadRequest();
        //    }
        //}
        
        //[EnableQuery]
        //[HttpDelete("id")]
        //public IActionResult DeletarTipoSkill(int id)
        //{
        //    try
        //    {
        //        TipoSkill tipoSkillBuscada = _tipoSkillRepository.GetById(id);
        //        if (tipoSkillBuscada == null)
        //        {
        //            return NotFound(new { Mensagem = $"A skill {id} não foi encontrada" });
        //        }

        //        _tipoSkillRepository.Remove(id);
        //        return Ok();
        //    }
        //    catch (Exception)
        //    {

        //        return BadRequest();
        //    }
        //}

        //[EnableQuery]
        //[HttpPut("{id}")]
        //public IActionResult EditarTipoSkill(int id, TipoSkillViewModel tipoSkill)
        //{
        //    try
        //    {
        //        TipoSkill tipoSkillBuscada = _tipoSkillRepository.GetById(id);
        //        if (tipoSkillBuscada == null)
        //        {
        //            NotFound(new { Mensagem = $"Tipo skill não foi encontrada" });
        //        }
        //        _mapperTipoSkill.Update(tipoSkill);
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new { Erro = ex.ToString() });
        //    }
        //}

    }
}
