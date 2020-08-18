import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { F4001LapkehoachthuComponent } from './f4001-lapkehoachthu.component';

describe('F4001LapkehoachthuComponent', () => {
  let component: F4001LapkehoachthuComponent;
  let fixture: ComponentFixture<F4001LapkehoachthuComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ F4001LapkehoachthuComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(F4001LapkehoachthuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
