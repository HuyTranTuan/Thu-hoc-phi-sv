import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F5002DanhsachphieuthuComponent } from './f5002-danhsachphieuthu.component';

describe('F5002DanhsachphieuthuComponent', () => {
  let component: F5002DanhsachphieuthuComponent;
  let fixture: ComponentFixture<F5002DanhsachphieuthuComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F5002DanhsachphieuthuComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F5002DanhsachphieuthuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
