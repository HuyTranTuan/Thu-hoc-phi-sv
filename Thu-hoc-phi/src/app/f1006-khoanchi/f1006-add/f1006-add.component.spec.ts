import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1006AddComponent } from './f1006-add.component';

describe('F1006AddComponent', () => {
  let component: F1006AddComponent;
  let fixture: ComponentFixture<F1006AddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1006AddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1006AddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
