create database brq_senai;
use brq_senai;

create table tipoSkill(
	idTipoSkill int identity primary key,
	nomeTipoSkill varchar(255) unique not null
);

create table skill(
	idSkill int identity primary key,
	nomeSkill varchar(255) unique not null,
	fk_idTipoSkill int foreign key references tipoSkill (idTipoSkill) not null
);

create table pessoa(
	idPessoa int identity primary key,
	matriculaPessoa int unique not null,
	nomePessoa varchar(255) not null,
	cpfPessoa varchar(20) unique not null,
	rgPessoa varchar(20) not null,
	dtNascPessoa date not null,
	telefonePessoa varchar(20) not null,
	emailPessoa varchar(100) unique not null,
	cepPessoa varchar(20) not null,
	logradouroPessoa varchar(255) not null,
	numeroPessoa int not null,
	complementoPessoa varchar(255),
	bairroPessoa varchar(255) not null,
	localidadePessoa varchar(255) not null,
	estadoPessoa varchar(255) not null
);

create table tipoExperiencia(
	idTipoExperiencia int identity primary key,
	nomeTipoExperiencia varchar(255) unique not null
);

create table experiencia(	
	idExperiencia int identity primary key,
	tituloExperiencia varchar(255) not null,
	instituicaoExperiencia varchar(255) not null,
	descricaoExperiencia text,
	dtInicioExperiencia date not null,
	dtFimExperiencia date not null,
	fk_idTipoExperiencia int foreign key references tipoExperiencia (idTipoExperiencia) not null,
	fk_idPessoa int foreign key references pessoa (idPessoa) not null,
);
	
create table skills_pessoa(
	idSkillPessoa int identity primary key,
	fk_idPessoa int foreign key references pessoa (idPessoa) not null,
	fk_idSkill int foreign key references skill (idSkill) not null
);
