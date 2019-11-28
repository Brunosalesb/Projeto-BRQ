export interface Base{
    titulo: string,
    empresa: string,
    TipoVinculo: string,
    localidade: string,
    descricao: string,
    requisito: string,
    beneficio: string,
    horario: string,
    salario: string,
    telefone: string,
    email:string,
    dtPublicacao?: string,
}
export interface List {
    titulo: string,
    empresa: string,
    TipoVinculo: string,
    localidade: string,
    descricao: string,
    requisito: string,
    beneficio: string,
    horario: string,
    salario: string,
    telefone: string,
    email:string,
    dtPublicacao:Date;
}