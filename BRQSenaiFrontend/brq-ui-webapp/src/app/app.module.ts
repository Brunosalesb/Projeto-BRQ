import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './Pages/App-Component/app.component';
import { CadastrarDadosPessoaisComponent } from './Componentes/DadosPessoais/cadastrar-dados-pessoais/cadastrar-dados-pessoais.component';
import { DadosService } from './Services/DadosPessoais/dados.service';
import { HttpClientModule } from '@angular/common/http';
import { ListarTodosComponent } from './Componentes/DadosPessoais/listar-todos/listar-todos.component';
import { ListarDadosPorIdComponent } from './Componentes/DadosPessoais/listar-dados-por-id/listar-dados-por-id.component';
import { EditarDadosComponent } from './Componentes/DadosPessoais/editar-dados/editar-dados.component';
import { MenuPerfilComponent } from './Uteis/menu-perfil/menu-perfil.component';

import { ExperienciasService } from './Services/Experiencias/experiencias.service';
import { CadastrarExperienciaComponent } from './Componentes/Experiencias/cadastrar-experiencia/cadastrar-experiencia.component';
import { ListarExperienciaPorIdComponent } from './Componentes/Experiencias/listar-experiencia-por-id/listar-experiencia-por-id.component';
import { HabilidadesService } from './Services/Habilidades/habilidades.service';
import { CadastrarHabilidadesComponent } from './Componentes/Habilidades/cadastrar-habilidades/cadastrar-habilidades.component';
import { EditarHabilidadesComponent } from './Componentes/Habilidades/editar-habilidades/editar-habilidades.component';
import { ListarHabilidadesPorIdComponent } from './Componentes/Habilidades/listar-habilidades-por-id/listar-habilidades-por-id.component';
import { EditarExperienciasComponent } from './Componentes/Experiencias/editar-experiencias/editar-experiencias.component';
import { PerfilComponent } from './Pages/perfil/perfil.component';
import { DadosListEditComponent } from './Uteis/dados-list-edit/dados-list-edit.component';
import { CabecalhoComponent } from './Uteis/cabecalho/cabecalho.component';
import { MatDialogModule } from '@angular/material/dialog';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatIconModule, MatIcon } from '@angular/material/icon';
import { DeletarHabilidadesComponent } from './Componentes/Habilidades/deletar-habilidades/deletar-habilidades.component';
import { MatProgressSpinnerModule, MatButtonModule, MatToolbarModule, MatGridListModule, MatPaginatorModule } from "@angular/material";
import { ListarExperienciaModule } from './Componentes/Experiencias/listar-experiencia-por-id/listar-experiencia-por-id.module';
import { ExperienciasListEditComponent } from './Uteis/experiencias-list-edit/experiencias-list-edit.component';
import { RodapeComponent } from './Uteis/rodape/rodape.component';
import { FilterSkillPipe } from './Uteis/pipes/filter-skill-pipe/filter-skill-pipe.component';
import { SkillService } from './Services/Skills/skill.service';
import { Services } from './ApiService';
import { LoginComponent } from './Componentes/login/login.component';
import { LoginService } from './Services/Login/login.service';
import { ListarSkillComponent } from './Componentes/Skills/listar-skill/listar-skill.component';
import { CadastrarSkillComponent } from './Componentes/Skills/cadastrar-skill/cadastrar-skill.component';
import { AuthGuardService } from './Services/Guards/authGuard.guard';
import { AdminGuardService } from './Services/Guards/AdminGuard.guard';
import { DashBoardComponent } from './Pages/dash-board/dash-board.component';
import { CabecalhoAdminComponent } from './Uteis/cabecalho-admin/cabecalho-admin.component';
import { CabecalhoUsuarioComponent } from './Uteis/cabecalho-usuario/cabecalho-usuario.component';
import { ListarTipoSkillComponent } from './Componentes/TipoSkill/listar-tipo-skill/listar-tipo-skill.component';
import { MatTableModule } from '@angular/material/table';
import { ListarTodasComponent } from './Componentes/Experiencias/listar-todas/listar-todas.component';
import { ListarContatosPorIdComponent } from './Componentes/Contatos/listar-contatos-por-id/listar-contatos-por-id.component';
import { ListarContatosComponent } from './Componentes/Contatos/listar-contatos/listar-contatos.component';
import { CadastrarContatosComponent } from './Componentes/Contatos/cadastrar-contatos/cadastrar-contatos.component';
import { EditarContatosComponent } from './Componentes/Contatos/editar-contatos/editar-contatos.component';
import { usuarioDeslogado } from './Services/Guards/usuarioDeslogado.guard';
import { ListarTipoExperienciaComponent } from './Componentes/TipoExperiencia/listar-tipo-experiencia/listar-tipo-experiencia.component';
import { CadastrarVagasComponent } from './Componentes/Vagas/cadastrar-vagas/cadastrar-vagas.component';
import { ListarVagasComponent } from './Componentes/Vagas/listar-vagas/listar-vagas.component';
import { EditarVagasComponent } from './Componentes/Vagas/editar-vagas/editar-vagas.component';
import { ListarVagaPorIdComponent } from './Componentes/Vagas/listar-vaga-por-id/listar-vaga-por-id.component';
@NgModule({
  declarations: [
    AppComponent,
    CadastrarDadosPessoaisComponent,
    ListarTodosComponent,
    ListarDadosPorIdComponent,
    EditarDadosComponent,
    MenuPerfilComponent,
    CadastrarExperienciaComponent,

    EditarExperienciasComponent,
    CadastrarHabilidadesComponent,
    EditarHabilidadesComponent,
    ListarHabilidadesPorIdComponent,
    PerfilComponent,
    DadosListEditComponent,
    CabecalhoComponent,
    DeletarHabilidadesComponent,
    ExperienciasListEditComponent,
    RodapeComponent,
    FilterSkillPipe,
    LoginComponent,
    ListarSkillComponent,
    CadastrarSkillComponent,
    DashBoardComponent,
    CabecalhoAdminComponent,
    CabecalhoUsuarioComponent,
    ListarTipoSkillComponent,
    ListarTodasComponent,
    ListarContatosPorIdComponent,
    ListarContatosComponent,
    CadastrarContatosComponent,
    EditarContatosComponent,
    ListarTipoExperienciaComponent,
    CadastrarVagasComponent,
    ListarVagasComponent,
    EditarVagasComponent,
    ListarVagaPorIdComponent,





  ],
  entryComponents: [
    CadastrarHabilidadesComponent,
    EditarExperienciasComponent,
    CadastrarExperienciaComponent,
    LoginComponent,
    EditarExperienciasComponent,
    CadastrarSkillComponent,
    CadastrarContatosComponent
  ],

  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    MatDialogModule,
    MatProgressSpinnerModule,
    MatIconModule,
    MatTableModule,
    BrowserAnimationsModule,
    ListarExperienciaModule,
    MatButtonModule,
    MatToolbarModule,
    MatGridListModule,
    MatPaginatorModule,
  ],
  providers: [DadosService, ExperienciasService, usuarioDeslogado, HabilidadesService, SkillService, Services, LoginService, AuthGuardService, AdminGuardService, ListarExperienciaPorIdComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
