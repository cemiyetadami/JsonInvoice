import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OploaderComponent } from './oploader.component';

describe('OploaderComponent', () => {
  let component: OploaderComponent;
  let fixture: ComponentFixture<OploaderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OploaderComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OploaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
