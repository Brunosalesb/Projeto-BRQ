import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Experiencias,Base } from '../Model/experiencias.model';

import { o } from 'odata';
import { Services } from 'src/app/ApiService';
import * as jwt from 'jwt-decode';
import { ListarExperienciaPorIdComponent } from '../listar-experiencia-por-id/listar-experiencia-por-id.component';
@Component({
  selector: 'app-editar-experiencias',
  templateUrl: './editar-experiencias.component.html',
  styleUrls: ['./editar-experiencias.component.css']
})
export class EditarExperienciasComponent implements OnInit {
  lista:Experiencias;
  listaTipo:Array<any>;
  sucess=false;
  idpessoa:string;
  idExperiencia:string;
  titulo:string;
  request:Base={
    id:'',
    titulo:"", 
    instituicao:"", 
    descricao:"", 
    dataInicio:"", 
    dataFim:"",
    tipoExperiencia:"", 
    pessoa: this.decode(),
  }
  constructor(private api:Services,private route:ActivatedRoute,private exp:ListarExperienciaPorIdComponent) { }

  ngOnInit() {
    this.exp.mandarID.subscribe(id=>console.log(id))

     this.listar();
  }
  Atualizar(form){
    console.log(form.value);
    let id = localStorage.getItem('idExp');
    const url = `${this.api.APIExperiencia()}/${id}`;
    const response = o(url)
    .put('',this.request)
    .query()
    .then(any=>this.sucess=true)
    .catch(err=>console.log(err))
    console.log(this.request);
  }
  listar(){
    // this.exp.mandarID.subscribe(id=>{this.idExperiencia=id, console.log("AQUI    "+this.idExperiencia)})
   let id = localStorage.getItem('idExp');
    const url = `${this.api.APIExperiencia()}/${id}`;
    const response = o(url)
    .get()
    .query()
    .then(data=>{this.lista=data,console.log(this.lista)})
    console.log(url);
    this.listarTipo();
  }
  decode(){
    let token = localStorage.getItem('token');
    let decode = jwt(token)
    if (token!==null) {
      
      decode.jti == this.idpessoa;
    }
    return decode.jti;
  }
  listarTipo(){
    const url = `${this.api.APITipoExperiencia()}`;
    const response = o(url)
    .get()
    .query()
    .then(data=>this.listaTipo=data)
    .catch(err=>console.log(err))
  }
  }