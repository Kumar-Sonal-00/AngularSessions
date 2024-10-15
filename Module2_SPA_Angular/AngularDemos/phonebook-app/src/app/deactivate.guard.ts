import { CanDeactivateFn } from '@angular/router';

export const deactivateGuard: CanDeactivateFn<unknown> = (component, currentRoute, currentState, nextState) => {
  if(confirm('want to leave the page?')){
    return true;
  }else{
    return false;
  }
};
