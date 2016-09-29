import { Component, OnInit } from '@angular/core';
import { Router }            from '@angular/router';

import { Tarea }                from './tarea';
import { TareaService }         from './tarea.service';

import { Proceso }                from './proceso';
import { ProcesoService }         from './proceso.service';

import { TipoTarea }                from './tipotarea';
import { TipoTareaService }         from './tipotarea.service';

@Component({
  moduleId: module.id,
  selector: 'my-tareas',
  templateUrl: 'tareas.component.html',
  styleUrls: [ 'tareas.component.css' ]
})
export class TareasComponent implements OnInit {
  tareas: Tarea[];
  selectedTarea: Tarea;
  procesos: Proceso[];
  tipotareas: TipoTarea[];

  constructor(
      private tareaService: TareaService,
      private procesoService: ProcesoService,
      private tipotareaService: TipoTareaService,
    private router: Router) { }

  getTareas(): void {
    this.tareaService
        .getTareas()
        .then(tareas => this.tareas = tareas);
  }
  getProcesos(): void {
      this.procesoService
          .getProcesos()
          .then(procesos => this.procesos = procesos);
  }

    getTipoTareas(): void {
        this.tipotareaService
            .getTipoTareas()
            .then(tipotareas => this.tipotareas = tipotareas);
    }

  add(nombre: string, TipoTareaId: number): void {
      if (!nombre) { return; }
      this.tareaService.create(nombre, TipoTareaId)
          .then(tarea => {
              this.tareas.push(tarea);
              this.selectedTarea = null;
              this.getProcesos();
              this.getTareas();
              this.getTipoTareas();
          });

  }

  delete(tarea: Tarea): void {
    this.tareaService
        .delete(tarea.id)
        .then(() => {
          this.tareas = this.tareas.filter(p => p !== tarea);
          if (this.selectedTarea === tarea) { this.selectedTarea = null; }
        });
  }

  ngOnInit(): void {
      this.getTareas();
      this.getTipoTareas();
  }

  onSelect(tarea: Tarea): void {
    this.selectedTarea = tarea;
  }

  gotoDetail2(): void {
    this.router.navigate(['/detail2', this.selectedTarea.id]);
  }
  gotoAdd(): void {
      this.router.navigate(['/add']);
  }
}

