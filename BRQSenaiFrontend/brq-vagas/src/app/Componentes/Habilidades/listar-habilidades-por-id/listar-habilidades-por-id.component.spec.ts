import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarHabilidadesPorIdComponent } from './listar-habilidades-por-id.component';

describe('ListarHabilidadesPorIdComponent', () => {
  let component: ListarHabilidadesPorIdComponent;
  let fixture: ComponentFixture<ListarHabilidadesPorIdComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListarHabilidadesPorIdComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListarHabilidadesPorIdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
