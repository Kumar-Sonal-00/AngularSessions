import { HttpInterceptorFn } from '@angular/common/http';
import { inject } from '@angular/core';
import { Router } from '@angular/router';
import { catchError, throwError } from 'rxjs';

export const httpErrorInterceptor: HttpInterceptorFn = (req, next) => {
  let reqClone=req.clone();
  let router=inject(Router);
  
  //reqClone.url
  return next(req).pipe(catchError(error=>{
    return throwError(()=>error);
  }));
};
