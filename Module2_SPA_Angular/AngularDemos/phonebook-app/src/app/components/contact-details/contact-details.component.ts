import { Component, OnInit } from '@angular/core';
import { Contact } from '../../models/contact';
import { CommonModule, DatePipe, NgIf, NgIfContext } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ContactService } from '../../services/contact.service';
import { ActivatedRoute, RouterLink, RouterOutlet } from '@angular/router';
import { catchError, throwError } from 'rxjs';

@Component({
  selector: 'contact-details',
  standalone: true,
  imports: [DatePipe,FormsModule,CommonModule,RouterLink,RouterOutlet],
  templateUrl: './contact-details.component.html',
  styleUrl: './contact-details.component.css'
})
export class ContactDetailsComponent implements OnInit {
 contact:Contact={
   id: 0,
   gender: ''
 }; 

 isEditable:boolean=false;

 constructor(private service:ContactService,private activatedRoute:ActivatedRoute){

 }
 ngOnInit(): void {
    this.activatedRoute.params.subscribe(params=>{
      this.service.getContactById(params['id']).subscribe(contactData=>{
        this.contact=contactData;
     });
    })


   
 }

 toggleEdit(){
  this.isEditable=!this.isEditable;
 }

}
