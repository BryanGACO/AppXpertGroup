import { ICoordinate } from './ICoordinate';

export interface IQuery {
  Tipo: string;
  CoordenadaInicial: ICoordinate;
  CoordenadaFinal: ICoordinate;
}
