import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F5002DetailComponent } from './f5002-detail.component';

describe('F5002DetailComponent', () => {
  let component: F5002DetailComponent;
  let fixture: ComponentFixture<F5002DetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F5002DetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F5002DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
