import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1007KhoanchimiengiamComponent } from './f1007-khoanchimiengiam.component';

describe('F1007KhoanchimiengiamComponent', () => {
  let component: F1007KhoanchimiengiamComponent;
  let fixture: ComponentFixture<F1007KhoanchimiengiamComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1007KhoanchimiengiamComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1007KhoanchimiengiamComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
