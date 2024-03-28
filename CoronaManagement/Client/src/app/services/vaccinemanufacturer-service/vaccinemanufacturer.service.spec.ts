import { TestBed } from '@angular/core/testing';

import { VaccinemanufacturerService } from './vaccinemanufacturer.service';

describe('VaccinemanufacturerService', () => {
  let service: VaccinemanufacturerService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(VaccinemanufacturerService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
