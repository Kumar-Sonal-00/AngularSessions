import { CurrencyPipe, DatePipe, DecimalPipe, LowerCasePipe, NgForOf, NgIf, PercentPipe, UpperCasePipe } from '@angular/common';
import { Component } from '@angular/core';
import { LengthPipe } from '../length.pipe';

@Component({
  selector: 'ng-if-demo',
  standalone: true,
  imports: [NgIf,NgForOf,
    DatePipe,
    PercentPipe,
    DecimalPipe,
    LengthPipe,
    UpperCasePipe,LowerCasePipe,CurrencyPipe],
  templateUrl: './ng-if-demo.component.html',
  styleUrl: './ng-if-demo.component.css'
})
export class NgIfDemoComponent {

  firstName:string='Ravi';

  names:string[]=['Ravi','Ramesh','John','David'];

  salary:number=50000.1235;

  dob:Date=new Date(2024,8,2);
  profit:number=.65;
  gender:string="M";

}
