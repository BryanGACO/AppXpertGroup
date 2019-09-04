import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ICube } from '../models/ICube';
import { Cube } from '../models/Cube';
import { CubeSummationService } from '../services/cube-summation/cube-summation.service';
import { forEach } from '@angular/router/src/utils/collection';

@Component({
  selector: 'cube-summation',
  templateUrl: './cube-summation.component.html'
})
export class CubeSummationComponent {

  CasosDePrueba: number;
  Resultados: [];

  cubos: ICube[] = [];

  constructor(private cubeSummationService: CubeSummationService) {
  }

  errorMessage: string;

  setTestCases() {
    this.cubos.length = 0;
    for (let i = 0; i < this.CasosDePrueba; i++) {
      let cubo = new Cube();
      cubo.Id = i + 1;
      this.cubos.push(cubo);
    }
  }

  resolveCube() {
    this.cubeSummationService.resolveCube(this.cubos).subscribe(
      result => this.setAnswers(result),
      error => this.errorMessage = <any>error);
  }

  setAnswers(answers) {
    for (let i = 0; i < this.cubos.length; i++) {
      let cubo = this.cubos[i];
      cubo.ArrayRptas = answers[i];      
    }    
  }
}











