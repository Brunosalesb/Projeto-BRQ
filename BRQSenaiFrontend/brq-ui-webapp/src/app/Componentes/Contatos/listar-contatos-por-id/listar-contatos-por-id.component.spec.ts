import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarContatosPorIdComponent } from './listar-contatos-por-id.component';

describe('ListarContatosPorIdComponent', () => {
  let component: ListarContatosPorIdComponent;
  let fixture: ComponentFixture<ListarContatosPorIdComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListarContatosPorIdComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListarContatosPorIdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
