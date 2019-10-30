import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {ListarVagasComponent} from './Componentes/Vagas/listar-vagas/listar-vagas.component';
import {CadastrarVagasComponent} from './Componentes/Vagas/cadastrar-vagas/cadastrar-vagas.component';
import { DeletarVagasComponent } from './Componentes/Vagas/deletar-vagas/deletar-vagas.component';
import { EditarVagasComponent } from './Componentes/Vagas/editar-vagas/editar-vagas.component';
import { ListarVagaPorIdComponent } from './Componentes/Vagas/listar-vaga-por-id/listar-vaga-por-id.component';

const routes: Routes = [
  {path:"vagas/listar",component:ListarVagasComponent},
  {path:"vagas/listar/:id",component:ListarVagaPorIdComponent},
  {path:"vagas/cadastrar",component:CadastrarVagasComponent},
  {path:"vagas/deletar",component:DeletarVagasComponent},
  //{path:"vagas/editar",component:EditarVagasComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
