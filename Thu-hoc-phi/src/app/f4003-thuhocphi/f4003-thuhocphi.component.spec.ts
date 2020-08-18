import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F4003ThuhocphiComponent } from './f4003-thuhocphi.component';

describe('F4003ThuhocphiComponent', () => {
  let component: F4003ThuhocphiComponent;
  let fixture: ComponentFixture<F4003ThuhocphiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F4003ThuhocphiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F4003ThuhocphiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
