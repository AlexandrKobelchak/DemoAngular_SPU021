import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthorizeGuard } from 'src/api-authorization/authorize.guard';
import {HomeComponent} from "./home/home.component";
import {CounterComponent} from "./counter/counter.component";
import {FetchDataComponent} from "./fetch-data/fetch-data.component";

const routes: Routes = [
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
