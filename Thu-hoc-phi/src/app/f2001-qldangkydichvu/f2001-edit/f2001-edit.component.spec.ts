import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F2001EditComponent } from './f2001-edit.component';

describe('F2001EditComponent', () => {
  let component: F2001EditComponent;
  let fixture: ComponentFixture<F2001EditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F2001EditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F2001EditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
