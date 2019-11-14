//Este arquivo contribui para que apenas algumas habilidades apareçam
//em cada lista de filtro.

import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
    name: 'filterTypeSkill',
    pure: false
})
export class FilterSkillPipe implements PipeTransform {
    transform(items: any[], typeSkyll : string): any {
        
        // filter items array, items which match and return true will be
        // kept, false will be filtered out
        // return items.filter(item => item.fkIdTipoSkillNavigation.id === typeSkyll);
    }
}