import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'side-menu',
  standalone: true,
   imports: [RouterLink],
  templateUrl: './side-menu.component.html',
  styleUrl: './side-menu.component.css'
})
export class SideMenuComponent {

}
