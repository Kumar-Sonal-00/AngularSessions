import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'length',
  standalone: true
})
export class LengthPipe implements PipeTransform {

  transform(value: string, ...args: string[]): unknown {    
    if(args[0]=='M'){
      return value.length +', Male';
    }else{
      return value.length + ', Female';
    }    
  }

}
