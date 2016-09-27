import './rxjs-extensions';

import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule }   from '@angular/forms';
import { HttpModule }    from '@angular/http';

// Imports for loading & configuring the in-memory web api
import { InMemoryWebApiModule } from 'angular-in-memory-web-api';
//import { InMemoryDataService }  from './in-memory-data.service';

import { AppComponent }         from './app.component';

import { ProcesosComponent }      from './procesos.component';
import { ProcesoDetailComponent }  from './proceso-detail.component';
import { ProcesoService }          from './proceso.service';



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
    ProcesoDetailComponent,
  
    ProcesosComponent,
  ],
  providers: [
      ProcesoService,
  
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule {
}
