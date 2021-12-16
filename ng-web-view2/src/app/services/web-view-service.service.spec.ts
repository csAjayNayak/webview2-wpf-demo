import { TestBed } from '@angular/core/testing';

import { WebViewServiceService } from './web-view-service.service';

describe('WebViewServiceService', () => {
  let service: WebViewServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(WebViewServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
