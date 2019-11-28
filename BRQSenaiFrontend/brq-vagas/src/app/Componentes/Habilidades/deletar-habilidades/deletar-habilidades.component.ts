import { Component, OnInit } from '@angular/core';
import { HabilidadesService } from 'src/app/Services/Habilidades/habilidades.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-deletar-habilidades',
  templateUrl: './deletar-habilidades.component.html',
  styleUrls: ['./deletar-habilidades.component.css']
})
export class DeletarHabilidadesComponent implements OnInit {
  lista:Array<any>;
  idSkillPessoa:string;
  id:string;
  constructor(private service:HabilidadesService,private route:ActivatedRoute) { }

  ngOnInit() {
    this.listar();
  }
  listar(){
    this.idSkillPessoa = this.route.snapshot.paramMap.get('id');

    this.service.ListarTodas().subscribe(res=>{
    this.lista=res;
   
    });
    
  }
  deletar(){
    this.service.Deletar(this.id).subscribe();
  }

}
