import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './Pages/App-Component/app.component';
import { ListarVagasComponent } from './Componentes/Vagas/listar-vagas/listar-vagas.component';
import { Services } from './ApiService';
import { CadastrarVagasComponent } from './Componentes/Vagas/cadastrar-vagas/cadastrar-vagas.component';
import { DeletarVagasComponent } from './Componentes/Vagas/deletar-vagas/deletar-vagas.component';
import { EditarVagasComponent } from './Componentes/Vagas/editar-vagas/editar-vagas.component';
import { ListarVagaPorIdComponent } from './Componentes/Vagas/listar-vaga-por-id/listar-vaga-por-id.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './material/material.module';

@NgModule({
  declarations: [
    AppComponent,
    ListarVagasComponent,
    CadastrarVagasComponent,
    DeletarVagasComponent,
    EditarVagasComponent,
    ListarVagaPorIdComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    BrowserAnimationsModule,
    MaterialModule
  ],
  providers: [Services],
  bootstrap: [AppComponent]
})
export class AppModule { }
