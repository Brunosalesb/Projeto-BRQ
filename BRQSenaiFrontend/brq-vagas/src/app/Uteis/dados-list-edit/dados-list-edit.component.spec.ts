import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DadosListEditComponent } from './dados-list-edit.component';

describe('DadosListEditComponent', () => {
  let component: DadosListEditComponent;
  let fixture: ComponentFixture<DadosListEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DadosListEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DadosListEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
