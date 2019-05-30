import { v4 as uuid } from 'uuid';

export class Person {
    public identifier: string;
    public moneyOwed: {[name: string]: number};

    constructor(public name: string, public expenses: number[]) {
        this.identifier = uuid();
    }

    public getTotal(): number {
        let total = 0;
        for (const expense of this.expenses) {
            total += expense;
        }
        return total;
    }
}
