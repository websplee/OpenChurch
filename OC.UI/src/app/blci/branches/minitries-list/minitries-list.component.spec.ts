import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MinitriesListComponent } from './minitries-list.component';

describe('MinitriesListComponent', () => {
  let component: MinitriesListComponent;
  let fixture: ComponentFixture<MinitriesListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MinitriesListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MinitriesListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
