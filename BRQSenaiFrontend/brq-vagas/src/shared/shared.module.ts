

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import {
  KzMaskDirective,
  KzCpfValidatorDirective,
  KzCnpjValidatorDirective, 
  KzCpfCnpjValidatorDirective
} from '.';

@NgModule({
  imports:      [ 
  	CommonModule,
  	FormsModule 
  ],
  declarations: [
    KzMaskDirective,
    KzCpfValidatorDirective,
    KzCnpjValidatorDirective, 
    KzCpfCnpjValidatorDirective,
  ],
  exports: [ 
    KzMaskDirective,
    KzCpfValidatorDirective,
    KzCnpjValidatorDirective, 
    KzCpfCnpjValidatorDirective,
    CommonModule, 
    FormsModule 
  ]
})
export class SharedModule {}