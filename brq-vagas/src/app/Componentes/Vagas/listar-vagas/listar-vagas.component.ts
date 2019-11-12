import { Component, OnInit } from '@angular/core';
import {Services} from "../../../ApiService";
import { o } from "odata";
import { Base } from '../Model/vagas.model';

@Component({
  selector: 'app-listar-vagas',
  templateUrl: './listar-vagas.component.html',
  styleUrls: ['./listar-vagas.component.css']
})
export class ListarVagasComponent implements OnInit {
  lista: Base;
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
  }
}
