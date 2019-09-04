import { IQuery } from './IQuery';
import { ICoordinate } from './ICoordinate';
import { Coordinate } from './Coordinate';

export class Query implements IQuery {
  Tipo: string;
  CoordenadaInicial: ICoordinate;
  CoordenadaFinal: ICoordinate;

  constructor() {
    this.CoordenadaInicial = new Coordinate();
    this.CoordenadaFinal = new Coordinate();
  }
}
