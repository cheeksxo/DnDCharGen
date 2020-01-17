import { Component, Injector } from '@angular/core';
import { MainGenerated } from './main-generated.component';

@Component({
  selector: 'page-main',
  templateUrl: './main.component.html'
})
export class MainComponent extends MainGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
