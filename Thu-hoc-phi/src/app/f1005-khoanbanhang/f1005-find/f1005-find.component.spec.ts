import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1005FindComponent } from './f1005-find.component';

describe('F1005FindComponent', () => {
  let component: F1005FindComponent;
  let fixture: ComponentFixture<F1005FindComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1005FindComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1005FindComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
