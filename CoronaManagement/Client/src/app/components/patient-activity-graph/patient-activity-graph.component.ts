import { Component, OnInit } from '@angular/core';
import { SickwithcoronaService } from '../../services/sickwithcorona-service/sickwithcorona.service';
import { VaccinationdetailService } from '../../services/vaccinationdetail-service/vaccinationdetail.service';
import { UsersService } from '../../services/users-service/users.service';

@Component({
  selector: 'app-patient-activity-graph',
  templateUrl: './patient-activity-graph.component.html',
  styleUrls: ['./patient-activity-graph.component.css']
})
export class PatientActivityGraphComponent implements OnInit {

  constructor(private sickWithCoronaService: SickwithcoronaService, 
              private vaccinationdetailService:VaccinationdetailService,
              private UsersService:UsersService) { }

  activePatientsCountDay: number[] = new Array(31).fill(0); // Array to store active patients count for each day
  numNeverVaccinated: number = 0;

  ngOnInit(): void {
    this.getactivePatientsCountDay();
    this.getVaccinationData();
  }

  getactivePatientsCountDay() {
    this.sickWithCoronaService.getSickWithCorona().subscribe(sickWithCorona => {
      this.calculateActivePatientsCount(sickWithCorona);
    });
  }

  calculateActivePatientsCount(sickWithCorona: any[]) {
    const today = new Date();
    const firstDayOfMonth = new Date(today.getFullYear(), today.getMonth(), 1);

    sickWithCorona.forEach(sick => {
      const positiveResultDate = new Date(sick.positiveResultDate);
      const recoveryDate = sick.recoveryDate ? new Date(sick.recoveryDate) : new Date(); // Use current date if RecoveryDate is null

      // Calculate the start and end dates for the period the patient is considered sick
      const startDate = positiveResultDate > firstDayOfMonth ? positiveResultDate : firstDayOfMonth;
      const endDate = recoveryDate < today ? recoveryDate : today;

      // Iterate through each day between the start and end dates
      for (let date = new Date(startDate); date <= endDate; date.setDate(date.getDate() + 1)) {
        const day = date.getDate();
        if(positiveResultDate<=date && recoveryDate>=date)
          this.activePatientsCountDay[day - 1]++;
      }
    });   
  }

  getVaccinationData() {
    this.vaccinationdetailService.getVaccinationDetail().subscribe(vaccinationDetails => {
      const vaccinatedUserIds = vaccinationDetails.map(detail => detail.userId);

      this.UsersService.getUser().subscribe(users => {
        const allUserIds = users.map(user => user.userId);
        this.numNeverVaccinated = allUserIds.filter(id => !vaccinatedUserIds.includes(Number(id))).length;
      });
    });
  }
}
