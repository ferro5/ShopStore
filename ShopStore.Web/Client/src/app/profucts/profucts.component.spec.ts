import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfuctsComponent } from './profucts.component';

describe('ProfuctsComponent', () => {
  let component: ProfuctsComponent;
  let fixture: ComponentFixture<ProfuctsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProfuctsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProfuctsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
