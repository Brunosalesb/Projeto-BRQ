import { Component, OnInit } from '@angular/core';
import { CriarHabilidades, Habilidades, Base } from '../Model/habilidades.model';
import { HabilidadesService } from 'src/app/Services/Habilidades/habilidades.service';
import { MatDialogRef } from '@angular/material/dialog';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';
import * as jwt from 'jwt-decode';

@Component({
  selector: 'app-cadastrar-habilidades',
  templateUrl: './cadastrar-habilidades.component.html',
  styleUrls: ['./cadastrar-habilidades.component.css']
})
export class CadastrarHabilidadesComponent implements OnInit {
  lista: Array<any>;
  request: Base = {
  
    fkIdPessoa:this.decode(),
    fkIdSkill: ""
  }
  sucess:boolean=false;
  id: string;
  response: Habilidades;
  route: any;
  constructor(private habilidadesService: HabilidadesService,
    private api: Services
    , private dialogRef: MatDialogRef<CadastrarHabilidadesComponent>) { }

  ngOnInit() {
    this.listar();
    this.decode();
  }
 
  decode(){
    let token = localStorage.getItem('token');
    let decode = jwt(token);
     if (token!==null) 
      
    return decode.jti;
  }
  async listar() {
  
    const response = o(this.api.APISkill())
    .get()
    .query()
    .then(data=>{this.lista=data,console.log(this.lista)})

  }
  CadastrarHabilidades(form) {
    const url = `${this.api.APIPessoas()}/atribuirSkill`
    const response = o(url)
    .post('',this.request)
    .query()
    .then(data=>this.sucess=true)
    .catch(err=>console.log(err))
    console.log(form.value);
  }
  close() {
    this.dialogRef.close();

  }
}
