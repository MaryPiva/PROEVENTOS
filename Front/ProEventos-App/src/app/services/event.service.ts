import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EventService {
  private apiUrl = 'https://api.exemplo.com/eventos'; // Substitua pela URL real

  constructor(private http: HttpClient) {}

  getEventos(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }
}
