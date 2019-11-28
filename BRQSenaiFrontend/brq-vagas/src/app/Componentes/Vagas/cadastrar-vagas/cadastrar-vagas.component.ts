import { Component, OnInit } from '@angular/core';
import { Base } from '../Model/vagas.model';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';
import { Router } from '../../../../../node_modules/@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-cadastrar-vagas',
  templateUrl: './cadastrar-vagas.component.html',
  styleUrls: ['./cadastrar-vagas.component.css']
})
export class CadastrarVagasComponent implements OnInit {
  lista: Array<any>;
  vaga: Base = {
    titulo: "",
    empresa: "",
    TipoVinculo: "",
    localidade: "",
    descricao: "",
    requisito: "",
    beneficio: "",
    horario: "",
    salario: "",
    telefone: "",
    email: "",
    dtPublicacao: new Date(Date.now()).toLocaleDateString()
  }

  sucesso = false;
  erro = false;
  constructor(private api: Services, private router: Router, private toastr: ToastrService) { }

  ngOnInit() {
    
    this.listarSkill();
  }
  resetarForm(formulario) {
    formulario.form.patchValue({
      titulo: null,
      empresa: null,
      TipoVinculo: null,
      localidade: null,
      descricao: null,
      requisito: null,
      beneficio: null,
      horario: null,
      salario: null,
      telefone: null,
      email: null,
    })
  }
  cadastrarVaga(form) {
  
    const url = `${this.api.APIVagas()}`;
    const response = o(url)
      .post('', this.vaga)
      .query()
      .then(data => {this.toastr.success(this.vaga.titulo, "Vaga Cadastrada"),this.resetarForm(form)})
    
   
  }
  listarSkill() {
    const url = `${this.api.APISkill()}`;
    const response = o(url)
      .get()
      .query()
      .then(data => this.lista = data)
  }
  

}
