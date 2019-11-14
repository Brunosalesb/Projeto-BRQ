import { Component, OnInit } from '@angular/core';
import { DadosService } from 'src/app/Services/DadosPessoais/dados.service';
import { Dados } from '../Model/dadospessoais.model';
import { ActivatedRoute } from '@angular/router';
import { o } from 'odata'
import { Services } from "../../../ApiService";
import * as jwt from 'jwt-decode';

import { CadastrarContatosComponent } from 'src/app/Componentes/Contatos/cadastrar-contatos/cadastrar-contatos.component';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';

@Component({
  selector: 'app-listar-dados-por-id',
  templateUrl: './listar-dados-por-id.component.html',
  styleUrls: ['./listar-dados-por-id.component.css']
})
export class ListarDadosPorIdComponent implements OnInit {

  constructor(private service:DadosService,private route:ActivatedRoute,private api:Services,private dialog: MatDialog) { }
  lista:Dados;
  id:string;
  permissao:boolean;
  idPessoa:string;

  ngOnInit() {
    this.VerificaPerfil();
    this.listar();
   
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
    return this.permissao;
  }

  async listar() {
    this.id = this.route.snapshot.paramMap.get('id');
    const url = await `${this.api.API()}/${this.id}`;
    const response = o(url)
     .get()
     .query()
     .then(data=>{
        this.lista=data
      })
     .catch(err=>console.log(err)) 
 }

 //O método abaixo serve para os contatos
 openDialogContato(): void {
  const dialogRef = this.dialog.open(CadastrarContatosComponent);

  dialogRef.afterClosed().subscribe(result => {
    this.listar();
  });

}
 
}
