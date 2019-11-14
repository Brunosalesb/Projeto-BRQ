import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarExperienciaPorIdComponent } from './listar-experiencia-por-id.component';

describe('ListarExperienciaPorIdComponent', () => {
  let component: ListarExperienciaPorIdComponent;
  let fixture: ComponentFixture<ListarExperienciaPorIdComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListarExperienciaPorIdComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListarExperienciaPorIdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
