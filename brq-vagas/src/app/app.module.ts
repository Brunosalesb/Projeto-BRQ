import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './Pages/App-Component/app.component';
import { ListarVagasComponent } from './Componentes/Vagas/listar-vagas/listar-vagas.component';
import { Services } from './ApiService';

@NgModule({
  declarations: [
    AppComponent,
    ListarVagasComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [Services],
  bootstrap: [AppComponent]
})
export class AppModule { }
