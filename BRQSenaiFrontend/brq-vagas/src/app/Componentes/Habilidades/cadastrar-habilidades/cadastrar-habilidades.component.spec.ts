import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastrarHabilidadesComponent } from './cadastrar-habilidades.component';

describe('CadastrarHabilidadesComponent', () => {
  let component: CadastrarHabilidadesComponent;
  let fixture: ComponentFixture<CadastrarHabilidadesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CadastrarHabilidadesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CadastrarHabilidadesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
