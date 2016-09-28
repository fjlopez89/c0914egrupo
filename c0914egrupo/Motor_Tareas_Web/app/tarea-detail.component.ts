import { Component, OnInit }      from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { Location }               from '@angular/common';

import { Tarea }        from './tarea';
import { TareaService } from './tarea.service';

import { TipoTarea }        from './tipotarea';
import { TipoTareaService } from './tipotarea.service';

@Component({
  moduleId: module.id,
  selector: 'my-tarea-detail',
  templateUrl: 'tarea-detail.component.html',
  styleUrls: [ 'tarea-detail.component.css' ]
})
export class TareaDetailComponent implements OnInit {
  tarea: Tarea;
  tipotareas: TipoTarea[];
  constructor(
      private tareaService: TareaService,
      private tipotareaService: TipoTareaService,
    private route: ActivatedRoute,
    private location: Location
  ) { }

 

  ngOnInit(): void {
    this.route.params.forEach((params: Params) => {
      let id = +params['id'];
      this.tareaService.getTarea(id)
        .then(tarea => this.tarea = tarea);
      });
    this.route.params.forEach((params: Params) => {
        this.tipotareaService.getTipoTareas().then(tipotareas => this.tipotareas = tipotareas);
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
