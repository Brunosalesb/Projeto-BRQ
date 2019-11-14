import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarDadosPorIdComponent } from './listar-dados-por-id.component';

describe('ListarDadosPorIdComponent', () => {
  let component: ListarDadosPorIdComponent;
  let fixture: ComponentFixture<ListarDadosPorIdComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListarDadosPorIdComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListarDadosPorIdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
