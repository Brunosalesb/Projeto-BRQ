import { Component, OnInit } from '@angular/core';
import {Services} from "../../../ApiService";
import { o } from "odata";

@Component({
  selector: 'app-listar-vagas',
  templateUrl: './listar-vagas.component.html',
  styleUrls: ['./listar-vagas.component.css']
})
export class ListarVagasComponent implements OnInit {
  lista: Array<any>;
  constructor(private api:Services) { }

  ngOnInit() {
    this.listarVagas();
  }

  listarVagas(){
    const url = `${this.api.APIVagas()}`;
    const response = o(url)
    .get()
    .query()
    .then(data => this.lista = data)
    .catch(err=>console.log(err))
  }
}
