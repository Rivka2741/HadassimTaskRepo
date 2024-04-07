import { Component, Inject, Input } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { VaccinationDetail } from 'src/models/VaccinationDetail';

@Component({
  selector: 'app-user-vaccination-history',
  templateUrl: './user-vaccination-history.component.html',
  styleUrls: ['./user-vaccination-history.component.css']
})
export class UserVaccinationHistoryComponent {
  @Input() vaccinationHistory: VaccinationDetail[];

  constructor(
    public dialogRef: MatDialogRef<UserVaccinationHistoryComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {
    this.vaccinationHistory = data.vaccinationHistory;
  }

  closeDialog(): void {
    this.dialogRef.close(this.vaccinationHistory);
  }
}
