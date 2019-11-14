import { Component, OnInit, OnChanges } from '@angular/core';
import { DadosService } from 'src/app/Services/DadosPessoais/dados.service';
import { HttpClient } from '@angular/common/http';
import { o } from "odata";
import { ActivatedRoute, Router } from '@angular/router';
import { HabilidadesService } from 'src/app/Services/Habilidades/habilidades.service';
import { SkillService } from 'src/app/Services/Skills/skill.service';
import { Services } from "../../../ApiService";
import { BuscarUsuario } from '../Model/dadospessoais.model';
@Component({
  selector: 'app-listar-todos',
  templateUrl: './listar-todos.component.html',
  styleUrls: ['./listar-todos.component.css']
})
export class ListarTodosComponent implements OnInit {
  
  filtro: string ='';
  quantidade: number;
  erro:boolean=false;
  ativo = true;
  ListaBool:boolean=true;
  lista: Array<any>;
  showSpinner=false;
  mostrarPagina:boolean;
  habilidadesprocuradas: string = '';
  listahabilidades: Array<any>;
  listas:BuscarUsuario={
    skillPessoa: [
      {
          Pessoa: {
              nome:'',
              matricula:''
          }
      }
  ]
  }
  skipNull=true;
  constructor(

    private service: DadosService, private http: HttpClient, private route: ActivatedRoute, private serviceskill: SkillService,private api:Services) {

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
      
        this.erro=true;
        this.mostrarPagina=false
        
      }else{
        this.mostrarPagina=true
        this.erro=false
      }
    
    })
    .catch(err=>console.log(err))
  
  }
  skip:number=0;
  listarComFiltro() {
    this.mostrarPagina=false;
    this.ListaBool=false;
    this.skip=0;
    this.loading()
    const url = `${this.api.APISkill()}?$filter=contains(nome,'${this.filtro}')`;
    const response = o(url)
    .get()
    .query()
    .then(data => {
      
      this.listas = data,
      // this.quantidade=this.lista.length;
      
      this.erro=false
    })
    .catch(err=>{this.erro=true})

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
    if (form.value.filtro=='') {
      this.filtro==undefined;
    }
    
    this.skip = this.skip-this.skip;
    this.listarComFiltro();

  }

  resetarForm(formulario) {
    formulario.form.patchValue({
     filtro:""

    });
  }

  listarHabilidades() {
    // this.serviceskill.ListarTodas().subscribe(res => { this.listahabilidades = res, this.quantidade = res.length });
    const url = `${this.api.APISkill()}`;
    const response = o(url)
    .get()
    .query()
    .then(res=>{this.listahabilidades=res})
    .catch(err=>console.log(err))
  }


  mandarHabilidadeParaFiltro(value: string,form) {
    this.resetarForm(form);
    this.habilidadesprocuradas += value;

  }



}