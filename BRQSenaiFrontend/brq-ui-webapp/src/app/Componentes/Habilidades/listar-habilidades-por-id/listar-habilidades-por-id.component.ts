import { Component, OnInit } from '@angular/core';
import { HabilidadesService } from 'src/app/Services/Habilidades/habilidades.service';
import { Habilidades } from '../Model/habilidades.model';
import { ActivatedRoute } from '@angular/router';
import { CadastrarHabilidadesComponent } from '../cadastrar-habilidades/cadastrar-habilidades.component';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
// import { AddDeleteSkillComponent } from 'src/app/Uteis/add-delete-skill/add-delete-skill.component';
import { catchError } from '../../../../../node_modules/rxjs/operators';
import { o } from 'odata';
import { Services } from 'src/app/ApiService';
import * as jwt from 'jwt-decode';
@Component({
  selector: 'app-listar-habilidades-por-id',
  templateUrl: './listar-habilidades-por-id.component.html',
  styleUrls: ['./listar-habilidades-por-id.component.css']
})
export class ListarHabilidadesPorIdComponent implements OnInit {

  constructor(private service: HabilidadesService, private route: ActivatedRoute,
     private dialog: MatDialog,private api:Services ) { }
  listaSkill: Array<any>;
  permissao:boolean;
  idSkillPessoa: string;
  idPessoa:string;
  listaVazia = true;
  quantidade:number;
  ativo = true;
  NumeroSkill: number;
  id: string;
  lista:Array<any>;
  top:number=2;

  ativoDelete = false;
  openDialog(): void {
    this.ativo = !this.ativo;
 
   
    const dialogRef = this.dialog.open(CadastrarHabilidadesComponent);

    dialogRef.afterClosed().subscribe(result => {
      this.listar();
    });

  }
  mensagem = "Você não tem nehuma skill Cadastrada"
  ngOnInit() {
    this.listar();
    this.VerificaPerfil();
    this.listarSkill();
  }
  async listar() {
     this.idSkillPessoa = this.route.snapshot.paramMap.get('id');
      const url = await `${this.api.APISkill()}/usuario/${this.idSkillPessoa}?$top=${this.top}`;
      const response =  o(url)
      .get()
      .query()
      .then(data => { this.listaSkill = data,console.log(this.listaSkill) })
      .catch(err=>console.log(err))

  }
  listarSkill(){
    this.idSkillPessoa = this.route.snapshot.paramMap.get('id');
    const url =  `${this.api.API()}/${this.idSkillPessoa}`;
    const response =  o(url)
    .get()
    .query()
    .then(data => { this.lista = data,console.log(this.lista) })
    .catch(err=>console.log(err))
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
  desatribuirSkill(id:number){
    const url = `${this.api.APIPessoas()}/desatribuirskill/${id}`;
    const response = o(url)
    .delete()
    .query()
    .then()
    .catch(err=>console.log(err))
    this.listar();
  }
  verTodas(){
    this.top = this.top +this.top;
    this.listar();
  }
 
}