import { Component, OnInit } from '@angular/core';
import { Services } from 'src/app/ApiService';
import { Base } from '../Model/vagas.model';
import { o } from 'odata';
import { ActivatedRoute } from '../../../../../node_modules/@angular/router';

@Component({
  selector: 'app-listar-vaga-por-id',
  templateUrl: './listar-vaga-por-id.component.html',
  styleUrls: ['./listar-vaga-por-id.component.css']
})
export class ListarVagaPorIdComponent implements OnInit {
  lista: Base;
  id:string;
  constructor(private api:Services,private route:ActivatedRoute) { }

  ngOnInit() {
    this.listarVagaPorId();
  }

  async listarVagaPorId(){
    this.id = this.route.snapshot.paramMap.get('id');
    const url = await `${this.api.APIVagas()}/${this.id}`;
    const response = o(url)
    .get()
    .query()
    .then(data=>this.lista=data)
  }
}
