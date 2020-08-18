import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F4003DetailComponent } from './f4003-detail.component';

describe('F4003DetailComponent', () => {
  let component: F4003DetailComponent;
  let fixture: ComponentFixture<F4003DetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F4003DetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F4003DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
