import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1002AddComponent } from './f1002-add.component';

describe('F1002AddComponent', () => {
  let component: F1002AddComponent;
  let fixture: ComponentFixture<F1002AddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1002AddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1002AddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
