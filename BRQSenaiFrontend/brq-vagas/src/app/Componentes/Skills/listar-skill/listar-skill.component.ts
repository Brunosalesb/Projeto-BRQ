import { Component, OnInit } from '@angular/core';
import { Services } from 'src/app/ApiService';
import { o } from 'odata';
import { RequestSkill } from '../Model/skills.model';
import { MatDialog, MatDialogConfig } from '@angular/material';
import { CadastrarSkillComponent } from '../cadastrar-skill/cadastrar-skill.component';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-listar-skill',
  templateUrl: './listar-skill.component.html',
  styleUrls: ['./listar-skill.component.css']
})

export class ListarSkillComponent implements OnInit {
  lista: Array<any>;
  listaTipo: Array<any>;
  erro:string;
  eRR:boolean=false;
  top:number=10;
  listaPorId: Array<any>;
  button:boolean=true;
  skill: RequestSkill = {
    nome: "",
    fkIdTipoSkill: "",

  }
  id: string;
  constructor(private api: Services, private dialog: MatDialog,private toastr:ToastrService) { }
  quantidade: number;
  ngOnInit() {
    this.listar();
  }
  listar() {
    const urlSkill = `${this.api.APISkill()}`;
    const response = o(urlSkill)
      .get()
      .query()
      .then(data => { this.lista = data, this.quantidade = this.lista.length })
  }
  listarPorId(idSkill: string) {
    this.listarTipoSkill();
    const url = `${this.api.APISkill()}/${idSkill}`;
    const response = o(url)
      .get()
      .query()
      .then(data => { this.listaPorId = data })
      .catch(
      
      )

  }
  editar(idSkill: string, form) {
    this.listarPorId(idSkill);

    this.skill.nome = form.value.skill;
    this.skill.fkIdTipoSkill = form.value.tipo;
    const url = `${this.api.APISkill()}/${idSkill}`;
    const response = o(url)
      .put('', this.skill)
      .query()
      .then(e=>this.toastr.success(this.skill.nome,"Skill Editada"))

      .catch(d=>this.toastr.error('','Erro ao Editar Skill') )
      this.listar()
    
  }
 
  listarTipoSkill() {
    const url = `${this.api.APITipoSkill()}`;
    const response = o(url)
      .get()
      .query()
      .then(data => { this.listaTipo = data })
      .catch(
        
      )

  }
  deletar(id) {

    const url = `${this.api.APISkill()}?id=${id}`;
    const response = o(url)
      .delete()
      .query()
      .then(data=>this.toastr.warning("","Skill Deletada"))
      .catch(err=>this.toastr.error("","Erro ao Deletar Skill"))
  this.listar();

  }
  openDialogCadastro(): void {
   
    const dialogConfig = new MatDialogConfig();
    

   
    const dialogRef = this.dialog.open(CadastrarSkillComponent, dialogConfig);

    dialogRef.afterClosed().subscribe(result => {
      this.listar(); 
   });

  }

}
