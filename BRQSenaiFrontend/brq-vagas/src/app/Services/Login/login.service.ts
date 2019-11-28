import { Injectable, EventEmitter } from '@angular/core';
import { HttpClient } from 'selenium-webdriver/http';
import { RequestLogin } from 'src/app/Componentes/DadosPessoais/Model/dadospessoais.model';
import { o } from 'odata';
import { Router } from '@angular/router';
import * as jwt from "jwt-decode";
import { Services } from 'src/app/ApiService';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class LoginService {

  request: RequestLogin;
  usuarioAutenticado: boolean;
  usuarioAutorizado: boolean;
  usuarioDeslogado:boolean;
  erro = false;
  mostrarMenuEmitter = new EventEmitter<boolean>();
  mostrarErroEmitter = new EventEmitter<boolean>();
  mostrarLogout = new EventEmitter<boolean>();
    mostrarMenuAdminEmmiter = new EventEmitter<boolean>();
  token = localStorage.getItem('token');

  constructor(private router: Router,private api:Services,private toastr:ToastrService) { }

   login(form) {
    let matricula;
    matricula = form.value.matricula;
    const url = `${this.api.ApiLogin()}`;
    const response = o(url)
      .post('', this.request)
      .query()
      .then( data => {
        
        localStorage.setItem('token', data.token)
        this.mostrarMenuEmitter.emit(true);
        this.mostrarErroEmitter.emit(false);
        this.toastr.success('Usuário Logado',"Sucesso")
        this.mostrarLogout.emit(true);
        let token = localStorage.getItem('token');
        let decode = jwt(token);
        if (token!==null && decode.jti==2) {
          this.usuarioAutorizado=true;
          this.mostrarMenuAdminEmmiter.emit(true)
          localStorage.setItem('user',"true");
          this.router.navigate(["/dashboard"])
        }
        else{
          this.usuarioAutorizado=false;
          this.mostrarMenuAdminEmmiter.emit(false)
          localStorage.setItem('user',"false");
          this.router.navigate(["/vagas"])
        }
        
      })
      .catch(err => {
          this.mostrarErroEmitter.emit(true);
          this.mostrarLogout.emit(false);
          this.toastr.error("","Matrícula Incorreta")
      }

      )
    
    
  }
  Autenticado() {
    let token = localStorage.getItem('token');
    let decode = jwt(token);
    if (token !== null) {
      this.usuarioAutenticado = true;
    }
    else {
      this.usuarioAutenticado = false;
    }
    return this.usuarioAutenticado;
  }
  Autorizado() {
    let token = localStorage.getItem('token');
    let decode = jwt(token);
    if (decode.jti == "1") {
      this.usuarioAutorizado = true;
    }
    else {
      this.usuarioAutorizado = false;
    }

    return this.usuarioAutorizado;
  }
  NaoAutorizado(){
    let token = localStorage.getItem('token');
    if (token==null) {
      this.usuarioDeslogado=true;
    }
    return this.usuarioDeslogado;
  }
 

}
