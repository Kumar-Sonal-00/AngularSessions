import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { SideMenuComponent } from './components/side-menu/side-menu.component';
import { ContactDetailsComponent } from './components/contact-details/contact-details.component';
import { ContactListComponent } from './components/contact-list/contact-list.component';
import { ParentComponent } from './parent/parent.component';
import { AddContactComponent } from './components/add-contact/add-contact.component';
import { EditContactComponent } from './components/edit-contact/edit-contact.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,
    HeaderComponent,
    FooterComponent,
    SideMenuComponent,
    ContactDetailsComponent,
    ContactListComponent,
    ParentComponent,
    AddContactComponent,
    EditContactComponent
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'phonebook-app';
}
