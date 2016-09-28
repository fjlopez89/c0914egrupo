import { Component, OnInit } from '@angular/core';
import { Router }            from '@angular/router';

import { Tarea }                from './tarea';
import { TareaService }         from './tarea.service';

import { Proceso }                from './proceso';
import { ProcesoService }         from './proceso.service';

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

  constructor(
      private tareaService: TareaService,
      private procesoService: ProcesoService,
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

  add(nombre: string, TipoTareaId: number): void {
      if (!nombre) { return; }
      this.tareaService.create(nombre, TipoTareaId)
          .then(tarea => {
              this.tareas.push(tarea);
              this.selectedTarea = null;
              this.getProcesos();
              this.getTareas();
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
  }

  onSelect(tarea: Tarea): void {
    this.selectedTarea = tarea;
  }

  gotoDetail(): void {
    this.router.navigate(['/detail', this.selectedTarea.id]);
  }
}

