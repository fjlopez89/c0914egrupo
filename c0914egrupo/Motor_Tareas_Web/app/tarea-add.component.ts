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
  templateUrl: 'tarea-add.component.html',
  styleUrls: [ 'tarea-add.component.css' ]
})
export class TareaAddComponent implements OnInit {
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

 

  ngOnInit(): void {
      this.route.params.forEach((params: Params) => {
          this.tareaService.getTareas().then(tareas => this.tareas = tareas);
      });
      this.route.params.forEach((params: Params) => {
          this.tipotareaService.getTipoTareas().then(tipotareas => this.tipotareas = tipotareas);
      });
  }

    add(nombre: string, tipotareaId: number): void {
        if (!nombre) { return; }
        this.tareaService.create(nombre, tipotareaId)
            .then(tarea => {
                this.tareas.push(tarea);
                this.selectedTarea = null;
               
            });
        this.goBack();
    }



  goBack(): void {
    this.location.back();
  }
}
