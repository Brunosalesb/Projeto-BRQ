import { NgModule } from '@angular/core';
import {MatButtonModule,MatToolbarModule,MatGridListModule} from '@angular/material';

const Material = [
  MatButtonModule,
  MatToolbarModule,
  MatGridListModule
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
