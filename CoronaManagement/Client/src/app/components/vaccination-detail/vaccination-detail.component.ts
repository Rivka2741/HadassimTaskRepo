import { Component ,Input} from '@angular/core';
import{ VaccinationdetailService } from '../../services/vaccinationdetail-service/vaccinationdetail.service'
import { VaccinationDetail } from 'src/models/VaccinationDetail'; 

@Component({
  selector: 'app-vaccination-detail',
  templateUrl: './vaccination-detail.component.html',
  styleUrls: ['./vaccination-detail.component.css']
})
export class VaccinationDetailComponent {
  @Input()
  VaccinationDetail: VaccinationDetail[] = []; 
  constructor(public vaccinationdetailService: VaccinationdetailService) {}
  show:boolean=false;
  change(){
  this.show=true;

  }
  ngOnInit(){
    this.getVaccinationDetail();
  }
  getVaccinationDetail() {
    this.vaccinationdetailService.getVaccinationDetail().subscribe(vaccinationdetail => {
      this.VaccinationDetail = vaccinationdetail;
      console.log(this.VaccinationDetail);
    });
  }

  getUserVaccination(UserId:number) {
    this.vaccinationdetailService.getUserVaccination(UserId).subscribe((userVaccination: VaccinationDetail[]) => {
      this.VaccinationDetail = userVaccination;
      console.log(this.VaccinationDetail);
    });
  }

}
