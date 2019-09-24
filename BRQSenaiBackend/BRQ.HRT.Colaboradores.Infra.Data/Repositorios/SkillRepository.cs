using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Servicos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRQ.HRT.Colaboradores.Infra.Data.Repositorios
{
    public class SkillRepository : ISkillRepository
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
        public void CadastrarSkill(SkillViewModel skill)
        {
            Skill s = new Skill() {
                IdTipoSkill = skill.IdTipoSkill,
                NomeSkill = skill.NomeSkill
            };
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                ctx.Skill.Add(s);
                ctx.SaveChanges();
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
                    ctx.Skill.Update(skill);
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
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                return ctx.Skill.ToList();
            }
        }
    }
}
