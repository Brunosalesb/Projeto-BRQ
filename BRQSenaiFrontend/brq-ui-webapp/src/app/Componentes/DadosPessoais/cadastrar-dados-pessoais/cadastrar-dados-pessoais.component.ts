import { Component, OnInit } from '@angular/core';
import { DadosService } from 'src/app/Services/DadosPessoais/dados.service';
import { CriarDados, Dados } from '../Model/dadospessoais.model';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

import { ContatosService } from 'src/app/Services/Contatos/contatos.service';
import { CriarContatos, Contatos } from 'src/app/Componentes/Contatos/Model/contatos.model';

@Component({
  selector: 'app-cadastrar-dados-pessoais',
  templateUrl: './cadastrar-dados-pessoais.component.html',
  styleUrls: ['./cadastrar-dados-pessoais.component.css']
})
export class CadastrarDadosPessoaisComponent implements OnInit {
  showSpinner=false;

  request: CriarDados = {
    id: "",
    matricula: "",
    nome: "",
    cpf: "",
    rg: "",
    dtnasc: "",
    cep: "",
    logradouro: "",
    numero: "",
    bairro: "",
    localidade: "",
    estado: "",
  //   contatos: [
  //     {
  //         "contato": "",
  //         "tipoDeContato": {
  //             "nomeTipoContato": ""
  //         }
  //     }
      
  // ],
    // complemento: "",
    //pais: "",  está no back, mas não no formulário


    //O de baixo é para o mockapi
    // id: "",
    // nome: "",
    // email: "",
    // localidade: "",
    // logradouro: "",
    // matricula: "",
    // numero: "",
    // rg: "",
    // cpf: "",
    // telefone: "",
    // dtnasc: "",
    // complemento: "",
    // cep: "",
    // bairro: "",
    // estado: "",
  }

  response: Dados;

  constructor(private dadosService: DadosService, private http: HttpClient) { }

  ngOnInit() {

  }

  loading(){
    this.showSpinner=true
    setTimeout(()=>{
      this.showSpinner=false;
    },3000)
  }

  CadastrarDados(form) {
    this.loading()
    this.dadosService.Cadastrar(this.request).subscribe(res => {
      this.response = res;
      alert("Cadastro VÁLIDO.");
      history.go(0); //Atualiza a página.
    }, error => {
      alert('TENTE NOVAMENTE. CADASTRO INVÁLIDO.')
    });

  }
  

consultaCep(cep, form) {
  console.log(cep);
  cep = cep.replace(/\D/g, '');
  if (cep != "") {
    var validacep = /^[0-9]{8}$/;
    if (validacep.test(cep)) {
      this.resetaDadosForm(form);
      this.http.get("https://viacep.com.br/ws/" + cep + "/json/")

        .subscribe(dados => { this.populaDadosForm(dados, form), console.table(dados) })
    }
  }
}

populaDadosForm(dados, formulario) {
  formulario.form.patchValue({
    localidade: dados.localidade,
    logradouro: dados.logradouro,
    cep: dados.cep,
    bairro: dados.bairro,
    estado: dados.uf,
    // complemento: dados.complemento,  foi decidido que o usuário preencheria o número.
    //Contudo, se quisermos, podemos descomentar a linha acima.
  });
}

resetaDadosForm(formulario){
  formulario.form.patchValue({
    localidade: null,
    logradouro: null,
    bairro: null,
    estado: null,
    //complemento: null,
  });
} 
}