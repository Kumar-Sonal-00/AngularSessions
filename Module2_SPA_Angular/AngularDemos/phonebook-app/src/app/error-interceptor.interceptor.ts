import { HttpInterceptorFn } from '@angular/common/http';
import { catchError, throwError } from 'rxjs';

export const errorInterceptorInterceptor: HttpInterceptorFn = (req, next) => {
  return next(req).pipe(catchError((error:any)=>{
    console.log('Caught in errorInterceptor',error.message);
    return throwError(()=>"Url not found");
  }));
};
