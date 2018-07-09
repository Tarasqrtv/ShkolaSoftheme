import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-articledetails',
  templateUrl: './articledetails.component.html',
  styleUrls: ['./articledetails.component.css']
})
export class ArticledetailsComponent {

  article = {
    id: 1,
    title: 'Як знімали рекламу Apple в Україні',
    shortDescription: 'Режисер кліпу Rolling in the Deep, скейтер з Іспанії та оператор на роликах з Південної Африки.'
  };

  changeColor() {
    this.isClicked = !this.isClicked;
  }

  heading: string;

  isClicked = true;
}