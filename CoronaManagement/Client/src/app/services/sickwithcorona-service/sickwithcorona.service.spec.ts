import { TestBed } from '@angular/core/testing';

import { SickwithcoronaService } from './sickwithcorona.service';

describe('SickwithcoronaService', () => {
  let service: SickwithcoronaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SickwithcoronaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
