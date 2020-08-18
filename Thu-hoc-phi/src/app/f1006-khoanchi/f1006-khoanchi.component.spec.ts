import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1006KhoanchiComponent } from './f1006-khoanchi.component';

describe('F1006KhoanchiComponent', () => {
  let component: F1006KhoanchiComponent;
  let fixture: ComponentFixture<F1006KhoanchiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1006KhoanchiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1006KhoanchiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
