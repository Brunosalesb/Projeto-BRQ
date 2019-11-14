import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastrarExperienciaComponent } from './cadastrar-experiencia.component';

describe('CadastrarExperienciaComponent', () => {
  let component: CadastrarExperienciaComponent;
  let fixture: ComponentFixture<CadastrarExperienciaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CadastrarExperienciaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CadastrarExperienciaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
