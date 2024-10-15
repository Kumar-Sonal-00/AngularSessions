import { NgSwitch, NgSwitchCase, NgSwitchDefault } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'ngswitch-demo',
  standalone: true,
  imports: [NgSwitch,NgSwitchCase,NgSwitchDefault],
  templateUrl: './ngswitch-demo.component.html',
  styleUrl: './ngswitch-demo.component.css'
})
export class NgswitchDemoComponent {
  ch:number=1;

  setChoice(choice:number){
    this.ch=choice;
   // console.log(this.ch);
  }

}
