import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { timer } from 'rxjs';
import { ICriteria } from '../Shared/models/criteria';
import { IEmployee } from '../Shared/models/employee';
import { HomeService } from './home.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  employees: IEmployee[];
  TotalSalary = 0;
  criteria: ICriteria = { name: '', to: 10000 , from: 0 };
  title = 'Angular';
  ngOnInit(): void {
    this.getEmployees();
  }
  constructor(private homeService: HomeService) {}
  getEmployees(): void {
    this.homeService.getAllEmployees().subscribe(
      (response) => {
        this.employees = response;
        response.forEach(element => {
          this.TotalSalary += element.salary;
        });
      },
      (error) => {
        console.log(error);
      }
    );
  }

  OnSearch(event) {
    this.criteria.name = event.target.value;
    console.log(this.criteria);
    timer(1500).subscribe(() => {
      this.homeService.searchWithModel(this.criteria).subscribe(
        (response) => {
          this.employees = response;
        },
        (error) => {
          console.log(error);
        }
      );
    });
  }
  sortByPrice(event){
    this.criteria.from = Number(event.target.value);
    timer(1500).subscribe(() => {
      this.homeService.searchWithModel(this.criteria).subscribe(
        (response) => {
          this.employees = response;
        },
        (error) => {
          console.log(error);
        }
      );
    });
  }
}