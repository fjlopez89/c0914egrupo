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

  constructor(
      private tareaService: TareaService,
      private tipotareaService: TipoTareaService,
    private route: ActivatedRoute,
    private location: Location
  ) { }

 

  ngOnInit(): void {
    
  }

    add(nombre: string, TipoTareaId: number): void {
        if (!nombre) { return; }
        this.tareaService.create(nombre, TipoTareaId)
            .then(tarea => {
                this.tareas.push(tarea);
             
            });

    }

  save(): void {
      this.tareaService.update(this.tarea)
      .then(() => this.goBack());
  }

  goBack(): void {
    this.location.back();
  }
}
