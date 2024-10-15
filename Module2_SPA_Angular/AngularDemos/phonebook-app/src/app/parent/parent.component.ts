import { Component } from '@angular/core';
import { ChildComponent } from '../child/child.component';

@Component({
  selector: 'parent',
  standalone: true,
  imports: [ChildComponent],
  templateUrl: './parent.component.html',
  styleUrl: './parent.component.css'
})
export class ParentComponent {
 result:number=0;


 setResult(event:any){
  //throw new Error('some error occurred in Parent component');
  console.log('parent event fired');
  this.result=event;
 }
}
