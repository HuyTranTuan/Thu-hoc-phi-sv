import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1003AddComponent } from './f1003-add.component';

describe('F1003AddComponent', () => {
  let component: F1003AddComponent;
  let fixture: ComponentFixture<F1003AddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1003AddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1003AddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
