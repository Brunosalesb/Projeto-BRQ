import { Component, OnInit } from '@angular/core';
import {RequestVaga} from '../Model/vagas.model';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';

@Component({
  selector: 'app-cadastrar-vagas',
  templateUrl: './cadastrar-vagas.component.html',
  styleUrls: ['./cadastrar-vagas.component.css']
})
export class CadastrarVagasComponent implements OnInit {

  vaga: RequestVaga = {
    titulo: "",
    dtPublicacao: "",
    localidade: "",
    horario: "",
    dtInicio: "",
    dtFim: "",
    empresa: ""
  }

  sucesso=false;
  erro=false;
  lista:Array<any>;
  constructor(private api:Services) { }

  ngOnInit() {
  }

  cadastrarVaga(form){
    const url = `${this.api.APIVagas()}`;
    const response = o(url)
    .post('',this.vaga)
    .query()
    .then(data=>{console.log(data),this.sucesso=true})
    .catch(err=>{console.log(err),this.erro=true})
    console.log(form.value);
  }

}
