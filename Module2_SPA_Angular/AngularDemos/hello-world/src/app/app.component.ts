import { NgClass, NgStyle } from '@angular/common';
import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterOutlet } from '@angular/router';
import { CounterComponent } from './counter/counter.component';
import { CalculatorComponent } from './calculator/calculator.component';
import { NgIfDemoComponent } from './ng-if-demo/ng-if-demo.component';
import { NgswitchDemoComponent } from './ngswitch-demo/ngswitch-demo.component';
import { LifecycleComponent } from './lifecycle/lifecycle.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,
    NgClass,NgStyle,FormsModule,
    CounterComponent,
  CalculatorComponent,
  NgIfDemoComponent,
  LifecycleComponent,
NgswitchDemoComponent],
  // template:`<h1>Hello-world App</h1>
  //           <hr/>
  //           <p>Welcome</p>
  //         `,
  templateUrl: './app.component.html',
  // styleUrls:['./styel1.css','./style2.css'],
  styleUrl: './app.component.css'
})
export class AppComponent {

  n:number=100;
  

  title = 'hello-world-app';
  message='This is my first angular application';

  firstName?:string='sample';
  imagePath='../assets/images/p1.png';

  btnDisabled=false;

  btnCssC1="c1";
  btnCssC2="c2";

  w:number=200;
  h:number=400;

  username:string='john';
  


  show(){
    console.log('show');
  }
  getData(){
    return 'This is sample data';
  }
  getBtnCssClasses(){
    let classes={
      c1:true,
      c2:true
    };

    return classes;
  }
    addStyles(){
      let styles={
        'width.px':this.w,
        'height.px':this.h,
        'background-color':'red'
      };
      return styles;
    }
    onClick(value:string){
      console.log('Welcome ',value);
    }
    getValue(event:any){
      return event.target.value;
    }

    
}
