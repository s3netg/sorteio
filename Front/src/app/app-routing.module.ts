import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DeficienteComponent } from './sorteio/deficiente/deficiente.component';
import { GeralComponent } from './sorteio/geral/geral.component';
import { IdosoComponent } from './sorteio/idoso/idoso.component';
const routes: Routes = [


  { path: 'Idoso', component: IdosoComponent },
  { path: 'Deficiente', component: DeficienteComponent },
  { path: 'Geral', component: GeralComponent },
  { path: '', redirectTo: 'Geral', pathMatch: 'full' },
  { path: '**', redirectTo: 'Geral', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})


export class AppRoutingModule { }
