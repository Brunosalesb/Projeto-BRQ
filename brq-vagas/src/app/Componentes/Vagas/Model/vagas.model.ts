export interface Base{
    titulo: "",
    empresa: "",
    TipoVinculo: "",
    localidade: "",
    descricao: "",
    requisito: "",
    beneficio: "",
    horario: "",
    salario: "",
    telefone: "",
    email:"",
    dtPublicacao: ""
}

export interface RequestEditar extends Base{

}

export interface RequestVaga extends Base{

}