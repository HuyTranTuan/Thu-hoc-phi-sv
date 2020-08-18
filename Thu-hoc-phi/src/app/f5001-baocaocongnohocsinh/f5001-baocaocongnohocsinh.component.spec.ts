import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F5001BaocaocongnohocsinhComponent } from './f5001-baocaocongnohocsinh.component';

describe('F5001BaocaocongnohocsinhComponent', () => {
  let component: F5001BaocaocongnohocsinhComponent;
  let fixture: ComponentFixture<F5001BaocaocongnohocsinhComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F5001BaocaocongnohocsinhComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F5001BaocaocongnohocsinhComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
