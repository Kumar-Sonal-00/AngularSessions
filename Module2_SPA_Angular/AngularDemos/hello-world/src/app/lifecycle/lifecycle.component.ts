import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'lifecycle',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './lifecycle.component.html',
  styleUrl: './lifecycle.component.css'
})
export class LifecycleComponent implements OnInit,OnChanges {
 @Input()
  x?:number;

  constructor(){
    console.log('constructor');
  }

  ngOnInit(): void {
    console.log("ngOnInit:",this.x);
  }

  ngOnChanges(changes: SimpleChanges): void {
    console.log('ngOnChanges');
    console.log(changes);
  }  
}
