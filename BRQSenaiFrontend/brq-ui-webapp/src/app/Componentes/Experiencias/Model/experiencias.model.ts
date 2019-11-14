export interface Base {
    id:string;
    titulo:string; 
	instituicao:string; 
	descricao:string; 
	dataInicio:string; 
    dataFim:string;
    tipoExperiencia:string; 
    pessoa:string;
}

export interface Experiencias extends Base{
  
}

export interface Criars extends Base{
    id:string;  
}
