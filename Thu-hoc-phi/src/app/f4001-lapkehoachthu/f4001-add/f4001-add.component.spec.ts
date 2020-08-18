import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F4001AddComponent } from './f4001-add.component';

describe('F4001AddComponent', () => {
  let component: F4001AddComponent;
  let fixture: ComponentFixture<F4001AddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F4001AddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F4001AddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
