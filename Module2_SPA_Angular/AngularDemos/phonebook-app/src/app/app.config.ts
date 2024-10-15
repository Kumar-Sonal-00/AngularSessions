import { ApplicationConfig, ErrorHandler } from '@angular/core';
import { provideRouter } from '@angular/router';

import { routes } from './app.routes';
import { HTTP_INTERCEPTORS, provideHttpClient, withInterceptors } from '@angular/common/http';
import { httpErrorInterceptor } from './http-error-interceptor.interceptor';
import { GlobalErrorHandler } from './global.errorHandler';
import { errorInterceptorInterceptor } from './error-interceptor.interceptor';


export const appConfig: ApplicationConfig = {
  providers: [provideRouter(routes),
  // { //comment this to use HttpErrorInterceptor
  //   provide:ErrorHandler,
  //   useClass:GlobalErrorHandler
  // }
  provideHttpClient(withInterceptors([errorInterceptorInterceptor]))
]
};
