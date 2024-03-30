import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChurchProgramDetailComponent } from './church-program-detail.component';

describe('ChurchProgramDetailComponent', () => {
  let component: ChurchProgramDetailComponent;
  let fixture: ComponentFixture<ChurchProgramDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChurchProgramDetailComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ChurchProgramDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
