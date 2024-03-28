import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { VaccinationDetail } from 'src/models/VaccinationDetail';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class VaccinationdetailService {
  constructor(private  http:HttpClient) { }
  apiUrl="https://localhost:7076/api/VaccinationDetail"
 getVaccinationDetail(): Observable<VaccinationDetail[]> {
  return this.http.get<VaccinationDetail[]>(this.apiUrl)

}

getUserVaccination(UserId: number): Observable<VaccinationDetail[]> {
  return this.http.get<VaccinationDetail[]>(`${this.apiUrl}/` + UserId);
}

updateVaccinationDetail(vaccinationdetail: VaccinationDetail, vaccinationId: number): Observable<any> {
  return this.http.post<any>(`${this.apiUrl}/${vaccinationId}`, vaccinationdetail);
}

addVaccinationDetail(vaccinationdetail: VaccinationDetail): Observable<any> {
  return this.http.put<any>(`${this.apiUrl}/`, vaccinationdetail);
}

deleteVaccinationDetail(vaccinationId: any): Observable<any> {
  return this.http.delete<any>(`${this.apiUrl}/` + vaccinationId);
}

}
