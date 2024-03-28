import { Component ,Input } from '@angular/core';
import{ SickwithcoronaService } from '../../services/sickwithcorona-service/sickwithcorona.service'
import { SickWithCorona } from 'src/models/SickWithCorona'; 

@Component({
  selector: 'app-sick-with-corona',
  templateUrl: './sick-with-corona.component.html',
  styleUrls: ['./sick-with-corona.component.css']
})
export class SickWithCoronaComponent {
  @Input()
  SickWithCorona: SickWithCorona[] = []; 
  constructor(public sickwithcoronaService: SickwithcoronaService) {}

  ngOnInit(){
    this.getSickWithCorona();
  }
  getSickWithCorona() {
    this.sickwithcoronaService.getSickWithCorona().subscribe(sickwithcorona => {
      this.SickWithCorona = sickwithcorona;
      console.log(this.SickWithCorona);
    });
  }

  getCoronaDate(UserId:number) {
    this.sickwithcoronaService.getCoronaDate(UserId).subscribe(sickwithcorona => {
      this.SickWithCorona = sickwithcorona;
      console.log(this.SickWithCorona);
    });
  }

  removeSickWithCorona(sickwithcorona: SickWithCorona) {

    this.sickwithcoronaService.deleteSickWithCorona(sickwithcorona.sickId).subscribe(state=>{
        let ind = this.SickWithCorona.indexOf(sickwithcorona);
        this.SickWithCorona.splice(ind, 1);
    })
  }
}
