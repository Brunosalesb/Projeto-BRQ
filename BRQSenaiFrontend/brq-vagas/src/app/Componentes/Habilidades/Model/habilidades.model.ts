
export interface Base {
    IdPessoa: string;
    IdSkill: string;
}
export interface Habilidades extends Base {
    idSkillPessoa: string;

}

export interface CriarHabilidades extends Base {
    idSkillPessoa: string;
}
export interface ResponseAtualizar extends Base {

}

export interface RequestAtualizar extends Base {

}
export interface ListaSkillUsuario {
    SkillsDaPessoa: [
       {
           Skill:{
               nome:string;
           }
       }
    ],
}
export interface ListaSkill {
   
        nome: string;
    
}