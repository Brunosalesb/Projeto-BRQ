import { Component, OnInit } from '@angular/core';
import { Base } from 'src/app/Componentes/Vagas/Model/vagas.model';
import { ActivatedRoute, Router } from '../../../../../node_modules/@angular/router';
import { Services } from 'src/app/ApiService';
import { o } from '../../../../../node_modules/odata';
import { query } from '../../../../../node_modules/@angular/animations';
import { async } from '../../../../../node_modules/@angular/core/testing';

@Component({
  selector: 'app-editar-vagas',
  templateUrl: './editar-vagas.component.html',
  styleUrls: ['./editar-vagas.component.css']
})
export class EditarVagasComponent implements OnInit {
  vaga: Base={
    titulo: "",
    empresa: "",
    TipoVinculo: "",
    localidade: "",
    descricao: "",
    requisito: "",
    beneficio: "",
    horario: "",
    salario: "",
    telefone: "",
    email:"",
    dtPublicacao: ""
  };
  id:string;
  constructor(private route:ActivatedRoute,private api:Services,private router:Router) { }

  ngOnInit() {
    this.ListarVagaPorId();
  }

  async ListarVagaPorId(){
    this.id = this.route.snapshot.paramMap.get('id');
    const url = await `${this.api.APIVagas()}/${this.id}`;
    const response = o(url)
    .get()
    .query()
    .then(data=>this.vaga=data)
  }

  EditarVaga(form){
    this.ListarVagaPorId();
    const url = `${this.api.APIVagas()}/${this.id}`;
    const response = o(url)
    .put('', this.vaga)
    .query()
    .then()
    alert("Vaga atualizada com sucesso!")
    this.router.navigate([`/vagas/listar/${this.id}`])
  }

}
