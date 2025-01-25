import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PaymentDetailModel } from './payment-detail.model';

describe('PaymentDetailModel', () => {
  let component: PaymentDetailModel;
  let fixture: ComponentFixture<PaymentDetailModel>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PaymentDetailModel]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PaymentDetailModel);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
