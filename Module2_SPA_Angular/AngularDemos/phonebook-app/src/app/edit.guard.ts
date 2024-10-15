import { inject } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivateFn, GuardResult, MaybeAsync, Router, RouterStateSnapshot } from '@angular/router';

export const editGuard: CanActivateFn = (route, state) => {
  //inject the router service
  const router=inject(Router);

  //check username and password is valid or not based on token
  let token=localStorage.getItem("token");
  if(token===null){
    //navigate to login    
    localStorage.setItem('redirectUrl',state.url);
    router.navigate(['/login']);
    return false;
  }else{    
     return true;
  }  
};
