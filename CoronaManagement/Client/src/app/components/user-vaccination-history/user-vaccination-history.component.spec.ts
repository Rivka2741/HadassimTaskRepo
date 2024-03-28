import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserVaccinationHistoryComponent } from './user-vaccination-history.component';

describe('UserVaccinationHistoryComponent', () => {
  let component: UserVaccinationHistoryComponent;
  let fixture: ComponentFixture<UserVaccinationHistoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UserVaccinationHistoryComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UserVaccinationHistoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
