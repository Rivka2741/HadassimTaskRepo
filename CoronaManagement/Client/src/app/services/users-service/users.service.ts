import { Injectable } from '@angular/core';
import { Users } from 'src/models/Users';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';



@Injectable({
  providedIn: 'root'
})
export class UsersService {

 constructor(private  http:HttpClient) { }
 apiUrl="https://localhost:7076/api/User"
getUser(): Observable<Users[]> {
  return this.http.get<Users[]>(this.apiUrl)

}

getUserById(identityCard: string): Observable<Users> {
  // return this.http.get<Users>(`${this.apiUrl}/User/` + UserId);
  return this.http.get<Users>(`${this.apiUrl}/` + identityCard);
}

updateUser(user: Users): Observable<any> {
  return this.http.post<any>(`${this.apiUrl}`, user);
}

addUser(user: Users): Observable<any> {
  return this.http.put<any>(`${this.apiUrl}/`, user);
}

deleteUser(UserId: any): Observable<any> {
  return this.http.delete<any>(`${this.apiUrl}/` + UserId);
}

uploadUserPhoto(userId: string, photoData: File): Observable<any> {
  const formData: FormData = new FormData();
  formData.append('PhotoData', photoData, photoData.name);

  return this.http.post<any>(`${this.apiUrl}/${userId}`, formData);
}

}
