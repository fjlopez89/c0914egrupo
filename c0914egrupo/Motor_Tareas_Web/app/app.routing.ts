import { ModuleWithProviders }  from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


import { ProcesosComponent }     from './procesos.component';
import { ProcesoDetailComponent } from './proceso-detail.component';



const appRoutes: Routes = [
  {
    path: '',
    redirectTo: '/procesos',
    pathMatch: 'full'
  },
  {
    path: 'detail/:id',
    component: ProcesoDetailComponent
  },
  {
    path: 'procesos',
    component: ProcesosComponent
  }

];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);


