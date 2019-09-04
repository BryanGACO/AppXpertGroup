//import { Injectable, Inject } from '@angular/core';
//import { HttpClient, HttpErrorResponse } from '@angular/common/http';
////import { Observable } from 'rxjs';
//import { _throw } from 'rxjs/observable/throw'
////import { catchError, tap, map } from 'rxjs/operators';
////import { ICube } from '../../models/ICube';
//@Injectable({
//  providedIn: 'root'
//})
//export class CubeSummationService {
//  private productUrl: string;
//  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
//    this.productUrl = baseUrl + 'api/SampleData/ResolveCube';
//  }
//  //resolveCube(cubos: ICube[]): Observable<ICube | undefined> {
//  //  alert(this.productUrl);
//  //  return this.http.post(this.productUrl, cubos).pipe(
//  //   tap(data => console.log('All: ' + JSON.stringify(data))),      
//  //   catchError(this.handleError)
//  //  );
//  //}
//  //getProduct(id: number): Observable<IProduct | undefined> {
//  //  return this.getProducts().pipe(
//  //    map((products: IProduct[]) => products.find(p => p.productId === id))
//  //  );
//  //}
//  //private handleError(err: HttpErrorResponse) {
//  //  // in a real world app, we may send the server to some remote logging infrastructure
//  //  // instead of just logging it to the console
//  //  let errorMessage = '';
//  //  if (err.error instanceof ErrorEvent) {
//  //    // A client-side or network error occurred. Handle it accordingly.
//  //    errorMessage = `An error occurred: ${err.error.message}`;
//  //  } else {
//  //    // The backend returned an unsuccessful response code.
//  //    // The response body may contain clues as to what went wrong,
//  //    errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
//  //  }
//  //  console.error(errorMessage);
//  //  return _throw(errorMessage);
//  //}
//}
//# sourceMappingURL=cube-summation.service.js.map