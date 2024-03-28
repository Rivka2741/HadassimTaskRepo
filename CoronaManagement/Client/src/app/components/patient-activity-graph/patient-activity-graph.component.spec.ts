import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PatientActivityGraphComponent } from './patient-activity-graph.component';

describe('PatientActivityGraphComponent', () => {
  let component: PatientActivityGraphComponent;
  let fixture: ComponentFixture<PatientActivityGraphComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PatientActivityGraphComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PatientActivityGraphComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
