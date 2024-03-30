import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegionLeadershipEditComponent } from './region-leadership-edit.component';

describe('RegionLeadershipEditComponent', () => {
  let component: RegionLeadershipEditComponent;
  let fixture: ComponentFixture<RegionLeadershipEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegionLeadershipEditComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RegionLeadershipEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
