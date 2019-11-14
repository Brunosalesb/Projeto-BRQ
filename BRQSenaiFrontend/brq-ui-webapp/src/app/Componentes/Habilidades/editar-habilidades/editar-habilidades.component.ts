import { Component, OnInit } from '@angular/core';
import { RequestAtualizar } from '../../Habilidades/Model/habilidades.model';
import { ActivatedRoute } from '@angular/router';
import { HabilidadesService } from 'src/app/Services/Habilidades/habilidades.service';
import { ResponseAtualizar } from '../../DadosPessoais/Model/dadospessoais.model';

@Component({
  selector: 'app-editar-habilidades',
  templateUrl: './editar-habilidades.component.html',
  styleUrls: ['./editar-habilidades.component.css']
})
export class EditarHabilidadesComponent implements OnInit {

  lista:Array<any>;
  listaatualizar:RequestAtualizar
  idExperiencia:string;
  constructor(private service:HabilidadesService,private route:ActivatedRoute) { }

  ngOnInit() {
   
      this.idExperiencia = this.route.snapshot.paramMap.get('id');
      this.service.ListarPorId(this.idExperiencia).subscribe(res=>{this.lista=res,console.log(res)});
    
  }
  Atualizar(){
    this.idExperiencia = this.route.snapshot.paramMap.get('idExperiencia');

    this.service.Atualizar(this.idExperiencia,this.listaatualizar).subscribe();
  }

}
