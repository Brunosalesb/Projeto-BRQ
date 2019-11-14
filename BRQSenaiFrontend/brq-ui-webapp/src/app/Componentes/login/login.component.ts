import { Component, OnInit, EventEmitter, OnDestroy } from '@angular/core';
import { RequestLogin, ResponseLogin } from '../DadosPessoais/Model/dadospessoais.model';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';

import { HttpClient } from '@angular/common/http';
import { LoginService } from 'src/app/Services/Login/login.service';
import { catchError } from 'rxjs/operators';
import { MatDialogConfig, MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit, OnDestroy {

  request: RequestLogin = {
    matricula: ""
  }
  ativo = false;
  logout: boolean;
  token = localStorage.getItem('token');
  erro: boolean = false;
  usuarioAutenticado = false;
  mostrarMenuEmitter = new EventEmitter<boolean>();
  constructor(private http: HttpClient, private api: LoginService, private dialog: MatDialog) { }
  showSpinner = false;
  ngOnInit() {
    // localStorage.removeItem('token');
    this.api.mostrarErroEmitter.subscribe(
      err => this.erro = err,
    );
    this.api.mostrarLogout.subscribe(err => {
      this.logout = err
    })
  }
  ngOnDestroy() {
    this.request.matricula == null;
    // console.clear();
  }
  login(form) {

    this.api.login(form);

  }
  Logout() {
    localStorage.removeItem('token');
    this.logout = false;
  }

}
