import { Component, OnInit }      from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { Location }               from '@angular/common';

import { Proceso }        from './proceso';
import { ProcesoService } from './proceso.service';

@Component({
  moduleId: module.id,
  selector: 'my-proceso-detail',
  templateUrl: 'proceso-detail.component.html',
  styleUrls: [ 'proceso-detail.component.css' ]
})
export class ProcesoDetailComponent implements OnInit {
  proceso: Proceso;

  constructor(
    private procesoService: ProcesoService,
    private route: ActivatedRoute,
    private location: Location
  ) {}

  ngOnInit(): void {
    this.route.params.forEach((params: Params) => {
      let id = +params['id'];
      this.procesoService.getProceso(id)
        .then(proceso => this.proceso = proceso);
    });
  }

  save(): void {
    this.procesoService.update(this.proceso)
      .then(() => this.goBack());
  }

  goBack(): void {
    this.location.back();
  }
}
