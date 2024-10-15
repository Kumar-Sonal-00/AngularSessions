import { Component, OnInit } from '@angular/core';
import { Contact } from '../../models/contact';
import { NgForOf} from '@angular/common';
import { ContactService } from '../../services/contact.service';
import { GenderPipe } from '../../pipes/gender.pipe';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'contact-list',
  standalone: true,
  imports: [NgForOf,GenderPipe,RouterLink],
  templateUrl: './contact-list.component.html',
  styleUrl: './contact-list.component.css'
})
export class ContactListComponent implements OnInit {

  contacts:Contact[]=[];
  
  filteredContacts:Contact[]=[];
  constructor(private service:ContactService){
  }

  ngOnInit(): void {
      this.service.getContacts().subscribe(contactsData=>{
        this.contacts=contactsData;
        this.filteredContacts=[...this.contacts];
      });
    }  
  editContact(){
    console.log('edit contact');
  }
  deleteContact(id:number){
    if (confirm('want to delete?')) {
      // console.log('delete contact:', id);
      this.service.deleteContactById(id).subscribe((contactData) => {
        console.log('contact deleted:', contactData.id);

        //refresh the contacts from server
        this.service.getContacts().subscribe((contactsData) => {
          this.filteredContacts = contactsData;
        });
      });
    }
  }

  filterData(choice:string){
    console.log(choice);
    if(choice==='Male'){
      this.filteredContacts =this.contacts.filter((c)=>{
        return c.gender==='Male';
      });
    } else if(choice==="Female"){
      this.filteredContacts =this.contacts.filter((c)=>{
        return c.gender==='Female';
      });
    }else{
      this.filteredContacts=this.contacts;
    }
  }
}
