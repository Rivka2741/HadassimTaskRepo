import { Component, OnInit , Input , Output, EventEmitter} from '@angular/core';
import{ UsersService } from '../../services/users-service/users.service'
import { Users } from 'src/models/Users';
import{ SickwithcoronaService } from '../../services/sickwithcorona-service/sickwithcorona.service'
import { SickWithCorona } from 'src/models/SickWithCorona'; 
import{ VaccinationdetailService } from '../../services/vaccinationdetail-service/vaccinationdetail.service'
import { VaccinationDetail } from 'src/models/VaccinationDetail'; 
import { MyCoronaDateComponent } from '../my-corona-date/my-corona-date.component';

@Component({
  selector: 'app-hmomembers',
  templateUrl: './hmomembers.component.html',
  styleUrls: ['./hmomembers.component.css']
})
export class HMOMembersComponent implements OnInit {
  constructor(public usersService: UsersService, public sickWithCoronaService: SickwithcoronaService, public VaccinationdetailService: VaccinationdetailService ) { }
  
  @Output() 
  @Input()
  Users: Users[] = [];
  custAdded = new EventEmitter<Users>();

  ngOnInit(){
    this.getUser();
  }
 
  onSubmit()
  {
    this.custAdded.emit(this.user);

    this.user = {userId:0,firstName:'', lastName: '',identityCard:'',city:'',street:'',
                 number:'',dateOfBirth:new Date(),phone:'',cellPhone:'',photo:null,sickWithCoronas:null,vaccinationDetails:null};
  }
  // Define variables
  show: boolean = true;
  showCoronaDate: any;
  coronaDate: any; 
  selectedUser:Users=new Users(0,'','','','','','',new Date(),'','',null,null,null) 
  index:number=0;
  userById: string="";
  user:Users=new Users();
  edit:boolean=false;
  add:boolean=false;
  showUserById:boolean=false;
  vaccinationHistory: any; 
  showVacHistory:boolean = false;


  change(){
    this.show=true;
    this.edit=false;
    this.add=false;
    this.showUserById=false;
  }

  changeAdd(){  
  this.add=true;
  this.edit=false;
  this.show=false;
  this.showUserById=false;
  }

  changeGetUserById(){
  this.showUserById=true;
  this.add=false;
  this.edit=false;
  this.show=false;
  }

  editUser(user:Users){
    this.edit=true;

    let tmpuser:Users = new Users(user.userId,user.firstName,user.lastName,user.identityCard,user.city
                                  ,user.street,user.number,user.dateOfBirth,user.phone,user.cellPhone,user.photo,user.sickWithCoronas,user.vaccinationDetails);
    this.selectedUser = tmpuser;
    this.index = this.Users.indexOf(user);
  }

  save() {
    if (this.selectedUser.userId !== undefined) {
    this.usersService.updateUser(this.selectedUser).subscribe(response => {
        console.log('User data updated successfully:', response);
        this.Users[this.index] = response; 
        this.edit = false;
      },
      error => {
        console.error('Error updating user data:', error);
      }
    );
    } else {
      console.error('Error: Selected user ID is undefined');
    }
  }

  removeUser(user: Users) {

  this.usersService.deleteUser(user.userId).subscribe(state=>{
      let ind = this.Users.indexOf(user);
      this.Users.splice(ind, 1);
  })
  }

  getUser() {
  this.usersService.getUser().subscribe(User => {
    this.Users = User;
    console.log("List of users:", this.Users);
  });
  }

  addUser(){
  this.usersService.addUser(this.user).subscribe(state=>{
     this.Users.push(this.user)
  })

  }

  getUserById() {
  this.usersService.getUserById(String(this.userById)).subscribe((user: Users) =>{
    this.selectedUser = user;
  } );
 
  }

  onFileSelected(event: any, user: any) {
    const file: File = event.target.files[0];
    const reader = new FileReader();
  
    reader.onload = () => {
      const photoData: File = new File([new Uint8Array(reader.result as ArrayBuffer)], file.name, { type: file.type });
      this.uploadUserPhoto(user.identityCard, photoData);
    };
  
    reader.readAsArrayBuffer(file);
  }
  
  uploadUserPhoto(userId: string, photoData: File): void {
    this.usersService.uploadUserPhoto(userId, photoData).subscribe(response => {
      // Handle success response if needed
      console.log('good uploading photo:', response);
      this.getUser();
    },
    error => {
      console.error('Error uploading photo:', error);
    });
  }

  getCoronaDate(user: Users) {
  this.sickWithCoronaService.getCoronaDate(Number(user.userId)).subscribe((coronaDate: SickWithCorona[]) => {
    this.coronaDate = coronaDate || []; 
    this.showCoronaDate = true;
  });
  }

  closeModal() {
    this.showCoronaDate = false; 
  }

  closeModalVaccination() {
    this.showVacHistory = false; 
  }

  userVaccination(user:Users) {
  this.VaccinationdetailService.getUserVaccination(Number(user.userId)).subscribe((userVaccination: VaccinationDetail[]) => {
    this.vaccinationHistory = userVaccination || []; 
    this.showVacHistory = true;
  });
  }
}
