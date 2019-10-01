use brq_senai;

select * from tipoSkill
insert into tipoSkill
values ('Skill Técnica'),('Skill Comportamental')

select * from skill
insert into skill
values ('Java',2),('Boa comunicação')

select * from tipoExperiencia
insert into tipoExperiencia
values ('Interno'),('Externo'),('Formação')

select * from pessoa
insert into pessoa
values ('12345','Natália Marina Luna Peixoto','530.113.276-88','26.530.986-4','1979-07-12','(11)99396-6636','nataliapeixoto@gmail.com','58705-560','Rua Robério Vieira de Medeiros','589',null,'Jardim Magnólia','Patos','PB')
,('43212','Otávio Oliveira','076.695.458-79','46.442.395-8','1999-02-22','(11)93226-1846','otaviooliveira@outlook.com.br','09131-020','Rua Champolion','324',null,'Vila Suíça','Santo André','SP')

select * from experiencia
insert into experiencia
values ('Desenvolvedor Java','BRQ Digital Solutions','Atuação na manutenção de funcionalidades existentes e no desenvolvimento de novas, utilizando 
Java','2019-04-17','2019-08-22',2,2)

select * from skills_pessoa
insert into skills_pessoa
values(2,1)

select * from pessoa
select * from skills_pessoa
select * from skill
select * from tipoSkill
select * from experiencia
select * from tipoExperiencia