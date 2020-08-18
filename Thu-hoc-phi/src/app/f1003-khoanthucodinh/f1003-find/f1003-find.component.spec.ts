import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1003FindComponent } from './f1003-find.component';

describe('F1003FindComponent', () => {
  let component: F1003FindComponent;
  let fixture: ComponentFixture<F1003FindComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1003FindComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1003FindComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
