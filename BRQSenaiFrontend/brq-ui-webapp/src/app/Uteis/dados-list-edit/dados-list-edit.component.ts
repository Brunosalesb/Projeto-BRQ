import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import * as jwt from 'jwt-decode';
import { ActivatedRoute } from '@angular/router';
@Component({
  selector: 'app-dados-list-edit',
  templateUrl: './dados-list-edit.component.html',
  styleUrls: ['./dados-list-edit.component.css']
})
export class DadosListEditComponent implements OnInit {
 ativo=true;
 permissao:boolean;
idSkillPessoa: string;
idPessoa:string;
 
  constructor(private route:ActivatedRoute) { }

  ngOnInit() {
  this.VerificaPerfil();
  }
  mudarComponente(){
   this.ativo = !this.ativo;
   
  }
  VerificaPerfil(){
    let token = localStorage.getItem('token')
    let decode = jwt(token)

    this.idPessoa = this.route.snapshot.paramMap.get('id')
    if (decode.jti==this.idPessoa) {
      this.permissao= true;
    }else{
      this.permissao=false;
    }
    console.log("permissao  "+  this.permissao);
    return this.permissao;


  }

}
