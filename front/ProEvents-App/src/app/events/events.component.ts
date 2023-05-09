import { Component } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css']
})
export class EventsComponent {

  //It's a object.
  public events: any = [
    {
      Theme: 'Angular 16',
      Local: 'Belo Horizonte' 
    },
    {
      Theme: '.Net 7',
      Local: 'São Paulo' 
    },
    {
      Theme: 'Angular e suas novidades',
      Local: 'Rio de Janeiro' 
    }
  ]

  constructor() { }

  ngOnInit(): void {

  }

}
