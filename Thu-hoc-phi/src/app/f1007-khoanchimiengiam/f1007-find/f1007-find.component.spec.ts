import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1007FindComponent } from './f1007-find.component';

describe('F1007FindComponent', () => {
  let component: F1007FindComponent;
  let fixture: ComponentFixture<F1007FindComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1007FindComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1007FindComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
