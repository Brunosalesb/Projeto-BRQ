import { Component, OnInit } from '@angular/core';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';

@Component({
  selector: 'app-dash-board',
  templateUrl: './dash-board.component.html',
  styleUrls: ['./dash-board.component.css']
})
export class DashBoardComponent implements OnInit {
  lista:Array<any>;
  quantidade:number;
  constructor(private api:Services) { }

  ngOnInit() {
    this.ListarUsuario();
  }
  ListarUsuario(){
    const url = `${this.api.APIPessoas()}`;
    o(url)
    .get()
    .query()
    .then(data=>{this.lista=data,
      
    this.quantidade=this.lista.length
    } )
    .catch(err=>console.log(err))
  }

}
