import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyCoronaDateComponent } from './my-corona-date.component';

describe('MyCoronaDateComponent', () => {
  let component: MyCoronaDateComponent;
  let fixture: ComponentFixture<MyCoronaDateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MyCoronaDateComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MyCoronaDateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
