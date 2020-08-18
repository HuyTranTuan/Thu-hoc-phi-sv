import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1004FindComponent } from './f1004-find.component';

describe('F1004FindComponent', () => {
  let component: F1004FindComponent;
  let fixture: ComponentFixture<F1004FindComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1004FindComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1004FindComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
