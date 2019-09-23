using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Servicos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BRQ.HRT.Colaboradores.Infra.Data.Repositorios
{
    class SkillRepository : ISkillRepository
    {
        public Skill BuscarSkillPorID(int id)
        {
            try
            {
                using (ContextoColaboradores ctx = new ContextoColaboradores())
                {
                    return ctx.Skill.Find(id);
                }
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public void CadastrarSkill(Skill skill)
        {
            try
            {
                using (ContextoColaboradores ctx = new ContextoColaboradores())
                {
                    ctx.Skill.Add(skill);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public void DeletarSkill(int id)
        {
            try
            {
                using (ContextoColaboradores ctx = new ContextoColaboradores())
                {
                    Skill skillBuscada = BuscarSkillPorID(id);
                    ctx.Skill.Remove(skillBuscada);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public void EditarSkill(Skill skill)
        {
            try
            {
                using (ContextoColaboradores ctx = new ContextoColaboradores())
                {
                    ctx.Entry<Skill>(skill).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public List<Skill> ListarTodasSkills()
        {
            try
            {
                using (ContextoColaboradores ctx = new ContextoColaboradores())
                {
                    return ctx.Skill.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
