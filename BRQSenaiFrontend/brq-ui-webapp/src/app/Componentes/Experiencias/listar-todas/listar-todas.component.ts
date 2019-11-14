import { Component, OnInit } from '@angular/core';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';
import { BuscarUsuario } from '../../DadosPessoais/Model/dadospessoais.model';

@Component({
  selector: 'app-listar-todas',
  templateUrl: './listar-todas.component.html',
  styleUrls: ['./listar-todas.component.css']
})
export class ListarTodasComponent implements OnInit {
  lista:Array<any>;
  listas:BuscarUsuario={
    skillPessoa: [
      {
          Pessoa: {
              nome:'',
              matricula:''
          }
      }
  ]
  }
  constructor(private api:Services) { }

  ngOnInit() {
    this.listar();
  }
  listar(){
    const url =`${this.api.APIExperiencia()}`;
    const response = o(url)
    .get()
    .query()
    .then(data=>{this.lista=data})
    .catch()
  }
}
