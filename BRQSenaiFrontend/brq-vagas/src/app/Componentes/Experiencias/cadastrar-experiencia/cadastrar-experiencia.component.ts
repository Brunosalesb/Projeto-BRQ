import { Component, OnInit } from '@angular/core';
import { Experiencias } from '../Model/experiencias.model';
import { ExperienciasService } from 'src/app/Services/Experiencias/experiencias.service';
import { MatDialogRef } from '@angular/material/dialog';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';
import * as jwt from 'jwt-decode';
import { ToastrService } from 'ngx-toastr';
@Component({
  selector: 'app-cadastrar-experiencia',
  templateUrl: './cadastrar-experiencia.component.html',
  styleUrls: ['./cadastrar-experiencia.component.css']
})
export class CadastrarExperienciaComponent implements OnInit {
  idpessoa: number;
  lista: Array<any>;
  token:String = localStorage.getItem('token');
  sucess: boolean = false;
  request: Experiencias = {
  
    titulo: "",
    instituicao: "",
    descricao: "",
    dtInicio: "",
    dtFim: "",
    idTipoExperiencia: Number(),
    idPessoa: this.decode(),
  }
  // response:Experiencias;
  constructor(private api: Services, private dialogref: MatDialogRef<CadastrarExperienciaComponent>,private toastr:ToastrService) { }

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
    let token = localStorage.getItem('token');
    const url = `${this.api.APIExperiencia()}`;
    
    const response = o(url,{ headers:new Headers( {
      'Authorization': "bearer "+ this.token,
      'Content-Type' : 'application/json'
  })})
      .post('', this.request)
      .query()
      .then(data => {this.toastr.success(this.request.titulo,"Experiência Cadastrada"),this.resetarForm(form)})
      .catch(e=>{this.toastr.error("Preencha   todos os campos corretamente","Erro ao Cadastrar Experiência")})
      
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

      decode.IdPessoa == this.idpessoa;
    }
    return decode.IdPessoa;
  }


}
