import { ModuleWithProviders }  from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


import { ProcesosComponent }     from './procesos.component';
import { ProcesoDetailComponent } from './proceso-detail.component';

import { TareasComponent }     from './tareas.component';
import { TareaDetailComponent } from './tarea-detail.component';

import { TareaAddComponent } from './tarea-add.component';



const appRoutes: Routes = [
  {
    path: '',
    redirectTo: '/Tareas',
    pathMatch: 'full'
  },
  {
    path: 'detail/:id',
    component: ProcesoDetailComponent
  },
  {
    path: 'Procesos',
    component: ProcesosComponent
  },
  {
      path: 'Tareas',
      component: TareasComponent
  },
  {
      path: 'detail2/:id',
      component: TareaDetailComponent
  },
  {
      path: 'add',
      component: TareaAddComponent
  },

];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);


