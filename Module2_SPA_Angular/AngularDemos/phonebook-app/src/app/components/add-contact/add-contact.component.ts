import { Component, OnInit } from '@angular/core';
import { Contact } from '../../models/contact';
import { FormsModule } from '@angular/forms';
import { CommonModule, JsonPipe, NgIf } from '@angular/common';
import { Observable } from 'rxjs';
import { ContactService } from '../../services/contact.service';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'add-contact',
  standalone: true,
  imports: [FormsModule,CommonModule,JsonPipe,RouterLink],
  templateUrl: './add-contact.component.html',
  styleUrl: './add-contact.component.css'
})
export class AddContactComponent implements OnInit {

  contact:Contact=new Contact(0,"","","","","","","","","","");

  constructor(private service:ContactService){
  }

  ngOnInit(): void {
    
  }
  addContact(){ 
    this.service.addContact(this.contact).subscribe(contactRes=>{
      console.log('Contact record inserted:',contactRes);
    });
  }
}
