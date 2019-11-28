import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DeletarExperienciaComponent } from './deletar-experiencia.component';

describe('DeletarExperienciaComponent', () => {
  let component: DeletarExperienciaComponent;
  let fixture: ComponentFixture<DeletarExperienciaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DeletarExperienciaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DeletarExperienciaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
