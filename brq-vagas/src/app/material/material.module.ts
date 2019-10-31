import { NgModule } from '@angular/core';
import {MatButtonModule,MatToolbarModule,MatGridListModule,MatPaginatorModule} from '@angular/material';

const Material = [
  MatButtonModule,
  MatToolbarModule,
  MatGridListModule,
  MatPaginatorModule
]

@NgModule({
  imports: [
    Material
  ],
  exports: [
    Material
  ]
})
export class MaterialModule { }
