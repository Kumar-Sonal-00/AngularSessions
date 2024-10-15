import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { catchError, of } from 'rxjs';

@Component({
  selector: 'child',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './child.component.html',
  styleUrl: './child.component.css'
})
export class ChildComponent {
  constructor(private http:HttpClient){}

  @Output()
  onData:EventEmitter<number>=new EventEmitter<number>();

  @Input()
  x:number=0;

  @Input()
  y:number=0; 

  result?:number;
  errMsg?:string;
  add(){
    this.result=Number(this.x) + Number(this.y);
    console.log('child click');
    //fire the parent event using EventEmitter
    this.onData.emit(this.result);
  } 

  // divide(){
  //   try{
  //   if(this.y==0){
  //     throw new Error('divide by zero error occurred');
  //   }else{
  //     this.result=Number(this.x)/Number(this.y);
  //   }
  // }catch(error:any){
  //   console.error(error);
  //   this.errMsg=error.message;
  // }
  // }

  // divide(){
  //   if(this.y==0){
  //       throw new Error('divide by zero error occurred');
  //   }else{
  //       this.result=Number(this.x)/Number(this.y);
  //   }
  // }

  // //error handling in asynchronous operations like http service
  // divide(){
  //   this.http.get('http://localhost:4300/contactshgh').pipe(catchError((error:any)=>{
  //     console.log('some error:',error.message);
  //     return of([]);
  //   })).subscribe(res=>{
  //     console.log(res)
  //   });
  // }

   //error handling testing using HttpInterceptor 
   divide(){
    this.http.get('http://localhost:4300/contactshgh').subscribe(res=>{
      console.log(res)
    });
  }
}
