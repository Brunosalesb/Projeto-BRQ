import { Component, OnInit, EventEmitter } from '@angular/core';
import { ExperienciasService } from 'src/app/Services/Experiencias/experiencias.service';
import { ActivatedRoute } from '@angular/router';
import { Experiencias } from '../Model/experiencias.model';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { EditarExperienciasComponent } from '../editar-experiencias/editar-experiencias.component';
import { CadastrarExperienciaComponent } from '../cadastrar-experiencia/cadastrar-experiencia.component';

import { o } from 'odata';
import { Services } from 'src/app/ApiService';
import * as jwt from 'jwt-decode';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-listar-experiencia-por-id',
  templateUrl: './listar-experiencia-por-id.component.html',
  styleUrls: ['./listar-experiencia-por-id.component.css'],
  
})
export class ListarExperienciaPorIdComponent implements OnInit {
  permissao:boolean;
  idExperiênciaPessoa: string;
  idPessoa:string;
  lista: Experiencias;
  idExperiencia: string;
  mandarID = new EventEmitter<string>();
  // @Input() [EditarExperienciasComponent]= new EventEmitter<string>();
  ativo = true;
  ativoDelete=true;
  ativoDeletado:boolean;
  show = false;
  constructor(private route: ActivatedRoute,
     private dialog: MatDialog,private api:Services,private toastr:ToastrService) { }
  Deletar(id){
    const url = `${this.api.APIExperiencia()}/${id}`;
    const response = o(url)
    .delete()
    .query()
    .then(da=>this.toastr.warning("","Experiência Deletada"))
    .catch(e=>this.toastr.error("","Erro ao Deletar Experiência"))
   this.ativoDeletado = true;
   this.listar();
   
  }
  AbrirDelete(){
    this.ativoDelete=!this.ativoDelete;
  }
  openDialogCadastro(): void {
    this.ativo = !this.ativo;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.width = "60%";
    dialogConfig.height = "60%";

    
    const dialogRef = this.dialog.open(CadastrarExperienciaComponent, dialogConfig);

    dialogRef.afterClosed().subscribe(result => {
      this.listar();  
    });

  }

  ngOnInit() {
   this.listar();
   this.VerificaPerfil();
  }
  async listar(){
    this.idExperiencia = this.route.snapshot.paramMap.get('id');
    const url = await `${this.api.APIExperiencia()}/usuario/${this.idExperiencia}`;
    const response = o(url)
     .get()
     .query()
     .then(data=>{
      this.lista=data;
    
     })
     .catch()
   
  }
  openDialogEditar(id:string) {
    localStorage.setItem('idExp',id);
    
    // this.ativo = !this.ativo;
    
    const dialogConfig = new MatDialogConfig();
    dialogConfig.width = "60%";
    dialogConfig.height = "60%";
    
    
    
    const dialogRef = this.dialog.open(EditarExperienciasComponent, dialogConfig);
    dialogRef.afterClosed().subscribe(result => {
      this.listar();  
    });
    
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
}
