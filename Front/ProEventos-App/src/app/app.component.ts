import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { EventosComponent} from './eventos/eventos.component';
import { PalestrantesComponent } from './palestrantes/palestrantes.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, EventosComponent, PalestrantesComponent],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'ProEventos-App';
}
