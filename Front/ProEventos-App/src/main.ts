import { bootstrapApplication } from '@angular/platform-browser';
import { provideHttpClient, withFetch } from '@angular/common/http';  // Importando 'withFetch'
import { AppComponent } from './app/app.component';

bootstrapApplication(AppComponent, {
  providers: [
    provideHttpClient(withFetch())  // Configura 'fetch' para o HttpClient
  ]
})
  .catch(err => console.error(err));
