import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FilterSkillPipeComponent } from './filter-skill-pipe.component';

describe('FilterSkillPipeComponent', () => {
  let component: FilterSkillPipeComponent;
  let fixture: ComponentFixture<FilterSkillPipeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FilterSkillPipeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FilterSkillPipeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
