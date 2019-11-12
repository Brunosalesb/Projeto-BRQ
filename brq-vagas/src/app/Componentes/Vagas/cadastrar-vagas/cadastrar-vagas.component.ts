import { Component, OnInit } from '@angular/core';
import {Base} from '../Model/vagas.model';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';
import { Router } from '../../../../../node_modules/@angular/router';

@Component({
  selector: 'app-cadastrar-vagas',
  templateUrl: './cadastrar-vagas.component.html',
  styleUrls: ['./cadastrar-vagas.component.css']
})
export class CadastrarVagasComponent implements OnInit {

  vaga: Base = {
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

  sucesso=false;
  erro=false;
  lista:Array<any>;
  constructor(private api:Services,private router:Router) { }

  ngOnInit() {
  }

  cadastrarVaga(form){
    const url = `${this.api.APIVagas()}`;
    const response = o(url)
    .post('',this.vaga)
    .query()
    alert("Vaga cadastrada com sucesso!")
    this.router.navigate([`/vagas/listar/`])
  }

}
