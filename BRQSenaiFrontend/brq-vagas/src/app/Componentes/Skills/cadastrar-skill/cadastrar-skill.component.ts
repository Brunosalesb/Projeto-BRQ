import { Component, OnInit } from '@angular/core';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';
import { RequestSkill } from '../Model/skills.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-cadastrar-skill',
  templateUrl: './cadastrar-skill.component.html',
  styleUrls: ['./cadastrar-skill.component.css']
})
export class CadastrarSkillComponent implements OnInit {
  skill:RequestSkill={
   nome:"",
   fkIdTipoSkill:"",
    
  }
  sucesso=false;
  erro=false;
  lista:Array<any>;
  constructor(private api:Services,private toastr:ToastrService) { }

  ngOnInit() {
    this.listar();
  }
  cadastrar(form){
    const url = `${this.api.APISkill()}`;
    const response = o(url)
    .post('',this.skill)
    .query()
    .then(data=>{this.toastr.success(this.skill.nome,"Skill Cadastrada")})
    .catch(err=>{this.toastr.error("","Erro ao Cadastrar Skill")})
 
  }
  listar(){
    const url = `${this.api.APITipoSkill()}`
    const response = o(url)
    .get()
    .query()
    .then(data=>this.lista=data)
    .catch();
  }
}
