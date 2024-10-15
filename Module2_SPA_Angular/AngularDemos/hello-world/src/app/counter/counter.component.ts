import { Component, Input, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';

@Component({
  selector: 'counter',
  standalone: true,
  imports: [],
  templateUrl: './counter.component.html',
  styleUrl: './counter.component.css'
})
export class CounterComponent implements OnInit,OnChanges,OnDestroy  {

  constructor(){
    console.log('constructor');  //use for dependency injection
  }

  ngOnInit(){
    console.log('ngOnInit()');
    //going to call api and data for fields
  }

 ngOnChanges(changes: SimpleChanges): void {
   console.log('onChanges');
   console.log(changes);
 }

 ngOnDestroy(): void {
   console.log('ngOnDestroy()');
 }
 

  counter:number=0;
  
  incrementX(){
    this.counter++;
  }
  decrementX(){
    this.counter--;
  }
}
