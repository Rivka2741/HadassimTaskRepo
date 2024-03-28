import { Injectable } from '@angular/core';
import { SickWithCorona } from 'src/models/SickWithCorona';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class SickwithcoronaService{

 constructor(private  http:HttpClient) { }
 apiUrl="https://localhost:7076/api/SickWithCorona"
 getSickWithCorona(): Observable<SickWithCorona[]> {
  return this.http.get<SickWithCorona[]>(this.apiUrl)

}

getCoronaDate(UserId: number): Observable<SickWithCorona[]> {
  // return this.http.get<Users>(`${this.apiUrl}/User/` + UserId);
  return this.http.get<SickWithCorona[]>(`${this.apiUrl}/` + UserId);
}

updateSickWithCorona(sickwithcorona: SickWithCorona, SickId: number): Observable<any> {
  return this.http.post<any>(`${this.apiUrl}/${SickId}`, sickwithcorona);
}

addSickWithCorona(sickwithcorona: SickWithCorona): Observable<any> {
  return this.http.put<any>(`${this.apiUrl}/`, sickwithcorona);
}

deleteSickWithCorona(SickId: any): Observable<any> {
  return this.http.delete<any>(`${this.apiUrl}/` + SickId);
}

}
