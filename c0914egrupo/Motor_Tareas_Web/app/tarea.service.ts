import { Injectable }    from '@angular/core';
import { Headers, Http } from '@angular/http';

import 'rxjs/add/operator/toPromise';

import { Tarea } from './tarea';

@Injectable()
export class TareaService {

  private headers = new Headers({'Content-Type': 'application/json'});
  private tareasUrl = 'api/tareas';  // URL to web api

  constructor(private http: Http) { }

  getTareas(): Promise<Tarea[]> {
    return this.http.get(this.tareasUrl)
               .toPromise()
               .then(response => response.json() as Tarea[])
               .catch(this.handleError);
  }

  getTarea(id: number): Promise<Tarea> {
    return this.getTareas()
               .then(tareas => tareas.find(tarea => tarea.id === id));
  }

  delete(id: number): Promise<void> {
    let url = `${this.tareasUrl}/${id}`;
    return this.http.delete(url, {headers: this.headers})
      .toPromise()
      .then(() => null)
      .catch(this.handleError);
  }

  create(nombre: string): Promise<Tarea> {
    return this.http
      .post(this.tareasUrl, JSON.stringify({nombre: nombre}), {headers: this.headers})
      .toPromise()
      .then(res => res.json())
      .catch(this.handleError);
  }

  update(proceso: Proceso): Promise<Tarea> {
    const url = `${this.procesosUrl}/${proceso.id}`;
    return this.http
      .put(url, JSON.stringify(proceso), {headers: this.headers})
      .toPromise()
      .then(() => proceso)
      .catch(this.handleError);
  }

  private handleError(error: any): Promise<any> {
    console.error('An error occurred', error); // for demo purposes only
    return Promise.reject(error.message || error);
  }
}

