import { HttpClient } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';
import { IEmployee } from '../Shared/models/employee';

@Injectable({
  providedIn: 'root',
})
export class HomeService implements OnInit {
  baseUrl = 'https://localhost:44316/api/Employee/';

  constructor(private http: HttpClient) {}
  ngOnInit(): void {}
  getAllEmployees(): any {
    return this.http.get<IEmployee[]>(this.baseUrl + 'GetAll');
  }
  searchWithCriteria(value) {
    return this.http.get<IEmployee[]>(this.baseUrl + 'Search?name=' + value);
  }
  searchWithModel(model) {
    return this.http.post<IEmployee[]>(this.baseUrl + 'Criteria', model);
  }
}
