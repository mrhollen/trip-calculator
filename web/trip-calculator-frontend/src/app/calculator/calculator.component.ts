import { Component, OnInit } from '@angular/core';
import { TripService } from '../services/trip.service';
import { Person } from '../models/person';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {
  private people: Person[] = [
    new Person('Ted', [100, 12.5, 23, 53, 1.59]),
    new Person('Susan', [100, 23.43, 12.23, 1.60]),
  ];
  private newExpenses: number[] = [];
  private newPersonName = '';

  get total(): number {
    let total = 0;
    for (const person of this.people) {
      total += person.getTotal();
    }
    return total;
  }

  get average(): number {
    if ( this.people.length > 0) {
      return this.total / this.people.length;
    } else {
      return 0;
    }
  }

  constructor(private tripService: TripService) { }

  ngOnInit() {
  }

  public onAddPersonClick() {
    if (this.newPersonName) {
      this.people.push(new Person(this.newPersonName, []));
      this.newPersonName = '';
    }
  }

  public onRemovePersonClick(person: Person) {
    const index = this.people.indexOf(person);
    if (index !== -1) {
      this.people.splice(index, 1);
    }
  }

  public onAddNewExpenseClick(person: Person) {
    if (this.newExpenses[person.identifier] && this.newExpenses[person.identifier] > 0) {
      person.expenses.push(this.newExpenses[person.identifier]);
      delete this.newExpenses[person.identifier];
    }
  }
}
