import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1005AddComponent } from './f1005-add.component';

describe('F1005AddComponent', () => {
  let component: F1005AddComponent;
  let fixture: ComponentFixture<F1005AddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1005AddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1005AddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
