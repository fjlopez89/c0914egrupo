import { Component, OnInit } from '@angular/core';
import { Router }            from '@angular/router';

import { Proceso }                from './proceso';
import { ProcesoService }         from './proceso.service';

@Component({
  moduleId: module.id,
  selector: 'my-procesos',
  templateUrl: 'procesos.component.html',
  styleUrls: [ 'procesos.component.css' ]
})
export class ProcesosComponent implements OnInit {
  procesos: Proceso[];
  selectedProceso: Proceso;

  constructor(
    private procesoService: ProcesoService,
    private router: Router) { }

  getProcesos(): void {
    this.procesoService
        .getProcesos()
        .then(procesos => this.procesos = procesos);
  }

  add(nombre: string): void {
    nombre = nombre.trim();
    if (!name) { return; }
    this.procesoService.create(nombre)
      .then(proceso => {
        this.procesos.push(proceso);
        this.selectedProceso = null;
      });
  }

  delete(proceso: Proceso): void {
    this.procesoService
        .delete(proceso.id)
        .then(() => {
          this.procesos = this.procesos.filter(p => p !== proceso);
          if (this.selectedProceso === proceso) { this.selectedProceso = null; }
        });
  }

  ngOnInit(): void {
    this.getProcesos();
  }

  onSelect(proceso: Proceso): void {
    this.selectedProceso = proceso;
  }

  gotoDetail(): void {
    this.router.navigate(['/detail', this.selectedProceso.id]);
  }
}

