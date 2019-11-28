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
import { ToastrService } from 'ngx-toastr';
@Component({
  selector: 'app-listar-habilidades-por-id',
  templateUrl: './listar-habilidades-por-id.component.html',
  styleUrls: ['./listar-habilidades-por-id.component.css']
})
export class ListarHabilidadesPorIdComponent implements OnInit {

  constructor(private service: HabilidadesService, private route: ActivatedRoute,
     private dialog: MatDialog,private api:Services,private toastr:ToastrService ) { }
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
      this.listarSkill();
    });

  }
  mensagem = "Você não tem nehuma skill Cadastrada"
  ngOnInit() {
    this.VerificaPerfil();
    this.listarSkill();
  }
 
  listarSkill(){
    this.idSkillPessoa = this.route.snapshot.paramMap.get('id');
    const url =  `${this.api.API()}/${this.idSkillPessoa}`;
    const response =  o(url)
    .get()
    .query()
    .then(data => { this.lista = data })
    .catch()
  }
 
  VerificaPerfil(){
    let token = localStorage.getItem('token')
    let decode = jwt(token)

    this.idPessoa = this.route.snapshot.paramMap.get('id')
    if (decode.IdPessoa==this.idPessoa) {
      this.permissao= true;
    }else{
      this.permissao=false;
    }
    return this.permissao;


  }
  desatribuirSkill(id:number){
    const url = `${this.api.APIPessoas()}/desatribuirskill/${id}`;
    const response = o(url)
    .delete()
    .query()
    .then(d=>this.toastr.warning("","Skill Deletada"))
    .catch(err=>{console.log(err),this.toastr.error("","Erro ao deletar Skill")})
    this.listarSkill();

  }
 
 
}