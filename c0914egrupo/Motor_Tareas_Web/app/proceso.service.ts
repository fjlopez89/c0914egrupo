import { Injectable }    from '@angular/core';
import { Headers, Http } from '@angular/http';

import 'rxjs/add/operator/toPromise';

import { Proceso } from './proceso';

@Injectable()
export class ProcesoService {

  private headers = new Headers({'Content-Type': 'application/json'});
  private procesosUrl = 'api/procesos';  // URL to web api

  constructor(private http: Http) { }

  getProcesos(): Promise<Proceso[]> {
    return this.http.get(this.procesosUrl)
               .toPromise()
               .then(response => response.json() as Proceso[])
               .catch(this.handleError);
  }

  getProceso(id: number): Promise<Proceso> {
    return this.getProcesos()
               .then(procesos => procesos.find(proceso => proceso.id === id));
  }

  delete(id: number): Promise<void> {
    let url = `${this.procesosUrl}/${id}`;
    return this.http.delete(url, {headers: this.headers})
      .toPromise()
      .then(() => null)
      .catch(this.handleError);
  }

  create(nombre: string): Promise<Proceso> {
    return this.http
      .post(this.procesosUrl, JSON.stringify({nombre: nombre}), {headers: this.headers})
      .toPromise()
      .then(res => res.json())
      .catch(this.handleError);
  }

  update(proceso: Proceso): Promise<Proceso> {
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


