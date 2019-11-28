import { Component, OnInit } from '@angular/core';
import * as jwt from 'jwt-decode';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-cabecalho-usuario',
  templateUrl: './cabecalho-usuario.component.html',
  styleUrls: ['../cabecalho/cabecalho.component.css']
})
export class CabecalhoUsuarioComponent implements OnInit {
  id:number;
  constructor(private router:Router,private toastr:ToastrService) { }

  ngOnInit() {
      this.decode();
  }
  logout(){
    localStorage.removeItem('token');
    localStorage.clear();
    this.toastr.warning("","Usuário Deslogado")
    this.router.navigate(["/login"]);
  }
  decode(){
    
    let  token  =  window.localStorage.getItem('token');
    let decode =  jwt(token)
    if (token==null) {
      return undefined
      
    }
     else{
      this.id =decode.IdPessoa;
    
      return  this.id;
    }
  }
    
}
