import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChurchProgramsListComponent } from './church-programs-list.component';

describe('ChurchProgramsListComponent', () => {
  let component: ChurchProgramsListComponent;
  let fixture: ComponentFixture<ChurchProgramsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChurchProgramsListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ChurchProgramsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
