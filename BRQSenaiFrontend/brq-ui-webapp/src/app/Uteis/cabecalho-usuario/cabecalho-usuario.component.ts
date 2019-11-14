import { Component, OnInit } from '@angular/core';
import * as jwt from 'jwt-decode';

@Component({
  selector: 'app-cabecalho-usuario',
  templateUrl: './cabecalho-usuario.component.html',
  styleUrls: ['../cabecalho/cabecalho.component.css']
})
export class CabecalhoUsuarioComponent implements OnInit {
  id:number;
  constructor() { }

  ngOnInit() {
      this.decode();
  }
  logout(){
    localStorage.removeItem('token');
    window.location.reload();
  }
  decode(){
    
    let  token  =  window.localStorage.getItem('token');
    let decode =  jwt(token)
    if (token==null) {
      return undefined
      
    }
     else{
      this.id =decode.jti;
    
      return  this.id;
    }
  }
    
}
