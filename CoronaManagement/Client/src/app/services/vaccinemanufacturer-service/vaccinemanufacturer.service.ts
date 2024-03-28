import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { VaccineManufacturer } from 'src/models/VaccineManufacturer';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class VaccinemanufacturerService {

  constructor(private  http:HttpClient) { 
  }
  apiUrl="https://localhost:7076/api/VaccineManufacturer"
  getVaccineManufacturer(): Observable<VaccineManufacturer[]> {
    return this.http.get<VaccineManufacturer[]>(this.apiUrl)
  
  }
  getVaccineManufacturerById(manufacturerId: number): Observable<VaccineManufacturer> {
    return this.http.get<VaccineManufacturer>(`${this.apiUrl}/` + manufacturerId);
  }
  
  updateVaccineManufacturer(vaccinemanufacturer: VaccineManufacturer, manufacturerId: number): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/${manufacturerId}`, vaccinemanufacturer);
  }
  
  addVaccineManufacturer(vaccinemanufacturer: VaccineManufacturer): Observable<any> {
    return this.http.put<any>(`${this.apiUrl}/`, vaccinemanufacturer);
  }
  
  deleteVaccineManufacturer(manufacturerId: any): Observable<any> {
    return this.http.delete<any>(`${this.apiUrl}/` + manufacturerId);
  }


}
