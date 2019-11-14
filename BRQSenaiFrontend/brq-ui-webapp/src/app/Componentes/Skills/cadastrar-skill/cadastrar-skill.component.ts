import { Component, OnInit } from '@angular/core';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';
import { RequestSkill } from '../Model/skills.model';

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
  constructor(private api:Services) { }

  ngOnInit() {
    this.listar();
  }
  cadastrar(form){
    const url = `${this.api.APISkill()}`;
    const response = o(url)
    .post('',this.skill)
    .query()
    .then(data=>{console.log(data),this.sucesso=true,this.erro=false})
    .catch(err=>{console.log(err),this.erro=true,this.sucesso=false})
    console.log(form.value);
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
