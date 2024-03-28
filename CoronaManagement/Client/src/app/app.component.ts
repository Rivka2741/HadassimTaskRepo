import { Component} from '@angular/core';
import { Users } from 'src/models/Users';
import { SickWithCorona } from 'src/models/SickWithCorona';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ManagementOfCoronaPatients';
  User: Users[] = [];
  S: SickWithCorona[] = []; 

  activeTab: string = 'users';
  
  oncustAdded(user: Users) {
    this.User.push(user);
  }
}
