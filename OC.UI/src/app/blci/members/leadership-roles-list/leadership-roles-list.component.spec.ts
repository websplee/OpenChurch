import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LeadershipRolesListComponent } from './leadership-roles-list.component';

describe('LeadershipRolesListComponent', () => {
  let component: LeadershipRolesListComponent;
  let fixture: ComponentFixture<LeadershipRolesListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LeadershipRolesListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LeadershipRolesListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
