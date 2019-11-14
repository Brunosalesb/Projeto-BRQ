import { Component, OnInit, OnChanges, SimpleChanges, OnDestroy } from '@angular/core';
import { LoginComponent } from 'src/app/Componentes/login/login.component';
import { LoginService } from 'src/app/Services/Login/login.service';
import * as jwt from 'jwt-decode';
import { Router } from '@angular/router';
import { MatDialogConfig, MatDialog } from '@angular/material/dialog';
@Component({
  selector: 'app-cabecalho',
  templateUrl: './cabecalho.component.html',
  styleUrls: ['./cabecalho.component.css']
})
export class CabecalhoComponent implements OnInit {
  token = localStorage.getItem("token");
  id:number;
  constructor(private api:LoginService,private route:Router,private dialog:MatDialog) { }
  ativo=false;
  
  ngOnInit() {
    this.api.mostrarMenuEmitter.subscribe(
      mostrar=>this.mostrarMenu=mostrar
      )
        if (this.token==null) {
          this.mostrarMenu=false;
    
        }
        else{
          this.mostrarMenu=true;
        }
        this.decode();
        this.Verifica();
        
      }
    adminN:Boolean;
  mostrarMenuAdmin:boolean=false;
  mostrarMenu:boolean=false;
 
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
  
  logout(){
    localStorage.clear();
    window.location.reload();
    this.mostrarMenu=false;
    // this.route.navigate(["/"]);
    
  }
  Verifica(){
    let token = localStorage.getItem('user');
    if (token!==null&&token=="true") {
      this.mostrarMenuAdmin=true;
    }
    else{
      this.mostrarMenuAdmin=false;
    }
  }

  openDialog(): void {
    this.ativo = !this.ativo;
    const dialogConfig = new MatDialogConfig();
    dialogConfig.width = "35%";
    // dialogConfig.position.right="30%";
    dialogConfig.height = "35%";
    const dialogRef = this.dialog.open(LoginComponent, dialogConfig);

    dialogRef.afterClosed().subscribe(result => {
      history.go(0)
    });

  }
  
  
   
}
