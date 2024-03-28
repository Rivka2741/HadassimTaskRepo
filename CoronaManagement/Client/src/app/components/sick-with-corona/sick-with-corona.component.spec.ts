import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SickWithCoronaComponent } from './sick-with-corona.component';

describe('SickWithCoronaComponent', () => {
  let component: SickWithCoronaComponent;
  let fixture: ComponentFixture<SickWithCoronaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SickWithCoronaComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SickWithCoronaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
