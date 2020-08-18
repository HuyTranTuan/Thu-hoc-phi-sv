import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F5003BaocaodangkidicvuComponent } from './f5003-baocaodangkidicvu.component';

describe('F5003BaocaodangkidicvuComponent', () => {
  let component: F5003BaocaodangkidicvuComponent;
  let fixture: ComponentFixture<F5003BaocaodangkidicvuComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F5003BaocaodangkidicvuComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F5003BaocaodangkidicvuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
