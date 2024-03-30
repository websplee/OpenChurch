import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegionsDetailsComponent } from './regions-details.component';

describe('RegionsDetailsComponent', () => {
  let component: RegionsDetailsComponent;
  let fixture: ComponentFixture<RegionsDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegionsDetailsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RegionsDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
