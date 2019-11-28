import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CadastrarDadosPessoaisComponent } from './Componentes/DadosPessoais/cadastrar-dados-pessoais/cadastrar-dados-pessoais.component';
import { ListarTodosComponent } from './Componentes/DadosPessoais/listar-todos/listar-todos.component';
import { PerfilComponent } from './Pages/perfil/perfil.component';
import { ListarSkillComponent } from './Componentes/Skills/listar-skill/listar-skill.component';
import { CadastrarSkillComponent } from './Componentes/Skills/cadastrar-skill/cadastrar-skill.component';
import { AuthGuardService } from './Services/Guards/authGuard.guard';
import { AdminGuardService } from './Services/Guards/AdminGuard.guard';
import { DashBoardComponent } from './Pages/dash-board/dash-board.component';
import { ListarTipoSkillComponent } from './Componentes/TipoSkill/listar-tipo-skill/listar-tipo-skill.component';
import { ListarTodasComponent } from './Componentes/Experiencias/listar-todas/listar-todas.component';
import { usuarioDeslogado } from './Services/Guards/usuarioDeslogado.guard';
import { ListarTipoExperienciaComponent } from './Componentes/TipoExperiencia/listar-tipo-experiencia/listar-tipo-experiencia.component';
import { CadastrarVagasComponent } from './Componentes/Vagas/cadastrar-vagas/cadastrar-vagas.component';
import { EditarVagasComponent } from './Componentes/Vagas/editar-vagas/editar-vagas.component';
import { ListarVagasComponent } from './Componentes/Vagas/listar-vagas/listar-vagas.component';
import { ListarVagaPorIdComponent } from './Componentes/Vagas/listar-vaga-por-id/listar-vaga-por-id.component';
import { LoginComponent } from './Componentes/login/login.component';
import { NaoencontradaComponent } from './Pages/naoencontrada/naoencontrada.component';

const routes: Routes = [
  { path: "lista", component: ListarTodosComponent,canActivate:[AdminGuardService] },
  { path: "cadastrarusuario", component: CadastrarDadosPessoaisComponent,canActivate:[usuarioDeslogado] },
  { path: "perfil/:id", component: PerfilComponent, canActivate: [AuthGuardService] },
  {path:"login",component:LoginComponent,canActivate:[usuarioDeslogado]},
  {path:"dashboard",component:DashBoardComponent,canActivate:[AdminGuardService]},
   {path:"dashboard/skill",component:ListarSkillComponent,canActivate:[AdminGuardService]},
   {path:"dashboard/tiposkill",component:ListarTipoSkillComponent,canActivate:[AdminGuardService]},
   {path:"dashboard/experiencias",component:ListarTodasComponent,canActivate:[AdminGuardService]},
  {path:"dashboard/tipoexperiencia",component:ListarTipoExperienciaComponent,canActivate:[AdminGuardService]},
  { path:"skills", component: ListarSkillComponent },
  { path:"cadastrarSkill", component: CadastrarSkillComponent,canActivate:[AdminGuardService] },
  {path:"vagas",component:ListarVagasComponent,canActivate:[AuthGuardService]},
  {path:"vagas/:id",component:ListarVagaPorIdComponent,canActivate:[AuthGuardService]},
  {path:"dashboard/vagas",component:CadastrarVagasComponent,canActivate:[AdminGuardService]},
  {path:"vagas/editar/:id",component:EditarVagasComponent,canActivate:[AdminGuardService]},
  {path:"**",component:NaoencontradaComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
