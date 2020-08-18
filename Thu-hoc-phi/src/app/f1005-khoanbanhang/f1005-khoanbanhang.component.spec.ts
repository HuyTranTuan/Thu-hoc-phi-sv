import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1005KhoanbanhangComponent } from './f1005-khoanbanhang.component';

describe('F1005KhoanbanhangComponent', () => {
  let component: F1005KhoanbanhangComponent;
  let fixture: ComponentFixture<F1005KhoanbanhangComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1005KhoanbanhangComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1005KhoanbanhangComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
