import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1003KhoanthucodinhComponent } from './f1003-khoanthucodinh.component';

describe('F1003KhoanthucodinhComponent', () => {
  let component: F1003KhoanthucodinhComponent;
  let fixture: ComponentFixture<F1003KhoanthucodinhComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1003KhoanthucodinhComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1003KhoanthucodinhComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
