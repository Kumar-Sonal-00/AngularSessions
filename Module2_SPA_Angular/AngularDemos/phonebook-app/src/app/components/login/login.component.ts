import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'login',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
 username?:string;
 password?:string;

 constructor(private router:Router){
 }

 login(){
   if(this.username==='admin' && this.password==='abc'){ //api for credential
      localStorage.setItem("token","valid");
      let redirectUrl=localStorage.getItem('redirectUrl');
      this.router.navigate([redirectUrl]);
   }else{
    alert('invalid username/password');
   }
 }
}
