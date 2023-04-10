import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InvoiceDeteailComponent } from './invoice-deteail.component';

describe('InvoiceDeteailComponent', () => {
  let component: InvoiceDeteailComponent;
  let fixture: ComponentFixture<InvoiceDeteailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InvoiceDeteailComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InvoiceDeteailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
