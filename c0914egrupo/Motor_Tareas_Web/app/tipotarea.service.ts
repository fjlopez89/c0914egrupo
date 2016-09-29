import { Injectable }    from '@angular/core';
import { Headers, Http } from '@angular/http';

import 'rxjs/add/operator/toPromise';

import { TipoTarea } from './tipotarea';

@Injectable()
export class TipoTareaService {

  private headers = new Headers({'Content-Type': 'application/json'});
  private tipotareasUrl = 'api/TipoTareas';  // URL to web api

  constructor(private http: Http) { }

  getTipoTareas(): Promise<TipoTarea[]> {
    return this.http.get(this.tipotareasUrl)
               .toPromise()
               .then(response => response.json() as TipoTarea[])
               .catch(this.handleError);
  }

  getTipoTarea(id: number): Promise<TipoTarea> {
    return this.getTipoTareas()
        .then(tipotareas => tipotareas.find(tipotarea => tipotarea.tipotareaId === id));
  }

  delete(id: number): Promise<void> {
    let url = `${this.tipotareasUrl}/${id}`;
    return this.http.delete(url, {headers: this.headers})
      .toPromise()
      .then(() => null)
      .catch(this.handleError);
  }

  create( nombre: string): Promise<TipoTarea> {
      return this.http
          .post(this.tipotareasUrl, JSON.stringify({ nombre: nombre }), { headers: this.headers })
          .toPromise()
          .then(res => res.json())
          .catch(this.handleError);
  }

  update(tipotarea: TipoTarea): Promise<TipoTarea> {
      const url = `${this.tipotareasUrl}/${tipotarea.tipotareaId}`;
    return this.http
      .put(url, JSON.stringify(tipotarea), {headers: this.headers})
      .toPromise()
      .then(() => tipotarea)
      .catch(this.handleError);
  }

  private handleError(error: any): Promise<any> {
    console.error('An error occurred', error); // for demo purposes only
    return Promise.reject(error.message || error);
  }
}


