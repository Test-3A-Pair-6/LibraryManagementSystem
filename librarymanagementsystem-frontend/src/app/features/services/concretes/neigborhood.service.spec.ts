import { TestBed } from '@angular/core/testing';

import { NeigborhoodService } from './neigborhood.service';

describe('NeigborhoodService', () => {
  let service: NeigborhoodService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(NeigborhoodService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
