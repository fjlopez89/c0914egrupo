import { ModuleWithProviders }  from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DashboardComponent }  from './dashboard.component';
import { ProcesosComponent }     from './procesos.component';
import { ProcesoDetailComponent } from './proceso-detail.component';

import { TareasComponent }     from './tareas.component';
import { TareasDetailComponent } from './tareas-detail.component';

const appRoutes: Routes = [
  {
    path: '',
    redirectTo: '/dashboard',
    pathMatch: 'full'
  },
  {
    path: 'dashboard',
    component: DashboardComponent
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
      path: 'detail/:id',
      component: TareasDetailComponent
  }

];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);


