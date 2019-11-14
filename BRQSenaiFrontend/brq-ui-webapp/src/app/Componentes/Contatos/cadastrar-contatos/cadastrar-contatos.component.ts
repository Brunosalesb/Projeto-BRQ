import { Component, OnInit } from '@angular/core';
import { ContatosService } from 'src/app/Services/Contatos/contatos.service';
import { CriarContatos, Contatos } from '../Model/contatos.model';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';
import * as jwt from 'jwt-decode';

@Component({
  selector: 'app-cadastrar-contatos',
  templateUrl: './cadastrar-contatos.component.html',
  styleUrls: ['./cadastrar-contatos.component.css']
})
export class CadastrarContatosComponent implements OnInit {
  idpessoa:number;

  request: CriarContatos ={
    id: "",
    nomeContato: "",
    idTipoContato: "",
    idPessoa: this.decode(),
  }
  response: Contatos;
  
  constructor(private contatosService: ContatosService, private http: HttpClient) { }

  ngOnInit() {
  }

  CadastrarContatos(form) {
    this.contatosService.Cadastrar(this.request).subscribe(res => {
      this.response = res;
        //alert("Cadastro VÁLIDO.");
        history.go(0); //Atualiza a página.
      }, error => {
        //alert('TENTE NOVAMENTE. CADASTRO INVÁLIDO.')
      });
  }

  decode(){
    let token = localStorage.getItem('token');
    let decode = jwt(token)
    if (token!==null) {
      
      decode.jti == this.idpessoa;
    }
    console.log(decode.jti);
    return decode.jti;
  }

}
