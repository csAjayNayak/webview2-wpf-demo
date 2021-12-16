import { Component } from '@angular/core';
import { WebViewServiceService } from './services/web-view-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'ng-web-view2';

  
  constructor(private _webViewServiceService : WebViewServiceService) {
   

  }

  onBtnClick(){
  
    this._webViewServiceService.postMessage("Hi... I am angular")
  }
}
