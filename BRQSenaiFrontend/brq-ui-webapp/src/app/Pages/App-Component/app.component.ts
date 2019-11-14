import { Component, OnInit } from '@angular/core';
import * as jwt from 'jwt-decode';
import { LoginService } from 'src/app/Services/Login/login.service';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  ativo:Boolean;
  constructor(private auth:LoginService){}
  ngOnInit() {
    
    }
  title = 'brq-ui-webapp';
  // decode(){
  //   let token = localStorage.getItem('token');
  //   let decode = jwt(token)
    
  // }
}
