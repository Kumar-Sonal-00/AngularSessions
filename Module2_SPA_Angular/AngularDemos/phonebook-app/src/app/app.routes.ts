import { Routes } from '@angular/router';
import { ContactListComponent } from './components/contact-list/contact-list.component';
import { AddContactComponent } from './components/add-contact/add-contact.component';
import { EditContactComponent } from './components/edit-contact/edit-contact.component';
import { ContactDetailsComponent } from './components/contact-details/contact-details.component';
import { LoginComponent } from './components/login/login.component';
import { ContactUsComponent } from './components/contact-us/contact-us.component';
import { editGuard } from './edit.guard';
import { deactivateGuard } from './deactivate.guard';



export const routes: Routes = [
 {
    path:'contact-list',
    component:ContactListComponent
 },
 {
    path:'add-contact',
    component:AddContactComponent,
    canActivate:[editGuard],
    canDeactivate:[deactivateGuard]
 },
 {
    path:'edit-contact/:id',
    component:EditContactComponent,
    canActivate:[editGuard],
    canDeactivate:[deactivateGuard]
 },
 
 {
    path:'home/:id',
    component:ContactDetailsComponent
   //  children:[
   //       { path:'login',component:LoginComponent},
   //       { path:'contactus',component:ContactUsComponent}
   //  ]
 },
 {
   path:'login',
   component:LoginComponent
 },
 {
    path:'',
    redirectTo:'home/1',
    pathMatch:'full'
 }
];
