import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditarContatosComponent } from './editar-contatos.component';

describe('EditarContatosComponent', () => {
  let component: EditarContatosComponent;
  let fixture: ComponentFixture<EditarContatosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditarContatosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditarContatosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
