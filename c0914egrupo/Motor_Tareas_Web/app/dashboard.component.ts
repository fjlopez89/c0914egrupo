import { Component, OnInit } from '@angular/core';
import { Router }            from '@angular/router';

import { Proceso }        from './proceso';
import { ProcesoService } from './proceso.service';

@Component({
  moduleId: module.id,
  selector: 'my-dashboard',
  templateUrl: 'dashboard.component.html',
  styleUrls: [ 'dashboard.component.css' ]
})
export class DashboardComponent implements OnInit {
  procesos: Proceso[] = [];

  constructor(
    private router: Router,
    private procesoService: ProcesoService) {
  }

  ngOnInit(): void {
    this.procesoService.getProcesos()
      .then(procesos => this.procesos = procesos.slice(1, 5));
  }

  gotoDetail(proceso: Proceso): void {
    let link = ['/detail', proceso.id];
    this.router.navigate(link);
  }
}

