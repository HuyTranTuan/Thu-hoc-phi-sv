import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F1007AddComponent } from './f1007-add.component';

describe('F1007AddComponent', () => {
  let component: F1007AddComponent;
  let fixture: ComponentFixture<F1007AddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F1007AddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F1007AddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
