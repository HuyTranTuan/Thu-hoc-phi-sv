import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1006FindComponent } from './f1006-find.component';

describe('F1006FindComponent', () => {
  let component: F1006FindComponent;
  let fixture: ComponentFixture<F1006FindComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1006FindComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1006FindComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
