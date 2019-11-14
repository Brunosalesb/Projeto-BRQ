export interface Base{
    nomeContato:string;
    idTipoContato:string;
    idPessoa:string;
}


export interface Contatos extends Base{
    id:string;  
}

export interface CriarContatos extends Base{
    id:string;
}

export interface ResponseAtualizar extends Base{
    
}

export interface RequestAtualizar extends Base{
  
}