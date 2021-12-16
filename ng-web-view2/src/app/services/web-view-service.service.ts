import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

// add chrome to the Window context so typescript stops complaining
declare global {
  interface Window {
    chrome: any;
  }
}


@Injectable({
  providedIn: 'root'
})
export class WebViewServiceService {
  
  public webViewMessage = new Subject<any>();

  constructor() {
    window?.chrome?.webview?.addEventListener('message', (event:any) => {
      this.webViewMessage.next(event?.data);
    });
  }

  public postMessage(message: any) {
    window?.chrome?.webview?.postMessage(message);
  }
}
