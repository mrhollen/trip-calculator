import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'absoluteValue'
})
export class AbsoluteValuePipe implements PipeTransform {
  transform(value: any, args?: any): any {
    if (typeof(value) === 'number') {
      return Math.abs(value);
    }
  }
}
