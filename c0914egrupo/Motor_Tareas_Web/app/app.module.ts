import './rxjs-extensions';

import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule }   from '@angular/forms';
import { HttpModule }    from '@angular/http';

// Imports for loading & configuring the in-memory web api
import { InMemoryWebApiModule } from 'angular-in-memory-web-api';
//import { InMemoryDataService }  from './in-memory-data.service';

import { AppComponent }         from './app.component';
import { DashboardComponent }   from './dashboard.component';
import { ProcesosComponent }      from './procesos.component';
import { ProcesoDetailComponent }  from './proceso-detail.component';
import { ProcesoService }          from './proceso.service';

import { TareaComponent }      from './tareas.component';
import { TareaDetailComponent }  from './tarea-detail.component';
import { TareaService }          from './tarea.service';

import { routing }              from './app.routing';

@NgModule({
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    routing
  ],
  declarations: [
    AppComponent,
    DashboardComponent,
    ProcesoDetailComponent,
    TareasComponent,
    TareaDetailComponent,
    ProcesosComponent,
  ],
  providers: [
      ProcesoService,
      TareaService,
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule {
}
