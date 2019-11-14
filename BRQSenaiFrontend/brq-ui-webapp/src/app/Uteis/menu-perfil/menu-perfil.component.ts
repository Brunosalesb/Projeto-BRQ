import { Component, OnInit } from '@angular/core';
import { DadosService } from 'src/app/Services/DadosPessoais/dados.service';
import { ActivatedRoute } from '@angular/router';
import { Dados, ListaNome } from 'src/app/Componentes/DadosPessoais/Model/dadospessoais.model';
import { o } from 'odata';

@Component({
  selector: 'app-menu-perfil',
  templateUrl: './menu-perfil.component.html',
  styleUrls: ['./menu-perfil.component.css']
})
export class MenuPerfilComponent implements OnInit {
  lista: Array<any>;
  id: string;
  constructor(private service: DadosService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.listar();
  }
  listar() {
    this.id = this.route.snapshot.paramMap.get('id');

    const response = o(`http://192.168.5.34:5000/api/pessoas/todosdados/${this.id}?$select=nome`)
      .get()
      .query()
      .then(data=>{
        this.lista=data
      })
  }
}
