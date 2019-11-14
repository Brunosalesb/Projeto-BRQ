
export interface Base {
   fkIdPessoa:string;
    fkIdSkill:string;
}
export interface Habilidades extends Base{
    idSkillPessoa:string;  
    
}

export interface CriarHabilidades extends Base{
    idSkillPessoa:string;  
}
export interface ResponseAtualizar extends Base{
    
}

export interface RequestAtualizar extends Base{
    
}