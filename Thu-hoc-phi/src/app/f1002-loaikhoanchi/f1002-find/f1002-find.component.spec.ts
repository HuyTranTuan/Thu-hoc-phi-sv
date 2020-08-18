import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1002FindComponent } from './f1002-find.component';

describe('F1002FindComponent', () => {
  let component: F1002FindComponent;
  let fixture: ComponentFixture<F1002FindComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1002FindComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1002FindComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
