import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VaccineManufacturerComponent } from './vaccine-manufacturer.component';

describe('VaccineManufacturerComponent', () => {
  let component: VaccineManufacturerComponent;
  let fixture: ComponentFixture<VaccineManufacturerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VaccineManufacturerComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(VaccineManufacturerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
