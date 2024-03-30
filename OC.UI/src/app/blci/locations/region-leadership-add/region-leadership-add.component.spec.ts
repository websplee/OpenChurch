import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegionLeadershipAddComponent } from './region-leadership-add.component';

describe('RegionLeadershipAddComponent', () => {
  let component: RegionLeadershipAddComponent;
  let fixture: ComponentFixture<RegionLeadershipAddComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegionLeadershipAddComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RegionLeadershipAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
