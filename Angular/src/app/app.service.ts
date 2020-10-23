import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { timer } from 'rxjs';
import { ICriteria } from './Shared/models/criteria';
import { IEmployee } from './Shared/models/employee';

@Injectable({
  providedIn: 'root',
})
export class AppService {
  baseUrl = 'https://localhost:44316/api/Employee/';
  constructor(private http: HttpClient) {}
  getAllEmployees(): any {
    return this.http.get<IEmployee[]>(this.baseUrl + 'GetAll');
  }

  searchWithCriteria(value): any {
    return this.http.get<IEmployee[]>(this.baseUrl + 'Search?name=' + value);
  }

  searchWithModel(model): any {
    console.log(model);
    return this.http.post<IEmployee[]>(this.baseUrl + 'Criteria', model);
  }
}
