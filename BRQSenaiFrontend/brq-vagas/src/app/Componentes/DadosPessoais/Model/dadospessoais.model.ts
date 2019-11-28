export interface Base {
    nome: string;
    localidade: string;
    logradouro: string;
    matricula: string;
    numero: string;
    rg: string;
    cpf: string;
    dtnasc: string;
    cep: string;
    bairro: string;
    estado: string;
    // complemento: "",
    //pais: "",  estão no back, mas não no formulário
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