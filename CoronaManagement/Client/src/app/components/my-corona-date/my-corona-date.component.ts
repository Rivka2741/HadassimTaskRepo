import { Component, Input, Output, EventEmitter,Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-my-corona-date',
  templateUrl: './my-corona-date.component.html',
  styleUrls: ['./my-corona-date.component.css']
})
export class MyCoronaDateComponent {
  constructor(
    public dialogRef: MatDialogRef<MyCoronaDateComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) { }
  
  @Input() coronaDate: any; // Input to receive the corona date information from parent component
  @Output() childEvent = new EventEmitter<string>();
  
  
  closeDialog(): void {
    this.dialogRef.close();
  }
  
}


