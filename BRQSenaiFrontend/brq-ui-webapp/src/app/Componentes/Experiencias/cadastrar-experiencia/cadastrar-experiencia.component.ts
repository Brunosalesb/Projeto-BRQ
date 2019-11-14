import { Component, OnInit } from '@angular/core';
import { Experiencias } from '../Model/experiencias.model';
import { ExperienciasService } from 'src/app/Services/Experiencias/experiencias.service';
import { MatDialogRef } from '@angular/material/dialog';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';
import * as jwt from 'jwt-decode';
@Component({
  selector: 'app-cadastrar-experiencia',
  templateUrl: './cadastrar-experiencia.component.html',
  styleUrls: ['./cadastrar-experiencia.component.css']
})
export class CadastrarExperienciaComponent implements OnInit {
  idpessoa: number;
  lista: Array<any>;
  sucess: boolean = false;
  request: Experiencias = {
    id: "",
    titulo: "",
    instituicao: "",
    descricao: "",
    dataInicio: "",
    dataFim: "",
    tipoExperiencia: "",
    pessoa: this.decode(),
  }
  // response:Experiencias;
  constructor(private api: Services, private dialogref: MatDialogRef<CadastrarExperienciaComponent>) { }

  ngOnInit() {
    this.listarTipo();
    this.decode();
  }
  listarTipo() {
    const url = `${this.api.APITipoExperiencia()}`;
    const response = o(url)
      .get()
      .query()
      .then(data => this.lista = data)
      .catch()
  }
  CadastrarExperiencias(form) {
    const url = `${this.api.APIExperiencia()}`;
    const response = o(url)
      .post('', this.request)
      .query()
      .then(data => {this.sucess = true,this.resetarForm(form)})
      .catch()
  }
  resetarForm(formulario) {
    formulario.form.patchValue({
      dataFim: "",
      dataInicio: "",
      descricao: "",
      instituicao: "",
      tipoExperiencia: "",
      titulo: ""
    })
  }
  close() {
    this.dialogref.close();
  }
  decode() {
    let token = localStorage.getItem('token');
    let decode = jwt(token)
    if (token !== null) {

      decode.jti == this.idpessoa;
    }
    return decode.jti;
  }


}
