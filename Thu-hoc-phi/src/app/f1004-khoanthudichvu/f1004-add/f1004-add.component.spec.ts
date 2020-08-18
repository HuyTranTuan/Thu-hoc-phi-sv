import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1004AddComponent } from './f1004-add.component';

describe('F1004AddComponent', () => {
  let component: F1004AddComponent;
  let fixture: ComponentFixture<F1004AddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1004AddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1004AddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
