import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-barchartcomplex',
  templateUrl: './barchartcomplex.component.html',
  styleUrls: ['./barchartcomplex.component.scss'],
  template:
    '<plotly-plot [data]="graph.data" [layout]="graph.layout"></plotly-plot>',
})
export class BarchartcomplexComponent implements OnInit {
  constructor() {}

  ngOnInit(): void {}

  public graph = {
    data: [
      {
        x: [1, 2, 3],
        y: [2, 6, 3],
        type: 'scatter',
        mode: 'lines+points',
        marker: { color: 'red' },
      },
      { x: [1, 2, 3], y: [2, 5, 3], type: 'bar' },
    ],
    layout: { width: 320, height: 240, title: 'A Fancy Plot' },
  };
}
