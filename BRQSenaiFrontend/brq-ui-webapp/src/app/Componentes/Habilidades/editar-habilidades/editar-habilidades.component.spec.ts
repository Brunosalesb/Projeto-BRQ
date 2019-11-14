import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarHabilidadesComponent } from './editar-habilidades.component';

describe('EditarHabilidadesComponent', () => {
  let component: EditarHabilidadesComponent;
  let fixture: ComponentFixture<EditarHabilidadesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarHabilidadesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditarHabilidadesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
