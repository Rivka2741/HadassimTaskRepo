import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-my-corona-date',
  templateUrl: './my-corona-date.component.html',
  styleUrls: ['./my-corona-date.component.css']
})
export class MyCoronaDateComponent {
  @Input() coronaDate: any; // Input to receive the corona date information from parent component
  @Output() childEvent = new EventEmitter<string>();
  
  closeModal() {
    this.childEvent.emit();
  }
}


