import { Component, OnInit } from '@angular/core';
import { EventService } from '../services/event.service'; // Certifique-se do caminho correto

@Component({
  selector: 'app-event-list',
  templateUrl: './event-list.component.html',
  styleUrls: ['./event-list.component.css']
})
export class EventListComponent implements OnInit {
  eventos: any[] = [];

  constructor(private eventService: EventService) {}

  ngOnInit() {
    this.eventService.getEventos().subscribe({
      next: (data) => {
        this.eventos = data;
      },
      error: (error) => {
        console.error('Erro ao buscar eventos:', error);
      }
    });
  }
}
