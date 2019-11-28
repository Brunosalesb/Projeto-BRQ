import { Component, OnInit, EventEmitter, OnDestroy } from '@angular/core';
import { RequestLogin, ResponseLogin } from '../DadosPessoais/Model/dadospessoais.model';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';
import * as jwt from 'jwt-decode'
import { MatDialogConfig, MatDialog } from '@angular/material/dialog';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  usuarioAutenticado: boolean;
  usuarioAutorizado: boolean;
  usuarioDeslogado:boolean;
  erro = false;
  mostrarMenuEmitter = new EventEmitter<boolean>();
  mostrarErroEmitter = new EventEmitter<boolean>();
  mostrarLogout = new EventEmitter<boolean>();
    mostrarMenuAdminEmmiter = new EventEmitter<boolean>();
  token = localStorage.getItem('token');
  request: RequestLogin = {
   senha:'',
   email:''
  }
  ativo = false;
  constructor(private router:Router, private api: Services, private dialog: MatDialog,private toastr:ToastrService) { }
  showSpinner = false;
  ngOnInit() {
    let token = localStorage.getItem('token');
    localStorage.clear();
     }
  
  login(form) {
      const url = `${this.api.ApiLogin()}`;
        o(url)
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
          
          if (token!==null && decode.jti==1) {
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
            this.toastr.error("","Email ou Senha Incorretos")
        }
        )
        let token = localStorage.getItem('token');
        let decode = jwt(token);
        console.log(decode);
      
      
    
  }
  
  Logout() {
    window.location.reload();
    localStorage.removeItem('token');
  
  }

}
