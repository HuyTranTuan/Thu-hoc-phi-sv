import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1007GroupaddComponent } from './f1007-groupadd.component';

describe('F1007GroupaddComponent', () => {
  let component: F1007GroupaddComponent;
  let fixture: ComponentFixture<F1007GroupaddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1007GroupaddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1007GroupaddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
