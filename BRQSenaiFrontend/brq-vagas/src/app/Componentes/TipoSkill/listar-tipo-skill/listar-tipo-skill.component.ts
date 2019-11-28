import { Component, OnInit, OnChanges } from '@angular/core';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';
import { Tipo } from '../Model/tiposkill.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-listar-tipo-skill',
  templateUrl: './listar-tipo-skill.component.html',
  styleUrls: ['./listar-tipo-skill.component.css']
})
export class ListarTipoSkillComponent implements OnInit {
  
  lista:Array<any>;
  request:Tipo={
    nome:"",
    id:''
  }
  constructor(private api:Services,private toastr:ToastrService) { }

  ngOnInit() {
    this.listar();
  }
 
  listar(){
    const url = `${this.api.APITipoSkill()}`;
    const response = o(url)
    .get()
    .query()
    .then(data=>{this.lista=data})
    .catch()
    
  }
  
  deletar(id:number){
    const url = `${this.api.APITipoSkill()}/${id}`;
    const response = o(url)
    .delete()
    .query()
    .then(d=>{this.toastr.warning("","Tipo Skill Deletada")})
    .catch(err=>this.toastr.error('',"Erro ao Deletar Tipo Skill"))
    this.listar();
  }
  cadastrar(form){
    
    const url = `${this.api.APITipoSkill()}`
    const response = o(url)
    .post('',this.request)
    .query()
    .then(data=>{this.lista.sort(),this.toastr.success(this.request.nome,"Tipo Skill Cadastrada")})
    .catch(err=>this.toastr.error("","Erro ao cadastrar Tipo Skill"))
    this.listar();
  }

}

