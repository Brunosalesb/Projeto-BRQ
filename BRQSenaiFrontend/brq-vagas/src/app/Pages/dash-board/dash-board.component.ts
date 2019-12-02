import { Component, OnInit } from '@angular/core';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';

@Component({
  selector: 'app-dash-board',
  templateUrl: './dash-board.component.html',
  styleUrls: ['./dash-board.component.css']
})
export class DashBoardComponent implements OnInit {
  listaUser: Array<any>;
  listaVaga: Array<any>;
  users: number;
  vagas: number;
  constructor(private api: Services) { }

  ngOnInit() {
    this.ListarUsuario();
    this.ListarVaga();
  }

  ListarUsuario() {
    const urlUser = `${this.api.APIPessoas()}`;
    o(urlUser)
      .get()
      .query()
      .then(data => {
      this.listaUser = data,

        this.users = this.listaUser.length
      })
      .catch(err => console.log(err))
  }

  ListarVaga() {
    const urlVaga = `${this.api.APIVagas()}`;
    o(urlVaga)
      .get()
      .query()
      .then(data => {
      this.listaVaga = data,

        this.vagas = this.listaVaga.length
      })
      .catch(err => console.log(err))
  }

}
