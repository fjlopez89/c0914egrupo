import { Component, OnInit }      from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { Location }               from '@angular/common';

import { Tarea }        from './tarea';
import { TareaService } from './tarea.service';

import { TipoTarea }        from './tipotarea';
import { TipoTareaService } from './tipotarea.service';

@Component({
  moduleId: module.id,
  selector: 'my-tarea-add',
  templateUrl: 'flujo-add.component.html',
  styleUrls: [ 'flujo-add.component.css' ]
})
export class FlujoAddComponent implements OnInit {
    tarea: Tarea;
    tareas: Tarea[];
    tipotareas: TipoTarea[];
    selectedTarea: Tarea;

  constructor(
      private tareaService: TareaService,
      private tipotareaService: TipoTareaService,
    private route: ActivatedRoute,
    private location: Location
  ) { }

  getTareas(): void {
      this.tareaService
          .getTareas()
          .then(tareas => this.tareas = tareas);
  }
  

  getTipoTareas(): void {
      this.tipotareaService
          .getTipoTareas()
          .then(tipotareas => this.tipotareas = tipotareas);
  }

  ngOnInit(): void {
      this.route.params.forEach((params: Params) => {
          this.tareaService.getTareas().then(tareas => this.tareas = tareas);
      });
      this.route.params.forEach((params: Params) => {
          this.tipotareaService.getTipoTareas().then(tipotareas => this.tipotareas = tipotareas);
      });

      this.tareas;
      this.tareas;
  }

    add(nombre: string, tipotareaId: number): void {
        if (!nombre) { return; }
        this.tareaService.create(nombre, tipotareaId)
            .then(tarea => {
                this.tareas.push(tarea);
                this.selectedTarea = null;
               
            });
        this.goBack();
        this.getTareas();
        this.getTipoTareas();
    }



  goBack(): void {
    this.location.back();
  }
}
