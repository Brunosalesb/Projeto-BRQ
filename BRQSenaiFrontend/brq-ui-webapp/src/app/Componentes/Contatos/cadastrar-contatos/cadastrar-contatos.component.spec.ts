import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastrarContatosComponent } from './cadastrar-contatos.component';

describe('CadastrarContatosComponent', () => {
  let component: CadastrarContatosComponent;
  let fixture: ComponentFixture<CadastrarContatosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CadastrarContatosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CadastrarContatosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
