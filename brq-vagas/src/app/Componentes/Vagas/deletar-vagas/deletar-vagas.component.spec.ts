import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DeletarVagasComponent } from './deletar-vagas.component';

describe('DeletarVagasComponent', () => {
  let component: DeletarVagasComponent;
  let fixture: ComponentFixture<DeletarVagasComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DeletarVagasComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DeletarVagasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
