export interface Base {
    
    titulo:string; 
	instituicao:string; 
	descricao:string; 
	dtInicio:string; 
    dtFim:string;
    idTipoExperiencia:Number; 
    idPessoa:Number;
}

export interface Experiencias extends Base{
  
}

export interface Criars extends Base{
    id:string;  
}
