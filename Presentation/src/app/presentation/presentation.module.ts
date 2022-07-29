import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './screens/home/home.component';
import { NavbarComponent } from './components/navbar/navbar.component';

import * as PlotlyJS from 'plotly.js-dist-min';
import { PlotlyModule } from 'angular-plotly.js';
import { BarchartcomplexComponent } from './components/barchartcomplex/barchartcomplex.component';

PlotlyModule.plotlyjs = PlotlyJS;

@NgModule({
  declarations: [
    HomeComponent,
    NavbarComponent,
    NavbarComponent,
    BarchartcomplexComponent,
  ],
  imports: [CommonModule, PlotlyModule],
  exports: [HomeComponent, NavbarComponent],
})
export class PresentationModule {}
