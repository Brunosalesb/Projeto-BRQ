import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {ListarVagasComponent} from './Componentes/Vagas/listar-vagas/listar-vagas.component';


const routes: Routes = [
  {path:"vagas",component:ListarVagasComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
