import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListarExperienciaPorIdComponent } from './listar-experiencia-por-id.component';
import { DeletarExperienciaComponent } from '../deletar-experiencia/deletar-experiencia.component';

@NgModule({
    declarations:[
        ListarExperienciaPorIdComponent,
        DeletarExperienciaComponent,
    ],
    entryComponents:[DeletarExperienciaComponent],
    imports:[
        CommonModule
    ],
    exports:[ListarExperienciaPorIdComponent]
})

export class ListarExperienciaModule{}
