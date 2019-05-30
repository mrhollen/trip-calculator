import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Person } from '../models/person';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TripService {

  constructor(private http: HttpClient) { }

  public settleUpTrip(people: Person[]): Observable<Person[]> {
    return this.http.post<Person[]>('http://localhost:8080/api/trip/settle-up', people);
  }
}
