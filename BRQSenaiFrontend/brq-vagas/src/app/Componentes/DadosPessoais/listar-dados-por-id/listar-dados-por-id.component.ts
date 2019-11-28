import { Component, OnInit } from '@angular/core';
import { DadosService } from 'src/app/Services/DadosPessoais/dados.service';
import { Dados, Base } from '../Model/dadospessoais.model';
import { ActivatedRoute } from '@angular/router';
import { o } from 'odata'
import { Services } from "../../../ApiService";
import * as jwt from 'jwt-decode';

import { CadastrarContatosComponent } from 'src/app/Componentes/Contatos/cadastrar-contatos/cadastrar-contatos.component';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { RequestAtualizar } from '../../Habilidades/Model/habilidades.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-listar-dados-por-id',
  templateUrl: './listar-dados-por-id.component.html',
  styleUrls: ['./listar-dados-por-id.component.css']
})
export class ListarDadosPorIdComponent implements OnInit {

  constructor(private toastr:ToastrService,
     private route: ActivatedRoute, private api: Services, private dialog: MatDialog) { }
  lista: Dados;
  id: string;
  permissao: boolean;
  idPessoa: string;
  ListaEditar: Base;
  ativo=true;
  ngOnInit() {
    this.VerificaPerfil();
    this.listar();

  }

  VerificaPerfil() {
    let token = localStorage.getItem('token')
    let decode = jwt(token)

    this.idPessoa = this.route.snapshot.paramMap.get('id')
    if (decode.IdPessoa == this.idPessoa) {
      this.permissao = true;
    } else {
      this.permissao = false;
    }
    return this.permissao;
  }

  async listar() {
    this.id = this.route.snapshot.paramMap.get('id');
    const url = await `${this.api.API()}/${this.id}`;
    const response = o(url)
      .get()
      .query()
      .then(data => {
        this.lista = data
      })
      .catch(err => console.log(err))
  }

  //O método abaixo serve para os contatos
  openDialogContato(): void {
    const dialogRef = this.dialog.open(CadastrarContatosComponent);

    dialogRef.afterClosed().subscribe(result => {
      this.listar();
    });

  }
  MudarMetodo() {
    this.ativo=!this.ativo;
  }
  Editar() {
    this.id = this.route.snapshot.paramMap.get('id');
    const url = `${this.api.APIPessoas()}/${this.id}`;
    o(url)
      .put("", this.ListaEditar)
      .query()
      .then(a=>this.toastr.success("","Dados Pessoais Editado"))
      .catch(e=>this.toastr.error("","Erro ao Editar Dados Pessoais"))

  }
  

}
