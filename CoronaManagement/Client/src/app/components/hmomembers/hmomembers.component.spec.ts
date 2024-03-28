import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HMOMembersComponent } from './hmomembers.component';

describe('HMOMembersComponent', () => {
  let component: HMOMembersComponent;
  let fixture: ComponentFixture<HMOMembersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HMOMembersComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HMOMembersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
