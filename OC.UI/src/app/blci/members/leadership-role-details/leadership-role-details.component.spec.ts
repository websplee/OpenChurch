import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LeadershipRoleDetailsComponent } from './leadership-role-details.component';

describe('LeadershipRoleDetailsComponent', () => {
  let component: LeadershipRoleDetailsComponent;
  let fixture: ComponentFixture<LeadershipRoleDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LeadershipRoleDetailsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LeadershipRoleDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
