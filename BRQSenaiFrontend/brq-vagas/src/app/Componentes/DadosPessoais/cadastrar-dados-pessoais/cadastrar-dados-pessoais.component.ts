import { Component, OnInit } from '@angular/core';
import { DadosService } from 'src/app/Services/DadosPessoais/dados.service';
import { Dados } from '../Model/dadospessoais.model';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { CepService } from 'src/app/Services/DadosPessoais/Cep.service';

import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-cadastrar-dados-pessoais',
  templateUrl: './cadastrar-dados-pessoais.component.html',
  styleUrls: ['./cadastrar-dados-pessoais.component.css']
})
export class CadastrarDadosPessoaisComponent{
  title = 'Cadastro de dados Pessoais';
  formDadosPessoais: FormGroup;
  submitted = false;

  showSpinner = false;

  response: Dados;

  constructor(private dadosService: DadosService, private formBuilder: FormBuilder, private cepService: CepService, private toastr: ToastrService) {

    this.formDadosPessoais = this.formBuilder.group({
      matricula: ['', Validators.compose([
        Validators.required
      ])],
      nome:  ['', Validators.compose([
          Validators.required
        ])],
      cpf: ['', Validators.compose([
        Validators.required
      ])],
      rg : ['', Validators.compose([
        Validators.required
      ])],
      dataNascimento : ['', Validators.compose([
        Validators.required
      ])],
      cep : ['', Validators.compose([
        Validators.required
      ])],
      logradouro : ['', Validators.compose([
        Validators.required
      ])],
      numero : ['', Validators.compose([
        Validators.required
      ])],
      bairro : ['', Validators.compose([
        Validators.required
      ])],
      localidade : ['', Validators.compose([
        Validators.required
      ])],
      estado : ['', Validators.compose([
        Validators.required,
        Validators.minLength(2),

      ])]
      
    });
  }

  get form() { return this.formDadosPessoais.controls; }

  loading() {
    this.showSpinner = true
    setTimeout(() => {
      this.showSpinner = false;
    }, 3)
  }

  buscarCep(){
    const formValue = this.formDadosPessoais.value;

    if(formValue.cep.length  === 8){
      this.cepService.buscar(formValue.cep).subscribe((cep) => {
        console.log(cep);
        this.formDadosPessoais.patchValue({
          
          localidade: cep.localidade,
          logradouro: cep.logradouro,
          bairro: cep.bairro,
          estado: cep.estado,
          
        });
      });
    }
  }

  limparCampos(){
    this.formDadosPessoais.patchValue({
          
          nome : '',
          localidade: '',
          logradouro: '',
          matricula: '',
          numero: '',
          rg: '',
          cpf: '',
          dataNascimento: '',
          cep: '', 
          bairro: '',
          estado: ''
          
      
    });
  }

  onSubmit() {
    this.submitted = true;

    if (this.formDadosPessoais.invalid) {
      return;
    }
    
     let dados =  {

      "nome" : this.formDadosPessoais.value.nome,
      "localidade" : this.formDadosPessoais.value.localidade,
      "logradouro" : this.formDadosPessoais.value.logradouro,
      "matricula" :  this.formDadosPessoais.value.matricula,
      "numero" : this.formDadosPessoais.value.numero,
      "rg" : this.formDadosPessoais.value.rg,
      "cpf" : this.formDadosPessoais.value.cpf,
      "dataNascimento" : this.formDadosPessoais.value.dataNascimento,
      "cep" : this.formDadosPessoais.value.cep, 
      "bairro" : this.formDadosPessoais.value.bairro,
      "estado" : this.formDadosPessoais.value.estado

    }
  

    this.loading()
    this.dadosService.Cadastrar(dados).subscribe(res => {
      this.response = res;
      alert("Cadastro feito com sucesso.");
      history.go(0); //Atualiza a página.
    }, error => {
      console.log(error);
      alert('TENTE NOVAMENTE. VOCÊ DIGITOU UM CPF, Nº DE MATRÍCULA E/OU RG QUE JÁ EXISTEM NO SISTEMA.')
    });

    // this.toastr.success('Dados Pessoais', 'Cadastro Efetuado com sucesso!', {
    //   timeOut: 20000,
    //   tapToDismiss: true,
    // }).onTap;   //A mensagem aparece mesmo quando, por exemplo, já tem um CPF cadastrado no sistema
    
  }

}