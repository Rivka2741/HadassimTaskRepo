import { Component } from '@angular/core';
import{ VaccinemanufacturerService } from '../../services/vaccinemanufacturer-service/vaccinemanufacturer.service'
import { VaccineManufacturer } from 'src/models/VaccineManufacturer';
@Component({
  selector: 'app-vaccine-manufacturer',
  templateUrl: './vaccine-manufacturer.component.html',
  styleUrls: ['./vaccine-manufacturer.component.css']
})
export class VaccineManufacturerComponent {
  VaccineManufacturer: VaccineManufacturer[] = []; 
  constructor(public vaccinemanufacturerService: VaccinemanufacturerService) {}
  ngOnInit(){
    this.getVaccineManufacturer();
  }
  getVaccineManufacturer() {
    this.vaccinemanufacturerService.getVaccineManufacturer().subscribe(vaccinemanufacturer => {
      this.VaccineManufacturer = vaccinemanufacturer;
      console.log(this.VaccineManufacturer);
    });
  }
}
