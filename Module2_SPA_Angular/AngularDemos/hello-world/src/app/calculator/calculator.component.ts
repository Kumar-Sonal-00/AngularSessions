import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'calculator',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './calculator.component.html',
  styleUrl: './calculator.component.css'
})
export class CalculatorComponent {
  n1:number=0;
  n2:number=0;
  sum:number=0;

  addNumbers(){
    console.log('add clicked');
    this.sum=this.n1+this.n2;
  }
}
