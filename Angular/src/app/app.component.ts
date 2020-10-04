import { Component, OnInit } from '@angular/core';
import { timer } from 'rxjs';
import { AppService } from './app.service';
import { ICriteria } from './Shared/models/criteria';
import { IEmployee } from './Shared/models/employee';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  employees: IEmployee[];
  criteria: ICriteria = { name: '', to: 10000 , from: 0 };

  title = 'Angular';
  ngOnInit(): void {
    this.getEmployees();
  }
  constructor(private appServices: AppService) {}
  getEmployees(): void {
    this.appServices.getAllEmployees().subscribe(
      (response) => {
        this.employees = response;
        console.log(response);
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
      this.appServices.searchWithModel(this.criteria).subscribe(
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
      this.appServices.searchWithModel(this.criteria).subscribe(
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
