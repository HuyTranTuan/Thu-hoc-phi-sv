import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F4001EditComponent } from './f4001-edit.component';

describe('F4001EditComponent', () => {
  let component: F4001EditComponent;
  let fixture: ComponentFixture<F4001EditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F4001EditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F4001EditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
