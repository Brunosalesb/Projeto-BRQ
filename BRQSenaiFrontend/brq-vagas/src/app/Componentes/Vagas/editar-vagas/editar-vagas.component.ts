import { Component, OnInit } from '@angular/core';
import { Base } from 'src/app/Componentes/Vagas/Model/vagas.model';
import { ActivatedRoute, Router } from '../../../../../node_modules/@angular/router';
import { Services } from 'src/app/ApiService';
import { o } from '../../../../../node_modules/odata';
import { ToastrService } from 'ngx-toastr';

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
    // dtPublicacao: new Date(Date.now())
  };
  skills:Array<any>;
  id:string;
  constructor(private route:ActivatedRoute,private api:Services,private router:Router,private toastr:ToastrService) { }

  ngOnInit() {
    this.ListarVagaPorId();
    this.listarRequisito();
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
    .then(data=>this.toastr.success(this.vaga.titulo,"Vaga Atualizada"))
    this.router.navigate([`/vagas/${this.id}`])
  }
  listarRequisito(){
    const url = `${this.api.APISkill()}`;
    o(url)
    .get()
    .query()
    .then(data=>this.skills=data)
  }

}
