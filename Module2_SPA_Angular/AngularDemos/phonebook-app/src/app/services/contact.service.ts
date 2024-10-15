import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Contact } from '../models/contact';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'  
})
export class ContactService {

  constructor(private http:HttpClient) { }

  getContacts():Observable<Contact[]>{  
    return this.http.get<Contact[]>("http://localhost:4300/contacts");
  }

  getContactById(id:number=1):Observable<Contact>{
    return this.http.get<Contact>(`http://localhost:4300/contacts/${id}`);
  }
  
  addContact(contact:Contact):Observable<Contact>{   
    return this.http.post<Contact>("http://localhost:4300/contacts",contact);
  }

  updateContact(contact:Contact):Observable<Contact>{    
    return this.http.put<Contact>(`http://localhost:4300/contacts/${contact.id}`,contact)
  }

  deleteContactById(id:number):Observable<Contact>{
    return this.http.delete<Contact>(`http://localhost:4300/contacts/${id}`) 
  }  
}
