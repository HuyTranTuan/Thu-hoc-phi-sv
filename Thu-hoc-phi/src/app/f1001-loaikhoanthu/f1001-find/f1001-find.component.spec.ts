import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1001FindComponent } from './f1001-find.component';

describe('F1001FindComponent', () => {
  let component: F1001FindComponent;
  let fixture: ComponentFixture<F1001FindComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1001FindComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1001FindComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
