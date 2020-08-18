import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F4001DodukienhocsinhComponent } from './f4001-dodukienhocsinh.component';

describe('F4001DodukienhocsinhComponent', () => {
  let component: F4001DodukienhocsinhComponent;
  let fixture: ComponentFixture<F4001DodukienhocsinhComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F4001DodukienhocsinhComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F4001DodukienhocsinhComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
