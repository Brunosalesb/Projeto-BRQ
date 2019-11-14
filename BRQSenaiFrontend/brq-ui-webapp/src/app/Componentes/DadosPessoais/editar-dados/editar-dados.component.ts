import { Component, OnInit } from '@angular/core';
import { DadosService } from 'src/app/Services/DadosPessoais/dados.service';
import { ListarDadosPorIdComponent } from '../listar-dados-por-id/listar-dados-por-id.component';
import { RequestAtualizar } from '../Model/dadospessoais.model';
import { ActivatedRoute, Router } from '@angular/router';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';

@Component({
  selector: 'app-editar-dados',
  templateUrl: './editar-dados.component.html',
  styleUrls: ['./editar-dados.component.css']
})
export class EditarDadosComponent implements OnInit {
  lista:RequestAtualizar;
  id:string;
  listaEditar:Array<any>;
  constructor(private service:DadosService,private route:ActivatedRoute,private router:Router,private api:Services) { }

  ngOnInit() {
   this.listar();
   
    
  }

  async listar(){
    this.id = this.route.snapshot.paramMap.get('id');
    const url = await `${this.api.API()}/${this.id}`;
    const response = o(url)
    .get()
    .query()
    .then(data=>{this.listaEditar=data,console.log(this.listaEditar)})
    .catch(err=>console.log(err))
  }
  Atualizar(){
    this.id = this.route.snapshot.paramMap.get('id');
    const url = `${this.api.APIPessoas()}/${this.id}`;
    const response = o(url)
    .put('',this.lista)
    .query()
    .then()
    .catch(err=>console.log(err));
    console.log(url);
    
  }

}
