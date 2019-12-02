export interface Base {
    nome: string;
    pais:string;
    logradouro: string;
    matricula: string;
    numeroEndereco: string;
    rg: string;
    cpf: string;
    cep: string;
    bairro: string;
    estado: string;
    email: string;
    senha: string;
    complemento: string;
}


export interface Dados extends Base {
    id: string;
}

export interface CriarDados extends Base {
    id: string;
}

export interface ResponseAtualizar extends Base {

}

export interface RequestAtualizar extends Base {

}

export interface ListaNome {
    nome: string;
}
export interface RequestLogin {
   email:string;
   senha:string;
}
export interface ResponseLogin extends RequestLogin {
}
export interface BuscarUsuario {
    skillPessoa: [
        {
            Pessoa: {
                nome:string,
                matricula:string
            }
        }
    ]
}