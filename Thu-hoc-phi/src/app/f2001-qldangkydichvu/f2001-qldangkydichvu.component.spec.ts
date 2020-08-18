import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F2001QldangkydichvuComponent } from './f2001-qldangkydichvu.component';

describe('F2001QldangkydichvuComponent', () => {
  let component: F2001QldangkydichvuComponent;
  let fixture: ComponentFixture<F2001QldangkydichvuComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F2001QldangkydichvuComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F2001QldangkydichvuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
