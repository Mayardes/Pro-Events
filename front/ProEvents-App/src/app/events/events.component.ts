import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css']
})
export class EventsComponent {

  //It's a object.
  public events: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventsHttp();
  }


  public getEvents(): void {
    this.events =
      [
        {
          Theme: 'Angular 16',
          Local: 'Belo Horizonte'
        },
        {
          Theme: '.Net',
          Local: 'Manaus'
        },
        {
          Theme: 'Angular and news',
          Local: 'Rio de Janeiro'
        }
      ]
  }

  public getEventsHttp(): void {

    this.http.get('http://localhost:5259/api/event')
      .subscribe(response => this.events = response, error => console.log(error));
  }

}
