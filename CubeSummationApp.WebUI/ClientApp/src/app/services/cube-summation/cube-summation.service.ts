import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { _throw } from 'rxjs/observable/throw'
import { catchError, tap, map } from 'rxjs/operators';
import { ICube } from '../../models/ICube';

@Injectable()
export class CubeSummationService {
  private cubeControllertUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.cubeControllertUrl = baseUrl + 'api/Cube';
  }

  resolveCube(cubos: ICube[]): Observable<any> {   
    return this.http.post(this.cubeControllertUrl + '/ResolveCube', cubos).pipe(
      tap(data => console.log('All: ' + JSON.stringify(data))),
      catchError(this.handleError)
    );
  }

  private handleError(err: HttpErrorResponse) {    
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {      
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {      
      errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }
    console.error(errorMessage);
    return _throw(errorMessage);
  }
}
