import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  standalone: true,
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [
    {
      tema:'Angular 11',
      local: 'Belo Horizonte'
    },
    {
      tema:'.NET 5',
      local: 'Sao Paulo'
    },
    {
      tema:'Angular e suas novidades',
      local: 'Rio de Janeiro'
    }
]

  constructor() { }

  ngOnInit() {
  }

}
