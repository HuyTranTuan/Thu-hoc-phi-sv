import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1001AddComponent } from './f1001-add.component';

describe('F1001AddComponent', () => {
  let component: F1001AddComponent;
  let fixture: ComponentFixture<F1001AddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1001AddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1001AddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
