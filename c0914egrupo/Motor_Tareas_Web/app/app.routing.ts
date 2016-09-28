import { ModuleWithProviders }  from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


import { ProcesosComponent }     from './procesos.component';
import { ProcesoDetailComponent } from './proceso-detail.component';

import { TareasComponent }     from './tareas.component';
import { TareaDetailComponent } from './tarea-detail.component';



const appRoutes: Routes = [
  {
    path: '',
    redirectTo: '/tareas',
    pathMatch: 'full'
  },
  {
    path: 'detail/:id',
    component: ProcesoDetailComponent
  },
  {
    path: 'procesos',
    component: ProcesosComponent
  },
  {
      path: 'tareas',
      component: TareasComponent
  },
  {
      path: 'detail2/:id',
      component: TareaDetailComponent
  },

];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);


