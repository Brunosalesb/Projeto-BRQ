import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarVagaPorIdComponent } from './listar-vaga-por-id.component';

describe('ListarVagaPorIdComponent', () => {
  let component: ListarVagaPorIdComponent;
  let fixture: ComponentFixture<ListarVagaPorIdComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListarVagaPorIdComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListarVagaPorIdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
