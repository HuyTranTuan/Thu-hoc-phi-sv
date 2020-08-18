import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1002LoaikhoanchiComponent } from './f1002-loaikhoanchi.component';

describe('F1002LoaikhoanchiComponent', () => {
  let component: F1002LoaikhoanchiComponent;
  let fixture: ComponentFixture<F1002LoaikhoanchiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1002LoaikhoanchiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1002LoaikhoanchiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
