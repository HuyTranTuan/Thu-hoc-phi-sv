import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F4003AddrefundComponent } from './f4003-addrefund.component';

describe('F4003AddrefundComponent', () => {
  let component: F4003AddrefundComponent;
  let fixture: ComponentFixture<F4003AddrefundComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F4003AddrefundComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F4003AddrefundComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
