using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BRQ.HRT.Colaboradores.Infra.Data.Repositorios
{
    class TipoSkillRepository : ITipoSkillRepository
    {
        public void CadastrarTipoSKill(TipoSkill tipoSkill)
        {
            try
            {
                using (ContextoColaboradores ctx = new ContextoColaboradores())
                {
                    ctx.TipoSkill.Add(tipoSkill);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public void EditarTipoSKill(TipoSkill tipoSkill)
        {
            try
            {
                using (ContextoColaboradores ctx = new ContextoColaboradores())
                {
                    ctx.Entry<TipoSkill>(tipoSkill).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public List<TipoSkill> ListarTipoSkill()
        {
            try
            {
                using (ContextoColaboradores ctx = new ContextoColaboradores())
                {
                    return ctx.TipoSkill.ToList();
                }
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
    }
}
