import { Component, OnInit } from '@angular/core';
import { ExperienciasService } from 'src/app/Services/Experiencias/experiencias.service';
import { DeletarHabilidadesComponent } from '../../Habilidades/deletar-habilidades/deletar-habilidades.component';
import { MatDialogRef } from '@angular/material/dialog';
import { ListarExperienciaPorIdComponent } from '../listar-experiencia-por-id/listar-experiencia-por-id.component';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-deletar-experiencia',
  templateUrl: './deletar-experiencia.component.html',
  styleUrls: ['./deletar-experiencia.component.css']
})
export class DeletarExperienciaComponent implements OnInit {
  id:string;
  idExperiencia: string;
  constructor(private service: ExperienciasService,private dialogref:MatDialogRef<DeletarExperienciaComponent>,private route:ActivatedRoute) { }

  ngOnInit() {
    this.service.emitirID.subscribe(id=>{this.idExperiencia=id
      
    })
  }
  Deletar(){
      this.id = this.route.snapshot.paramMap.get('id');
      
      this.service.Deletar(this.id).subscribe();
  
   
  }
  CancelDelete(){
    this.dialogref.close();
  }

}
