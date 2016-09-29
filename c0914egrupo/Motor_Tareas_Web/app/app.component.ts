import { Component }          from '@angular/core';

@Component({
  selector: 'my-app',

  template: `
    <nav class="navbar navbar-inverse navbar-static-top">
      <div class="container">
        <div class="navbar-header">
          <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </button>
          <a class="navbar-brand" href="#">{{title}}</a>
        </div>
        <div id="navbar" class="navbar-collapse collapse">
          <ul class="nav navbar-nav navbar-right">
            <li class="active"><a routerLink="/Tareas" routerLinkActive="active">Tareas</a></li>
            <li><a routerLink="/Procesos" routerLinkActive="active">Procesos</a></li>
          </ul>
        </div><!--/.nav-collapse -->
      </div>
    </nav>
    <router-outlet></router-outlet>
  `,
  styleUrls: ['app/app.component.css']
})
export class AppComponent {
  title = 'Motor de Tareas';
}
