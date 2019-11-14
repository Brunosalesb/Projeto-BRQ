import { Component, OnInit } from '@angular/core';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';
import { Base } from '../Model/tipoexperiencia.model';

@Component({
  selector: 'app-listar-tipo-experiencia',
  templateUrl: './listar-tipo-experiencia.component.html',
  styleUrls: ['./listar-tipo-experiencia.component.css']
})
export class ListarTipoExperienciaComponent implements OnInit {
  lista:Array<any>
  request:Base={
    nomeTipoExperiencia:''
  }
  listaID:Array<any>;
  constructor(private api:Services) { }

  ngOnInit() {
this.listar();
  }
  listar(){
    const url =`${this.api.APITipoExperiencia()}`;
    const response = o(url)
    .get()
    .query()
    .then(data=>this.lista=data)
  }
  deletar(id:number){
    const url = `${this.api.APITipoExperiencia()}/${id}`;
    const response = o(url)
    .delete()
    .query()
    .then()
    this.listar();
  }
  cadastrar(){
    const url =`${this.api.APITipoExperiencia()}`;
    const response = o(url)
    .post('',this.request)
    .query()
    .then()
    this.listar();
  }
  // listarporid(id:number){
  //   const url = `${this.api.APITipoExperiencia()}/?$filter=contains(id,${id})`;
  //   o(url)
  //   .get()
  //   .query()
  //   .then(data=>this.listaID=data)
  //   console.log(url);
  // }
  editar(id){
    // this.listarporid(id);
    const url = `${this.api.APITipoExperiencia()}/${id}`;
    o(url)
    .put('',this.request)
    .query()
    .then()
  }

}
