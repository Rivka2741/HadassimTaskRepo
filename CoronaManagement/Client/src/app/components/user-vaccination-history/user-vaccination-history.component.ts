import { Component, Input, Output, EventEmitter,Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-user-vaccination-history',
  templateUrl: './user-vaccination-history.component.html',
  styleUrls: ['./user-vaccination-history.component.css']
})
export class UserVaccinationHistoryComponent {
  constructor(
    public dialogRef: MatDialogRef<UserVaccinationHistoryComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) { }
  @Input() vaccinations: any[] = [];
  @Output() childEvent = new EventEmitter<string>();

  closeDialog(): void {
    this.dialogRef.close();
  }
}
