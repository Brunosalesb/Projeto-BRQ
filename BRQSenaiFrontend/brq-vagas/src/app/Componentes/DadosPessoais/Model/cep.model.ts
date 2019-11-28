export class Cep {

    constructor(

        localidade: string,
        logradouro: string,
        cep: string,
        bairro: string,
        estado: string){
            this.localidade = localidade;
            this.logradouro = logradouro;
            this.cep = cep;
            this.bairro = bairro;
            this.estado = estado;

        }
        
        localidade: string;
        logradouro: string;
        cep: string;
        bairro: string;
        estado: string;
}


