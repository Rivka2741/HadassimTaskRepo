import { TestBed } from '@angular/core/testing';

import { VaccinationdetailService } from './vaccinationdetail.service';

describe('VaccinationdetailService', () => {
  let service: VaccinationdetailService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(VaccinationdetailService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
