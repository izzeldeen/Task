import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {
addForm: FormGroup;
  constructor() { }

  ngOnInit(): void {
    this.createFromGroup();
  }

  createFromGroup(){
    
    this.addForm = new FormGroup({
      name: new FormControl('', Validators.required),
      salary: new FormControl('', Validators.required),
      birthday: new FormControl('', Validators.required),
      gender: new FormControl('', Validators.required)

    });

   
  }


  onSubmit(){
      
  }
}
