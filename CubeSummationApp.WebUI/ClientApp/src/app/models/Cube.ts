import { ICube } from './ICube';
import { IQuery } from './IQuery';
import { Query } from './Query';

export class Cube implements ICube {

  Dimension: number;
  Operaciones: number;

  Id: number;
  ArrayPtos: number[] = [];
  ArrayRptas: number[] = [];
  Queries: Query[] = [];

  get _dimension(): number {
    return this.Dimension;
  }

  set _dimension(value: number) {
    this.Dimension = value;

    this.ArrayPtos = [];

    for (let i = 1; i <= this.Dimension; i++) {
      this.ArrayPtos.push(i);
    }
  }

  get _operaciones(): number {
    return this.Operaciones;
  }

  set _operaciones(value: number) {
    this.Operaciones = value;
    this.Queries = [];
    for (let i = 0; i < this.Operaciones; i++) {
      var query = new Query();
      this.Queries.push(query);
    }
  }
}
