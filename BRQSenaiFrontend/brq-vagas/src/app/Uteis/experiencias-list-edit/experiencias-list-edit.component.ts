import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-experiencias-list-edit',
  templateUrl: './experiencias-list-edit.component.html',
  styleUrls: ['./experiencias-list-edit.component.css']
})
export class ExperienciasListEditComponent implements OnInit {
  ativoEdit=true;
  constructor() { }

  ngOnInit() {
  }
  mudarComponente(){
    this.ativoEdit=!this.ativoEdit;
  }
}
