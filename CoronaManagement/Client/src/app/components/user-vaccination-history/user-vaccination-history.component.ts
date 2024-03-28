import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-user-vaccination-history',
  templateUrl: './user-vaccination-history.component.html',
  styleUrls: ['./user-vaccination-history.component.css']
})
export class UserVaccinationHistoryComponent {
  @Input() vaccinations: any[] = [];
  @Output() childEvent = new EventEmitter<string>();

  closeModal() {
    this.childEvent.emit();
  }
}
