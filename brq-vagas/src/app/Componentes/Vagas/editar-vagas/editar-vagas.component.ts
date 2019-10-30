import { Component, OnInit } from '@angular/core';
import { RequestEditar } from 'src/app/Componentes/Vagas/Model/vagas.model';
import { ActivatedRoute } from '../../../../../node_modules/@angular/router';
import { Services } from 'src/app/ApiService';
import { o } from '../../../../../node_modules/odata';

@Component({
  selector: 'app-editar-vagas',
  templateUrl: './editar-vagas.component.html',
  styleUrls: ['./editar-vagas.component.css']
})
export class EditarVagasComponent implements OnInit {
  lista:RequestEditar;
  id:string;
  listaEditar:Array<any>;
  constructor(private route:ActivatedRoute,private api:Services) { }

  ngOnInit() {
  }

  async listarVagaPorId(){
    this.id = this.route.snapshot.paramMap.get('id');
    const url = await `${this.api.APIVagas()}/${this.id}`;
    const response = o(url)
    .get()
    .query()
    .then(data=>this.lista=data)
  }

  //id vem pelo token, como fazer com mockapi?

  // EditarVaga(){
  //   this.id = this.route.snapshot.paramMap.get('id');
  //   this.
  // }
}
