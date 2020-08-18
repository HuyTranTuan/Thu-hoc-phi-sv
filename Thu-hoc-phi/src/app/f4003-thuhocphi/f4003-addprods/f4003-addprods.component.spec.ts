import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F4003AddprodsComponent } from './f4003-addprods.component';

describe('F4003AddprodsComponent', () => {
  let component: F4003AddprodsComponent;
  let fixture: ComponentFixture<F4003AddprodsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F4003AddprodsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F4003AddprodsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
