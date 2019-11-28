import { Component, OnInit } from '@angular/core';
import { CriarHabilidades, Habilidades, Base, ListaSkill, ListaSkillUsuario } from '../Model/habilidades.model';
import { HabilidadesService } from 'src/app/Services/Habilidades/habilidades.service';
import { MatDialogRef } from '@angular/material/dialog';
import { Services } from 'src/app/ApiService';
import { o,OdataBatchConfig } from 'odata';
import * as jwt from 'jwt-decode';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-cadastrar-habilidades',
  templateUrl: './cadastrar-habilidades.component.html',
  styleUrls: ['./cadastrar-habilidades.component.css']
})
export class CadastrarHabilidadesComponent implements OnInit {
  lista: Array<any>;
  listaUsuario: ListaSkillUsuario;
  request: Base = {
    IdPessoa: this.decode(),
    IdSkill: "  "
  }
  sucess: boolean = false;
  id: string;

  constructor(private api: Services,private dialogRef: MatDialogRef<CadastrarHabilidadesComponent>, private toastr: ToastrService) { }

  ngOnInit() {
    this.listar();
    this.decode();
    // this.verificaLista();

  }

  decode() {
    let token = localStorage.getItem('token');
    let decode = jwt(token);
    if (token !== null)

      return decode.IdPessoa;
  }
  async listar() {

    let arr2 = [];
    let arr1 = [];
    let token = localStorage.getItem('token');
    let decode = jwt(token);
    const id = decode.IdPessoa
    const url = `${this.api.API()}/${id}`;
    o(url)
      .get()
      .query()
      .then(data => {
        this.listaUsuario = data

        for (let index = 0; index < this.listaUsuario.SkillsDaPessoa.length; index++) {
          const element = this.listaUsuario.SkillsDaPessoa[index];

          arr2.push(element.Skill)

        }
      })

    ///////////////////////
    o(this.api.APISkill())
      .get()
      .query()
      .then(data => {
        this.lista = data
        
    let apenasR1 = this.lista.filter(element=>{
      if(arr2.indexOf(element.nome)==-1)
      return element;
    })
    let apenasR2 = arr2.filter(element=>{
      if(this.lista.indexOf(element.nome)==-1)
      return element;
    })
    let diferencas = apenasR1.concat(apenasR2)
 
        
      })
       
  
  }

  CadastrarHabilidades(form) {
    let token = localStorage.getItem('token');
    const url = `${this.api.APIPessoas()}/atribuirSkill`;
    const config = { headers:new Headers( {
      'Content-Type' : 'application/json',
      'Authorization': "bearer "+token
  })}
    const response = o(url,config.headers)
      .post('', this.request)
      .query()
      .then(data => this.toastr.success("Skill Cadastrada"))
      .catch(err => {this.toastr.error("", "Erro ao cadastrar Habilidade")})
    
  }

  // verificaLista(){

  //   let arr1 = [];
  //   let arr2 = [];
  //   let arr= this.lista.forEach(e=>{
  //      const ele = e;
  //      console.log(ele); 
  //    }) 

  //   for (let index = 0; index < this.listaUsuario.length; index++) {
  //     const element = this.listaUsuario[index];
  //     arr2.push(element[index])
  //   }
  //   let apenasR1 = arr1.filter(element=>{
  //     if(arr2.indexOf(element)==-1)
  //     return element;
  //   })
  //   let apenasR2 = arr2.filter(element=>{
  //     if(arr1.indexOf(element)==-1)
  //     return element;
  //   })
  //   let diferencas = apenasR1.concat(apenasR2)
  //   console.log(arr);
  // }
}
