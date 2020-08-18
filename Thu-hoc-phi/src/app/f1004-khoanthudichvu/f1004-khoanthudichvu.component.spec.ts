import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1004KhoanthudichvuComponent } from './f1004-khoanthudichvu.component';

describe('F1004KhoanthudichvuComponent', () => {
  let component: F1004KhoanthudichvuComponent;
  let fixture: ComponentFixture<F1004KhoanthudichvuComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1004KhoanthudichvuComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1004KhoanthudichvuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
