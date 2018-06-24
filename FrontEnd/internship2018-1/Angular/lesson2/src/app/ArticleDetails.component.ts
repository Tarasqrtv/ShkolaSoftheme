import { Component } from '@angular/core';
      
@Component({
    selector: 'articledetails-comp', 
    template:  '<div>{{Article}}</div> '
})
export class ArticleDetails { 
    Article :string  = ''
    ​title = '';
    ​shortDescription = '';
}