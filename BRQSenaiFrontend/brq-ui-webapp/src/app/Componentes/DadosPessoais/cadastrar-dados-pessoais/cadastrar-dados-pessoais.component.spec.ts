import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastrarDadosPessoaisComponent } from './cadastrar-dados-pessoais.component';

describe('CadastrarDadosPessoaisComponent', () => {
  let component: CadastrarDadosPessoaisComponent;
  let fixture: ComponentFixture<CadastrarDadosPessoaisComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CadastrarDadosPessoaisComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CadastrarDadosPessoaisComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});