import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F2001AddComponent } from './f2001-add.component';

describe('F2001AddComponent', () => {
  let component: F2001AddComponent;
  let fixture: ComponentFixture<F2001AddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F2001AddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F2001AddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
