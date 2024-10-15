import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'genderPipe',
  standalone: true
})
export class GenderPipe implements PipeTransform {

  transform(value: string, ...args: unknown[]): unknown {
     if(value==='Male'){
      return 'Mr. ';
     }
     return 'Miss. ';
  }

}
