import { Component, OnInit } from '@angular/core';
import { Contact } from '../../models/contact';
import { FormControl, FormGroup, ReactiveFormsModule, ValidatorFn, Validators } from '@angular/forms';
import { NgIf } from '@angular/common';
import { ContactService } from '../../services/contact.service';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';

@Component({
  selector: 'edit-contact',
  standalone: true,
  imports: [NgIf,ReactiveFormsModule,RouterLink],
  templateUrl: './edit-contact.component.html',
  styleUrl: './edit-contact.component.css'
})
export class EditContactComponent implements OnInit {
 contact:Contact=new Contact(0,"","","","","","","","","","");

 editForm:FormGroup=new FormGroup({});

 constructor(private service:ContactService,
            private activatedRoute:ActivatedRoute,
            private router:Router){ 
    
//display the record in the edit form with controls binded
this.editForm=new FormGroup({
  id:new FormControl(this.contact.id,Validators.required),
  firstname:new FormControl(0,Validators.compose([
                                                                        Validators.required,
                                                                        Validators.minLength(5),
                                                                        Validators.maxLength(10)])),
  lastname:new FormControl("",Validators.compose([
                                                        Validators.required,
                                                        Validators.minLength(5),
                                                        Validators.maxLength(10)])),

  email:new FormControl("",Validators.compose([Validators.email,Validators.required])),

  phone:new FormControl("",Validators.compose([Validators.required,Validators.pattern("\\d{10,10}")])),
  
  dob:new FormControl("",Validators.required),
  city:new FormControl("",Validators.required),
  state:new FormControl("",Validators.compose([Validators.required])),
  country:new FormControl("",Validators.required),
  gender:new FormControl("",Validators.required),
  picture:new FormControl("",Validators.required)    
});

 }

 ngOnInit(): void {

    this.activatedRoute.params.subscribe(params=>{
      let id = params['id'];
      //get the record by id for editing
      this.service.getContactById(id).subscribe((c) => {
        this.editForm.patchValue(c);
      });
    })

   
}

 saveContact(value:Contact){
  this.contact=value; 
  
  this.service.updateContact(this.contact).subscribe(res=>{
    console.log('record updated:',res);
    //navigate to the route contact-list
    this.router.navigate(['/contact-list']);
  });  
 }
}
