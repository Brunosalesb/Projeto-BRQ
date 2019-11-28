import { Component, OnInit, OnChanges } from '@angular/core';
import { DadosService } from 'src/app/Services/DadosPessoais/dados.service';
import { HttpClient } from '@angular/common/http';
import { o } from "odata";
import { ActivatedRoute, Router } from '@angular/router';
import { HabilidadesService } from 'src/app/Services/Habilidades/habilidades.service';
import { SkillService } from 'src/app/Services/Skills/skill.service';
import { Services } from "../../../ApiService";
import { BuscarUsuario } from '../Model/dadospessoais.model';
import { ToastrService } from 'ngx-toastr';
@Component({
  selector: 'app-listar-todos',
  templateUrl: './listar-todos.component.html',
  styleUrls: ['./listar-todos.component.css']
})
export class ListarTodosComponent implements OnInit {
  
  filtro: string ='';
  quantidade: number;
 
  ListaBool:boolean=true;
  lista: Array<any>;
  showSpinner=false;
  mostrarPagina:boolean;
  habilidadesprocuradas: string = '';
  listahabilidades: Array<any>;
  listas:Array<any>;
  
  constructor(private api:Services,private toastr:ToastrService) {
  }
  ngOnInit() {
   
    this.listarHabilidades();
  }
  loading(){
    this.showSpinner=true
    setTimeout(()=>{
      this.showSpinner=false;
    },1000)
  }
  listarTodos(){
    this.ListaBool=true;

    this.loading()
     
    const url = `${this.api.APIPessoas()}?$select=nome,matricula,id&$skip=${this.skip}&$top=10`;
    o(url)
    .get()
    .query()
    .then(data=>{
      this.lista=data

      if (this.quantidade==0) {  
        this.mostrarPagina=false
      }else{
        this.mostrarPagina=true
       
        
      }
    
    })
    .catch()
    this.verificabotao();
  
  }
  skip:number=0;
  listarComFiltro() {
    this.mostrarPagina=false;
    this.ListaBool=false;
    this.skip=0;
    this.loading()
    const url = `${this.api.APISkill()}?$filter=contains(titulo,'${this.filtro}')`;
    const response = o(url)
    .get()
    .query()
    .then(data => {this.listas = data})
    .catch(e=>{
      console.log(e)
    this.toastr.error(":(","Nenhum Colaborador Encontrado")})
    this.filtro==null;
 }
  aumentarPagina(){
    
    this.skip = this.skip+ 10;
  
    this.listarTodos();
  }
  diminuirPagina(){
    this.skip = this.skip-10;
    this.listarTodos();
  }
  mandarParaRota(form) {
    this.filtro = form.value.filtro;
   
    
    this.skip = this.skip-this.skip;
    this.listarComFiltro();

  }
  resetarForm(formulario) {
    formulario.form.patchValue({
      filtro:''
    })
    
  }
  listarHabilidades() {
    const url = `${this.api.APISkill()}`;
    const response = o(url)
    .get()
    .query()
    .then(res=>{this.listahabilidades=res})
    .catch()
  }
  mandarHabilidadeParaFiltro(value: string,form) {
    this.resetarForm(form);
    this.habilidadesprocuradas += value;
  }
  
  disableBotaoAnt:boolean=true;
  disableBotaoProx:boolean=true;
  verificabotao(){
    if (this.skip>0) {
      this.disableBotaoAnt=false;
    }
    else{
      this.disableBotaoAnt=true;
    }
  }
}