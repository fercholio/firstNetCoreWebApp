import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'people',
    templateUrl: './people.component.html'
})
export class PeopleComponent {
    public persons: Person[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get("http://localhost:59241/" + 'api/people/').subscribe(result => {
            this.persons = result.json() as Person[];
            },
            error => {
                console.error(error)
            });
    }
}

interface Person {
    id: number;
    firstName: string;
    lastName: string;
    fullName: string;
    age: number,
}
