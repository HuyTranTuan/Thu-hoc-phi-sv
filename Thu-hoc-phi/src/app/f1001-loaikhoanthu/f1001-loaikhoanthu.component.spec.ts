import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1001LoaikhoanthuComponent } from './f1001-loaikhoanthu.component';

describe('F1001LoaikhoanthuComponent', () => {
  let component: F1001LoaikhoanthuComponent;
  let fixture: ComponentFixture<F1001LoaikhoanthuComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1001LoaikhoanthuComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1001LoaikhoanthuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
